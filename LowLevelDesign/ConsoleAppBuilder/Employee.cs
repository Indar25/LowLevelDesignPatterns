namespace ConsoleAppBuilder
{
    public class Employee : IEmployee<Employee>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string workLocation { get; set; }


        public virtual Employee Clone()
        {
            Employee employee = new Employee();
            employee.id = this.id;
            employee.name = this.name;
            employee.organization = this.organization;
            employee.workLocation = this.workLocation;
            return employee;
        }
    }
}
