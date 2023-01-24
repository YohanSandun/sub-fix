using System.Diagnostics;
using System.Text;

namespace SubFix
{
    public partial class frmMain : Form
    {

        public enum State
        {
            Welcome, Input, Options, Output, Progress, Finished
        }

        private List<InputFile> _inputFiles = new List<InputFile>();
        private bool pendingCancel = false;
        private RulesContext _rulesContext = new RulesContext();
        private State _currentState = State.Welcome;
        private string _basePath = null;
        private bool _inputFromFolder = false;
        private bool _inputFromFile = false;
        private bool _inputFromMultipleLocations = false;

        private void switchState(State state)
        {
            _currentState = state;
            if (state == State.Input)
            {
                pWelcome.Visible = false;
                pInput.Visible = true;
                pInputFiles.Visible = true;
                pOptions.Visible = false;
                pOutput.Visible = false;
                pProgress.Visible = false;
                btnNext.Text = "&Next";
                btnBack.Enabled = true;
            }
            else if (state == State.Welcome)
            {
                pInput.Visible = false;
                pWelcome.Visible = true;

                btnBack.Enabled = false;
                btnNext.Text = "&Next";
            }
            else if (state == State.Options)
            {
                pWelcome.Visible = false;
                pInput.Visible = true;
                pProgress.Visible = false;
                pInputFiles.Visible = false;
                pOptions.Visible = true;
                pOutput.Visible = false;

                btnBack.Enabled = true;
                btnNext.Text = "&Next";
            }
            else if (state == State.Output)
            {
                pWelcome.Visible = false;
                pProgress.Visible = false;
                pInput.Visible = true;
                pInputFiles.Visible = false;
                pOptions.Visible = false;
                pOutput.Visible = true;

                btnBack.Enabled = true;
                btnNext.Text = "&Finish";
            }
            else if (state == State.Progress)
            {
                pWelcome.Visible = false;
                pProgress.Visible = true;
                pInput.Visible = true;
                pInputFiles.Visible = false;
                pOptions.Visible = false;
                pOutput.Visible = false;

                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        public frmMain()
        {
            InitializeComponent();

            _rulesContext.AddRule(new FontAddRule());
            switchState(State.Welcome);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFiles();
        }

        private void openFiles()
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                _basePath = dlgOpen.FileName.Replace(dlgOpen.SafeFileName, "");
                for (int i = 0; i < dlgOpen.FileNames.Length; i++)
                {
                    _inputFiles.Add(new InputFile(dlgOpen.FileNames[i], dlgOpen.SafeFileNames[i]));
                }
                refreshInputFilesList();
                
                if (_inputFromFolder || _inputFromFile)
                    _inputFromMultipleLocations = true;
                _inputFromFile = true;
            }
        }

        private void openFolder()
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                _basePath = dlgFolder.SelectedPath.EndsWith('\\') ? dlgFolder.SelectedPath : dlgFolder.SelectedPath + "\\";
                string[] files = Directory.GetFiles(dlgFolder.SelectedPath, "*.srt", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    _inputFiles.Add(new InputFile(file, Path.GetFileName(file)));
                }
                refreshInputFilesList();

                if (_inputFromFile || _inputFromFolder)
                    _inputFromMultipleLocations = true;
                _inputFromFolder = true;
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFiles();
        }

        private void mnuOpenFolder_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void refreshInputFilesList()
        {
            lstInput.Items.Clear();
            foreach (InputFile file in _inputFiles)
            {
                lstInput.Items.Add(file.Name);
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void lstInput_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lstInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toopTip.Show(_inputFiles[lstInput.SelectedIndex].FullName, lstInput, 0, 0, 3000);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private bool validateInputs()
        {
            bool value = _inputFiles.Count > 0;
            if (!value)
                MessageBox.Show("Please add at least one file to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return value;
        }

        private bool validateOptions()
        {
            bool value = chkFix.Checked | chkRemoveCopyright.Checked;
            if (!value)
                MessageBox.Show("Please choose at least one option from the list to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return value;
        }

        private bool validateOutput()
        {
            if (rbOverwrite.Checked)
                return MessageBox.Show("Are you sure want to replace the original file(s)?", "Save File(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

            if (_inputFromMultipleLocations)
            {
                MessageBox.Show("Cannot save to a different location when input files are from different locaitons.\nPlease choose Overwrite option to continue...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtOutput.Text.Trim().Length < 3)
            {
                MessageBox.Show("Please select a location to save the file(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentState == State.Welcome)
                switchState(State.Input);
            else if (_currentState == State.Input && validateInputs())
                switchState(State.Options);
            else if (_currentState == State.Options && validateOptions())
                switchState(State.Output);
            else if (_currentState == State.Output && validateOutput())
            {
                switchState(State.Progress);
                fixSubtitles();
            }
        }

        private void fixSubtitles()
        {
            try
            {
                pb.Value = 0;
                pb.Maximum = _inputFiles.Count - 1;
                for (int i = 0; i < _inputFiles.Count; i++)
                {
                    if (pendingCancel)
                    {
                        if (MessageBox.Show("Are you sure want to cancel?\n\nAlready " + (i + 1) + " files are affected and they cannot be recovered!", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            Application.Exit();
                        else
                            pendingCancel = false;
                    }

                    lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Applying rules " + _inputFiles[i].Name);
                    SRTParser parser = new SRTParser(_inputFiles[i].FullName);

                    SRTFile file = parser.Parse();
                    if (!file.HasError)
                    {

                        string fontName = rbIskoolaPota.Checked ? "Iskoola Pota" : "UN-Bindumathi";

                        OutputFile ofile = new OutputFile(
                                _inputFiles[i].FullName, _inputFiles[i].Name,
                                _rulesContext.ApplyRules(new FontAddRuleConfiguration(fontName), file).ToString());
                        lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Done " + _inputFiles[i].Name);
                        lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Saving to " + _inputFiles[i].Name);

                        if (rbOverwrite.Checked)
                        {
                            if (File.Exists(ofile.FullName))
                                File.Delete(ofile.FullName);
                            File.WriteAllText(ofile.FullName, ofile.Content);
                        }
                        else
                        {
                            ofile.FullName = ofile.FullName.Replace(_basePath, txtOutput.Text);
                            Directory.CreateDirectory(ofile.FullName.Replace(ofile.Name, ""));
                            if (File.Exists(ofile.FullName))
                                File.Delete(ofile.FullName);
                            File.WriteAllText(ofile.FullName, ofile.Content);
                        }
                    } else
                    {
                        lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Error : " + parser.ErrorDetails + " in " + _inputFiles[i].Name);
                    }
                    pb.Value = i;
                    lstLog.SelectedIndex = lstLog.Items.Count - 1;
                    Application.DoEvents();
                }
                pb.Value = pb.Maximum;
                saveLog();
                MessageBox.Show("Successfully fixed file(s)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Application.Exit();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pb.Value = 0;
                switchState(State.Output);
            }
        }

        private void saveLog()
        {
            string log = Application.StartupPath + "\\logs";
            Directory.CreateDirectory(log);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lstLog.Items.Count; i++)
                sb.AppendLine(lstLog.Items[i].ToString());
            File.WriteAllText(log + "\\" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss.txt"), sb.ToString());
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            _inputFiles.Clear();
            refreshInputFilesList();
            _inputFromFile = false;
            _inputFromFolder = false;
            _inputFromMultipleLocations = false;
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFiles();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentState == State.Input)
                switchState(State.Welcome);
            else if (_currentState == State.Options)
                switchState(State.Input);
            else if (_currentState == State.Output)
                switchState(State.Options);
        }

        private void rbOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            grpOutput.Enabled = rbChoose.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
                txtOutput.Text = dlgFolder.SelectedPath.EndsWith('\\') ? dlgFolder.SelectedPath : dlgFolder.SelectedPath + "\\";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_currentState == State.Progress)
                pendingCancel = true;
            else
            {
                if (MessageBox.Show("Are you sure want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void lblInstallFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.FileName = "SubFixFontInstaller.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    if (line == "Done")
                    {
                        MessageBox.Show("Font installed successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        break;
                    }
                    else
                        throw new Exception("Process failed : SubFixFontInstaller.exe");
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error while installing the font!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkFix_CheckedChanged(object sender, EventArgs e)
        {
            grpFont.Enabled = chkFix.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SRTParser parser = new SRTParser(@"E:\TVSeries\BLINDSPOT\S02\Bldst.S02E01\Blindspot S02E01-All HDTV copies.srt");
            SRTFile file = parser.Parse();
            if (!file.HasError)
            {
                MessageBox.Show(file.Segments[0].ToString());
            }
        }
    }
}