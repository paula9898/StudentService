using CollectionsExercise.ExerciseStudent.Models;
using CollectionsExercise.ExerciseStudent.Repositories;

namespace CollectionsExercise.ExerciseStudent.Services
{
    public partial class StudentService
    {
        public Academy _academy;

        public List<Student> GetStudents()
        {

            var studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();

            return students;
        }

        public List<Academy> GetAcademy()
        {
            _academy = new Academy();
            _academy.Id = 0;
            _academy.Name = "---all---";



            var studentRepository = new StudentRepository();
            var academy = studentRepository.GetAllAcademis();
            academy.Insert(0, _academy);
            return academy;

        }

        public List<StudentsAcademy> GetStudentAcademy()
        {
            var studentRepository = new StudentRepository();
            var studentacademy = studentRepository.GetStudentsAcademy();

            return studentacademy;

        }

        public void AddorUpdateStudent(Student student)
        {

            var studentRepository = new StudentRepository();
            studentRepository.Add(student);
        }

        public void DeleteStudent(int id)
        {
            var studentRepository = new StudentRepository();

            studentRepository.Delete(id);

        }

        public Student CreateStudent(string firstname, string surname, string sex, int indexNumber, DateTime birthdate, DateTime adddate)
        {
            var student = new Student();

            student.FirstName = firstname;
            student.Surname = surname;
            student.IndexNumber = indexNumber;
            student.Sex = sex;
            student.Birthdate = birthdate;
            student.DateAdd = Convert.ToDateTime(adddate);
            var createdStudent = student;

            return createdStudent;
        }

        //Student
    }
}