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
                for (int i = 0; i < dlgOpen.FileNames.Length; i++)
                {
                    _inputFiles.Add(new InputFile(dlgOpen.FileNames[i], dlgOpen.SafeFileNames[i]));
                }
                refreshInputFilesList();
            }
        }

        private void openFolder()
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(dlgFolder.SelectedPath, "*.srt", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    _inputFiles.Add(new InputFile(file, Path.GetFileName(file)));
                }
                refreshInputFilesList();
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
            /*
            Point point = lstInput.PointToClient(Cursor.Position);
            int index = lstInput.IndexFromPoint(point);
            if (index < 0 || index >= _inputFiles.Count)
                return;
            if (index == lstInput.SelectedIndex)
                return;

            lstInput.SelectedIndex = index;
            */
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
            /*
            
            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to replace the original file(s)?", "Save File(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                /*
                pb.Maximum = _outputFiles.Count;
                pb.Value = 0;
                for (int i = 0; i < _outputFiles.Count; i++)
                {
                    File.Delete(_outputFiles[i].FullName);
                    File.WriteAllText(_outputFiles[i].FullName, _outputFiles[i].Content);
                    pb.Value = i;
                }
                pb.Value = pb.Maximum;
                MessageBox.Show("Successfully saved file(s)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pb.Value = 0;
                */
            }
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
                //SRTFile f = SRTParser.Parse(@"E:\TVSeries\1899\1899 (2022) S01E01 Sinhala Subtitles\1899.S01E01.1080p.NF.WEB-DL.DUAL.DDP5.1.Atmos.H.264-SMURF.Cineru.srt");
                //MessageBox.Show(f.Segments.Count.ToString());
            }
        }

        private void fixSubtitles()
        {
            pb.Value = 0;
            pb.Maximum = _inputFiles.Count - 1;
            for (int i = 0; i < _inputFiles.Count; i++)
            {
                if (pendingCancel)
                {
                    if (MessageBox.Show("Are you sure want to cancel?\n\nAlready " + (i+1) + " files are affected and they cannot be recovered!", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Application.Exit();
                    else
                        pendingCancel = false;
                }

                lstLog.Items.Add("Fixing... : " + _inputFiles[i].Name);
                SRTParser parser = new SRTParser(_inputFiles[i].FullName);

                OutputFile ofile = new OutputFile(
                        _inputFiles[i].FullName, _inputFiles[i].Name,
                        _rulesContext.ApplyRules(parser.Parse()).ToString());
                lstLog.Items.Add("Fixed : " + _inputFiles[i].Name);
                lstLog.Items.Add("Saving... : " + _inputFiles[i].Name);

                if (rbOverwrite.Checked)
                {
                    File.Delete(ofile.FullName);
                    File.WriteAllText(ofile.FullName, ofile.Content);
                }
                lstLog.Items.Add("Saved : " + ofile.FullName);

                pb.Value = i;
                Application.DoEvents();
            }
            pb.Value = pb.Maximum;
            MessageBox.Show("Successfully fixed file(s)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            pb.Value = 0;
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            _inputFiles.Clear();
            refreshInputFilesList();
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
    }
}