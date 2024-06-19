namespace ConsoleAppPrototypeAndRegistry
{
    public class Employee : IPrototype<Employee>
    {
        private string Name;
        private string Department;
        private int JoiningYear;
        private int JoiningMonth;
        private string Location;

        public void setName(string name)
        {
            this.Name = name;
        }

        public void setDepartment(string department)
        {
            this.Department = department;
        }

        public void setLocation(string location)
        {
            this.Location = location;
        }
        public void setJoiningMonth(int joiningMonth)
        {
            this.JoiningMonth = joiningMonth;
        }
        public void setJoiningYear(int joiningYear)
        {
            this.JoiningYear = joiningYear;
        }
        public Employee()
        {

        }
        public Employee(Employee emp)
        {

            this.Name = emp.Name;
            this.Department = emp.Department;
            this.JoiningMonth = emp.JoiningMonth;
            this.JoiningYear = emp.JoiningYear;
            this.Location = emp.Location;
        }
        public virtual Employee Clone()
        {
            return new Employee(this);
        }
    }
}
