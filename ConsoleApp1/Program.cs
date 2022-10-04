using CollectionsExercise.ExerciseStudent.Data;

var studentData = new StudentData();
var students = studentData.GetAllStudents();


var names = students.Select(x => x.FirstName).ToList();


Console.ReadKey();