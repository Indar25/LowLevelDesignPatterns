using System;

namespace ConsoleAppPrototypeAndRegistry
{
    internal class Program
    {
        private static void fillRegistry(EmployeeRegistry registry)
        {
            Employee june2024 = new Employee();
            june2024.setJoiningMonth(6);
            june2024.setJoiningYear(2024);
            june2024.setLocation("Noida");

            registry.Register(Constants.june2024, june2024);

            Trainee june2024Trainee = new Trainee();
            june2024Trainee.setJoiningMonth(6);
            june2024Trainee.setJoiningYear(2024);
            june2024Trainee.setLocation("Noida");
            june2024Trainee.setCollege("IIT Delhi");

            registry.Register(Constants.june2024Trainee, june2024Trainee);
        }
        static void Main(string[] args)
        {
            EmployeeRegistry registry = new EmployeeRegistry();
            fillRegistry(registry);

            //let suppose tony belong to june2024 batch
            Employee tony = registry.Get(Constants.june2024).Clone();
            tony.setName("Tony");
            tony.setDepartment("Server TeamA");

            Employee peter = registry.Get(Constants.june2024).Clone();
            peter.setName("Peter");
            peter.setDepartment("Server TeamB");

            Trainee sara = (Trainee)registry.Get(Constants.june2024Trainee).Clone();    
            sara.setName("Sara");
            sara.setDepartment("QA");
        }
    }
}
