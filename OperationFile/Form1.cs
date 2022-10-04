using System.Text;

namespace OperationFile
{
    public partial class Form1 : Form
    {
        private string _path;
        bool _isSelectedPath = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnAddFolder_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxbFolderName.Text))
            {
                MessageBox.Show("Wprowadz nazwę folderu");
                return;
            }
            else if (_isSelectedPath == false)
            {
                MessageBox.Show("Wprowadz sciezkę folderu!");
                return;
            }

            string folderName = TxbFolderName.Text;

            if (_isSelectedPath)
            {
                _path = $@"{_path}\{folderName}";

                if (!Directory.Exists(_path))
                {
                    Directory.CreateDirectory(_path);

                    MessageBox.Show($"Folder został utworzony w miejscu {_path}");

                    LbPath.Text = _path;
                }
                else
                {
                    MessageBox.Show("Wybrany folder juz istnieje", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxbFileName.Text))
            {
                MessageBox.Show("Wprowadz nazwę pliku!");
                return;
            }
            else if (_isSelectedPath == false)
            {
                MessageBox.Show("Wprowadz sciezkę pliku!");
                return;
            }

            bool isFileExists = IsFileExist();
            string fileName = TxbFileName.Text;
            _path = $@"{_path}\{fileName}.txt";

            if (!isFileExists)
            {
                using (var file = File.CreateText(_path))
                {
                    MessageBox.Show("Plik został utworzony");
                    file.Close();
                }
            }
        }
        private bool IsSelectedPath()
        {
            var folderBrowserDialog = new FolderBrowserDialog();//wybierz folder

            var dialogResult = folderBrowserDialog.ShowDialog();

            bool isSelectedPath = false;

            if (dialogResult == DialogResult.OK)
            {
                _path = folderBrowserDialog.SelectedPath;

                isSelectedPath = true;
            }
            return isSelectedPath;
        }

        private bool IsFileExist()
        {
            bool result = false;
            string fileName = TxbFileName.Text;
            bool isExstenstionExists = _path.Contains(".txt");
            string pathWithFile = $@"{_path}\{fileName}.txt";

            if (isExstenstionExists)
            {
                MessageBox.Show("niepoprawna sciezka");
                result = true;
            }
            else if (File.Exists(pathWithFile))
            {
                MessageBox.Show("Plik o podanej nazwie już istnieje!!!");
                result = true;
            }

            return result;
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            _isSelectedPath = IsSelectedPath();

            if (_isSelectedPath)
            {
                string fullNewpath = $@"{_path}";
                LbPath.Text = fullNewpath;
            }
        }
        private void BtnAddText_Click(object sender, EventArgs e)
        {
            string text = RTxbText.Text;

            bool fileValideted = IsFileValidation();

            if (fileValideted)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine(text);
                    streamWriter.Close();
                }
            }
        }
        private void BtnOverwrite_Click(object sender, EventArgs e)
        {
            string text = RTxbText.Text;
            bool fileValidation = IsFileValidation();

            if (fileValidation)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine(text);
                    streamWriter.Close();
                }
            }
        }
        private void BtnClearRtxb_Click(object sender, EventArgs e)
        {
            RTxbText.Clear();
        }

        private void BtnReadText_Click(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(_path, Encoding.UTF8))
            {
                string readText = streamReader.ReadToEnd();

                MessageBox.Show(readText);
            }
        }
        private bool IsFileValidation()
        {
            bool fileIsValidate = true;

            if (_isSelectedPath == false)
            {
                MessageBox.Show("Wprowadz sciezkę pliku!");
                fileIsValidate = false;
            }
            else if (String.IsNullOrEmpty(TxbFileName.Text))
            {
                MessageBox.Show("Wprowadz nazwę pliku!");
                fileIsValidate = false;
            }

            return fileIsValidate;
        }
    }
}