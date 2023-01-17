namespace SubFix
{
    public partial class frmMain : Form
    {
        private List<InputFile> _inputFiles = new List<InputFile>();
        private List<OutputFile> _outputFiles = new List<OutputFile>();
        private RulesContext _rulesContext = new RulesContext();

        public frmMain()
        {
            InitializeComponent();

            _rulesContext.AddRule(new ReplaceRule());
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
            /*
            lstInput.Items.Clear();
            foreach (InputFile file in _inputFiles)
            {
                lstInput.Items.Add(file.Name);
            }
            btnFix.Enabled = true;
            */
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
    }
}