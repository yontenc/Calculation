using System;

namespace Calculation
{
    public class EmployeeName
    {
        public string Name = "Aref";
        public int Age = 35;
        public string GetNickName { set; get; } 
        public string GetName(String name)
        {
            return name;
        }

        public string GetFullName(String firstName,String secondName)
        {
            return $"{firstName} {secondName}";
        }
    }
}
