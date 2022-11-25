namespace CollectionsExercise.ExerciseStudent.Models
{
    public class StudentsAcademy : DefaultModel
    {
        public int StudentId { get; set; }

        public int? AcademyId  { get; set; }
        

        public DateTime DateAdd { get; set; }
    }
}