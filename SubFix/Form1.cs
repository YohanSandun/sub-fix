namespace SubFix
{
    public partial class frmMain : Form
    {

        public enum State
        {
            Welcome, Input, Options, Output, Progress, Finished
        }

        private List<InputFile> _inputFiles = new List<InputFile>();
        private List<OutputFile> _outputFiles = new List<OutputFile>();
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

                btnBack.Enabled = true;
            }
            else if (state == State.Welcome)
            {
                pInput.Visible = false;
                pWelcome.Visible = true;

                btnBack.Enabled = false;
            }
            else if (state == State.Options)
            {
                pWelcome.Visible = false;
                pInput.Visible = true;
                pInputFiles.Visible = false;
                pOptions.Visible = true;
                pOutput.Visible = false;

                btnBack.Enabled = true;
            }
            else if (state == State.Output)
            {
                pWelcome.Visible = false;
                pInput.Visible = true;
                pInputFiles.Visible = false;
                pOptions.Visible = false;
                pOutput.Visible = true;

                btnBack.Enabled = true;
            }
        }

        public frmMain()
        {
            InitializeComponent();

            _rulesContext.AddRule(new ReplaceRule());
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
            pb.Value = 0;
            pb.Maximum = _inputFiles.Count - 1;
            for (int i = 0; i < _inputFiles.Count; i++)
            {
                _outputFiles.Add(
                    new OutputFile(
                        _inputFiles[i].FullName, _inputFiles[i].Name, 
                        _rulesContext.ApplyRules(File.ReadAllText(_inputFiles[i].FullName)))
                    );
                pb.Value = i;
            }
            pb.Value = pb.Maximum;
            MessageBox.Show("Successfully fixed file(s)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnSave.Enabled = true;
            pb.Value = 0;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentState == State.Welcome)
                switchState(State.Input);
            else if (_currentState == State.Input && validateInputs())
                switchState(State.Options);
            else if (_currentState == State.Options && validateOptions())
                switchState(State.Output);
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
    }
}