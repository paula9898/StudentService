using CollectionsExercise.ExerciseStudent;
using CollectionsExercise.ExerciseStudent.Models;
using CollectionsExercise.ExerciseStudent.Services;
using System.Data;

namespace CollectionsExercise
{
    public partial class FrmStudent : Form
    {
        private List<Student> _students = new List<Student>();
        private List<Academy> _academis = new List<Academy>();
        private List<StudentsAcademy> _studentsAcademies = new List<StudentsAcademy>();
        private List<string> _sexs;
        bool _isWomanSelected = true;
        bool _isManSelected = true;
        bool _isFormLoading = false;
       
        
        DateTime _ageFrom;
        DateTime _ageTo;
        

        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            _isFormLoading = true;
            SexLoad();
            
            AcademyLoad();

            CbAgeFrom.DataSource = AgeLoad();
            CbAgeTo.DataSource = AgeLoad();
            CbAgeTo.SelectedIndex = 100;

            MarkCheckBoxs();

            LoadStudentsToGrid();
            _isFormLoading = false;
        }

        private void SexLoad()
        {
            _sexs = new List<string>()
            {
                "kobieta",
                "mezczyzna"
            };

            foreach (var sex in _sexs)
            {
                ClbSex.Items.Add(sex);

            }

            
            ClbSex.DataSource = _sexs;
        }

        private void AcademyLoad()
        {
            

            var studentService = new StudentService();
            _academis = studentService.GetAcademy();


            CmbAcademy.DataSource = _academis;
            CmbAcademy.DisplayMember = "NAME";
            CmbAcademy.ValueMember = "ID";


            //_academisName = new List<string>();

            //_academisName.Add(" ");


            //foreach (var academy in _academis)
            //{


            //    _academisName.Add(academy.Name);
            //}

            //foreach (var name in _academisName)
            //{
            //    CmbAcademy.Items.Add(name);
            //}


            //CmbAcademy.DataSource = _academisName;


        }

        private void MarkCheckBoxs()
        {
            for (int i = 0; i < ClbSex.Items.Count; i++)
            {
                ClbSex.SetItemChecked(i, true);
            }
        }
        private List<int> AgeLoad()
        {
            DateTime? data; //domyslna wartosc to jest null
            DateTime data1; //domyslna wartosc to data chrystusowa
            int toJestInt; // dosmylna wartosc to zero
            string toJestStrinbg;// domyslna wartosc to null
            

            var ages = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                ages.Add(i);
            }
            ages = ages.OrderBy(x => x).ToList();

            return ages;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student();

            using (var studentEditForm = new EditStudentFrm(student))
            {
                var result = studentEditForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var addedStudent = studentEditForm._student;

                    var studentService = new StudentService();
                    studentService.AddorUpdateStudent(addedStudent);

                    LoadStudentsToGrid();
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {

            int idStudentEdit = Convert.ToInt32(DgvStudent.SelectedRows[0].Cells[0].Value);


            var studentToEdit = _students.Where(x => x.Id == idStudentEdit).FirstOrDefault();

            using (var studentEditForm = new EditStudentFrm(studentToEdit))
            {
                var result = studentEditForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var editedStudent = studentEditForm._student;

                    int indexStudentToEdit = _students.FindIndex(x => x.Id == editedStudent.Id);
                    _students[indexStudentToEdit] = editedStudent;

                    var studentService = new StudentService();
                    studentService.AddorUpdateStudent(editedStudent);

                    LoadStudentsToGrid();
                }
            }
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            //TxbFirstName.Text = String.Empty;
            //TxbSurname.Text = String.Empty;
            //TxbIndexNumber.Text = String.Empty;
            SexLoad();
            AgeLoad();
            //DtpBirthdate.Value = DateTime.Now;
            //DtpAdddate.Value = DateTime.Now;

        }
        private int GetStudentId()
        {

            int newid = 1;
            List<int> allids = _students.Select(x => x.Id).ToList();
            if (_students.Any())
            {
                int maxid = _students.Select(x => x.Id).Max();

                newid = maxid + 1;
            }

            return newid;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var warningMessage = MessageBox.Show("Czy jesteś pewny że chcesz usunąć studenta", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (warningMessage == DialogResult.Yes)
            {
                int idStudentToDelete = Convert.ToInt32(DgvStudent.SelectedRows[0].Cells[0].Value);

                var studentService = new StudentService();
                studentService.DeleteStudent(idStudentToDelete);
            }

            LoadStudentsToGrid();
        }
        public bool IsSixDigits(string index)
        {
            int indexLength = index.Length;
            bool result = false;

            if (indexLength == 6)
            {
                result = true;
            }
            else
            {
                MessageBox.Show($"You have to enter a six digits number!!");
            }
            return result;
        }

        private void ClbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilteredSex(sender);
        }

        private void LoadStudentsToGrid()
        {
            var studentService = new StudentService();
            _students = studentService.GetStudents();

            DgvStudent.DataSource = null;

            DgvStudent.DataSource = _students;
        }

        private void CbAgeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBirthdayFiltr();
        }

        private void CbAgeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBirthdayFiltr();
        }

        private void SetBirthdayFiltr()
        {

            int chosenAgeFrom = (int)CbAgeFrom.SelectedValue;
            int chosenAgeTo;


            if (CbAgeTo.SelectedValue != null)
            {
                chosenAgeTo = (int)CbAgeTo.SelectedValue;
                _ageFrom = DateTime.Now.Date.AddYears(-1 * chosenAgeFrom);
                _ageTo = DateTime.Now.Date.AddYears(-1 * chosenAgeTo);

                if (_ageFrom < _ageTo && _ageTo != DateTime.Now.Date && !_isFormLoading)
                {
                    MessageBox.Show("The value from Age From can not be bigger than the value from Age To");

                    return;
                }
                LoadStudentsToGrid();

                _students = _students.Where(x => x.Birthdate.Year <= _ageFrom.Year && x.Birthdate.Year >= _ageTo.Year).ToList();
                DgvStudent.DataSource = _students;
            }
        }

        private void CmbAcademy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilteredAcademy();
            SetFilteredSex(sender);
            SetBirthdayFiltr();

        }

        private void SetFilteredSex(object sender)
        {
            LoadStudentsToGrid();

            var checkedListBox = (CheckedListBox)sender;
            string selectedItem = checkedListBox.SelectedItem.ToString();
            if (_isManSelected && selectedItem.ToUpper() == "MEZCZYZNA")
            {
                _isManSelected = false;

            }
            else if (!_isManSelected && selectedItem.ToUpper() == "MEZCZYZNA")
            {
                _isManSelected = true;
            }
            else if (_isWomanSelected && selectedItem.ToUpper() == "KOBIETA")
            {
                _isWomanSelected = false;
            }
            else
            {
                _isWomanSelected = true;
            }

            if (_isWomanSelected && _isManSelected)
            {
                _students = _students.Where(x => x.Sex == "kobieta" || x.Sex == "mezczyzna").ToList();
            }
            else if (!_isWomanSelected && _isManSelected)
            {
                _students = _students.Where(x => x.Sex == "mezczyzna").ToList();
            }
            else if (_isWomanSelected && !_isManSelected)
            {
                _students = _students.Where(x => x.Sex == "kobieta").ToList();
            }
            else
            {
                _students = new List<Student>();
            }

            DgvStudent.DataSource = _students;

        }

        private void SetFilteredAcademy()
        {
            LoadStudentsToGrid();
            var studentService = new StudentService();
            // _academis = studentService.GetAcademy();
            _studentsAcademies = studentService.GetStudentAcademy();

            var chosenAcademy = (Academy)CmbAcademy.SelectedItem;



            //var academy = _academis.Where(x => x.Id == chosenAcademy.Id).FirstOrDefault();

            var chosenStudents = new List<Student>();

            if (chosenAcademy != null)
            {
                _studentsAcademies = _studentsAcademies.Where(x => x.AcademyId == chosenAcademy.Id).ToList();


                foreach (var student in _studentsAcademies)
                {
                    var editedStudent = new Student();
                    int indexStudentToEdit = _students.FindIndex(x => x.Id == student.StudentId);
                    editedStudent = _students[indexStudentToEdit];
                    chosenStudents.Add(editedStudent);
                }

                DgvStudent.DataSource = chosenStudents;
            }

        }

    
    }
}