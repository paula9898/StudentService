namespace DatabaseExercise.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Job { get; set; }
        public int? Supervisor { get; set; }
        public DateTime DateOfEnmployment { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal? Premimum { get; set; }
    }
}