using CollectionsExercise.ExerciseStudent.Models;

namespace CollectionsExercise.ExerciseStudent
{
    public partial class EditStudentFrm : Form
    {
        //public, private itd = modyfikator dostępu
        public Student _student; //pole

        //po stworzeniu instancji tej formy podczas odpalenia jako pierwsze wywołuje się konstruktor,
        //a jako drugie metoda load
        public EditStudentFrm(Student student)
        {
            InitializeComponent();
            _student = student;
        }
        private void EditStudentFrm_Load(object sender, EventArgs e)
        {

            SexLoad();
            if (_student.Id > 0) {

                TxbName.Text = _student.FirstName;
                TxbSurname.Text = _student.Surname;
                DtpBirthday.Value = _student.Birthdate;
                DtpDateAdd.Value = _student.DateAdd;
                TxbStudentIndexNumber.Text = _student.IndexNumber.ToString();

            };
            
        }

        public void  GetStudent()
        {

            _student = new Student();

            _student.FirstName = TxbName.Text;
            _student.Surname = TxbSurname.Text;
            _student.Sex = CbSex.SelectedValue.ToString();
            _student.Birthdate = DtpBirthday.Value;
            _student.DateAdd = DtpDateAdd.Value;

            var SixDigits = new FrmStudent();

            bool isSixDigits = SixDigits.IsSixDigits(TxbStudentIndexNumber.Text);

            if (isSixDigits)
            {
                _student.IndexNumber = Convert.ToInt32(TxbStudentIndexNumber.Text);
            }

            //var addedStudent = _student;

            //return addedStudent;


        }
        private void SexLoad()
        {
            /*var sexs = new List<string>()
            {
                _student.Sex
            };
            CbSex.DataSource = sexs;*/

            var sexs = new List<string>()
            {
                "kobieta",
                "mezczyzna"
            };

            
            CbSex.DataSource = sexs;
        }

        private void AcademyLoad()
        {

        }

        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(_student is not null)
                {
                    _student = new Student()
                    {
                        Id = _student.Id,
                        FirstName = TxbName.Text,
                        Surname = TxbSurname.Text,
                        Sex = CbSex.SelectedValue.ToString(),
                        Birthdate = DtpBirthday.Value,
                        DateAdd = DtpDateAdd.Value,
                        IndexNumber = Convert.ToInt32(TxbStudentIndexNumber.Text)
                    };
                }
                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(" You've entered a wrong data!!!!");
#if DEBUG
                MessageBox.Show(exception.ToString());
#endif

                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}