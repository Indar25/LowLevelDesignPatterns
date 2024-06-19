namespace ConsoleAppBuilder
{
    public class ContractEmployee : Employee
    {
        int contractYear;
        public void setContractYear(int year)
        {
            this.contractYear = year;
        }
        public int getContractYear()
        {
            return this.contractYear;
        }
        public override Employee Clone()
        {
            ContractEmployee contractEmployee = new ContractEmployee();
            contractEmployee.id = this.id;
            contractEmployee.name = this.name;
            contractEmployee.organization = this.organization;
            contractEmployee.workLocation = this.workLocation;
            contractEmployee.contractYear = this.contractYear;
            return contractEmployee;
        }
    }
}
