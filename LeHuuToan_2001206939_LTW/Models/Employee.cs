namespace LeHuuToan_2001206939_LTW.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Id = 100;
            Name = "Le Huu Toan";
            Address = "VietNam";
            Salary = 2002;
        }
    }
}
