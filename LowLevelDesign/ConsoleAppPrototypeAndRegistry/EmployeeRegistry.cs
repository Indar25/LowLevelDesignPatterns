using System.Collections.Generic;

namespace ConsoleAppPrototypeAndRegistry
{
    public class EmployeeRegistry
    {
        Dictionary<string, Employee> employeesMap = new Dictionary<string, Employee>();

        public void Register(string key, Employee employee)
        {
            employeesMap.Add(key, employee);
        }
        public Employee Get(string key)
        {
            return employeesMap[key];
        }
    }
}
