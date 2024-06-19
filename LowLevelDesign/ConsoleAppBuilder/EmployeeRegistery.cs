using System.Collections.Generic;

namespace ConsoleAppBuilder
{
    public class EmployeeRegistery
    {
        public Dictionary<string, Employee> keyVal;

        void register(string key, Employee val)
        {
            keyVal.Add(key, val);
        }
        Employee getValue(string key)
        {
            return keyVal[key];
        }
    }
}
