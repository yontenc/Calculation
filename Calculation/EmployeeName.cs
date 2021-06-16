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

        public int GetOrderByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is Empty");
            }
            return 100;
        } 
    }

    public class LoyalEmployee : EmployeeName
    {
        public int Discount { set; get; }

        public LoyalEmployee()
        {
            Discount = 10;
        }
    }

    public static class EmployeeFactory
    {
        public static EmployeeName CreateEmployeeInstance(int numberOfOrder)
        {
            if (numberOfOrder <= 100)
            {
                return new EmployeeName();
            }
            else
            {
                return new LoyalEmployee();
            }
        }
    }

}
