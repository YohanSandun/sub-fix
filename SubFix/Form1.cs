namespace SubFix
{
    public partial class frmMain : Form
    {
        private List<InputFile> inputFiles = new List<InputFile>();

        public frmMain()
        {
            InitializeComponent();
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
                    inputFiles.Add(new InputFile(dlgOpen.FileNames[i], dlgOpen.SafeFileNames[i]));
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
                    inputFiles.Add(new InputFile(file, Path.GetFileName(file)));
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
            foreach (InputFile file in inputFiles)
            {
                lstInput.Items.Add(file.Name);
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void lstInput_MouseHover(object sender, EventArgs e)
        {
            Point point = lstInput.PointToClient(Cursor.Position);
            int index = lstInput.IndexFromPoint(point);
            if (index < 0 || index >= inputFiles.Count)
                return;
            if (index == lstInput.SelectedIndex)
                return;

            lstInput.SelectedIndex = index;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void lstInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            toopTip.Show(inputFiles[lstInput.SelectedIndex].FullName, lstInput, 0, 0, 3000);
        }
    }
}