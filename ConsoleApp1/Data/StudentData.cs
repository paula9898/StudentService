using Linq.Models;

namespace Linq.Data
{
    public class StudentData
    {
        List<Student> _students = new List<Student>();
        public List<Student> GetAllStudents()
        {
            ////1 sposób
            //Student student1 = new Student()
            //{
            //    Id = GetStudentId(),
            //    FirstName = "Paulina",
            //    Surname = "Otrebska",
            //    Sex = "kobieta",
            //    Birthdate = new DateTime(1991, 3, 29),
            //    IndexNumber = 132110
            //};

            //_students.Add(student1);

            ////2 sposób
            //_students.Add(new Student { Id = GetStudentId(), FirstName = "Paulina", Surname = "Otrebska", Sex = "kobieta", Birthdate = new DateTime(1991, 3, 29), IndexNumber = 132110 });


            //3 sposób

            _students = new List<Student>
            {
                new Student { Id = 1, FirstName = "Paulina", Surname = "Otrebska", Sex = "kobieta", Birthdate = new DateTime(1991, 3, 29),DateAdd = new DateTime(2015,1,10), IndexNumber = 132110 },
                new Student { Id = 2, FirstName = "Robert", Surname = "Polis", Sex = "mezczyzna", Birthdate = new DateTime(1998, 2, 17),DateAdd = new DateTime(2017,1,10), IndexNumber = 222110 },
                new Student { Id = 3, FirstName = "Agata", Surname = "Otreba", Sex = "kobieta", Birthdate = new DateTime(2000, 1, 1), DateAdd = new DateTime(2019,1,10), IndexNumber = 232110 },
                new Student { Id = 4, FirstName = "Ewa", Surname = "Pietruszka", Sex = "kobieta", Birthdate = new DateTime(1998, 6, 1),DateAdd = new DateTime(2017,1,10), IndexNumber = 172110 },
                new Student { Id = 5, FirstName = "Mateusz", Surname = "Krol", Sex = "mezczyzna", Birthdate = new DateTime(1990, 4, 2),DateAdd = new DateTime(2009,1,10), IndexNumber = 262110 },
                new Student { Id = 6, FirstName = "Piotrek", Surname = "Korzonek", Sex = "mezczyzna", Birthdate = new DateTime(1997, 2, 23),DateAdd = new DateTime(2017,1,10), IndexNumber = 162110 },
                new Student { Id = 7, FirstName = "Kacper", Surname = "Lis", Sex = "mezczyzna", Birthdate = new DateTime(1998, 12, 29),DateAdd = new DateTime(2017,1,10), IndexNumber = 144110 }
            };
            return _students;

        }
        private int GetStudentId()
        {
            int newId = 1;
            //List<int> allIds = _students.Select(x => x.Id).ToList();
            if (_students.Any())
            {
                int maxId = _students.Select(x => x.Id).Max();

                newId = maxId + 1;
            }
            return newId;
        }
    }
}