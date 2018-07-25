using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
        {
            object[,] EmployeeArray = new object[3, 7];
            EmployeeArray [0,0]= 120;
            EmployeeArray [0,1]= "Frank";
            EmployeeArray [0,2]= "Renolds";
            EmployeeArray [0,3]= "08/12/1978";
            EmployeeArray [0,4]= "Sales";
            EmployeeArray [0,5]= 1901;
            EmployeeArray [0,6]= "10/14/2018";

            EmployeeArray [1,0]= 270;
            EmployeeArray [1,1]= "Tom";
            EmployeeArray [1,2]= "Hanks";
            EmployeeArray [1,3]= "10/12/1957";
            EmployeeArray [1,4]= "Marketing";
            EmployeeArray [1,5]= 3902;
            EmployeeArray [1,6]= "12/23/1998";

            EmployeeArray [2,0]= 432;
            EmployeeArray [2,1]= "Ryan";
            EmployeeArray [2,2]= "Bryant";
            EmployeeArray [2,3]= "03/05/1980";
            EmployeeArray [2,4]= "IT";
            EmployeeArray [2,5]= 1044;
            EmployeeArray [2,6]= "05/30/2004";

        
            object[,] CustomerArray = new object[3, 7];
            CustomerArray [0,0]= 932;
            CustomerArray [0,1]= "Sheela";
            CustomerArray [0,2]= "Jones";
            CustomerArray [0,3]= "04/28/1999";
            CustomerArray [0,4]= "12 Main St";
            CustomerArray [0,5]= "Pittsburg";
            CustomerArray [0,6]= "Pennsylvania";

            CustomerArray [1,0]= 393;
            CustomerArray [1,1]= "Mary";
            CustomerArray [1,2]= "Johnson";
            CustomerArray [1,3]= "02/16/1969";
            CustomerArray [1,4]= "3003 Kennedy Road";
            CustomerArray [1,5]= "New York City";
            CustomerArray [1,6]= "New York";

            CustomerArray [2,0]= 791;
            CustomerArray [2,1]= "Joe";
            CustomerArray [2,2]= "Swanson";
            CustomerArray [2,3]= "09/25/1983";
            CustomerArray [2,4]= "930 Lake Drive";
            CustomerArray [2,5]= "Seattle";
            CustomerArray [2,6]= "Washington";

            
            Console.WriteLine($"Employees: {EmployeeArray[0,0]}-{EmployeeArray[0,1]}-{EmployeeArray[0,2]}-{EmployeeArray[0,3]}-{EmployeeArray[0,4]}-{EmployeeArray[0,5]}-{EmployeeArray[0,6]}, {EmployeeArray[1,0]}-{EmployeeArray[1,1]}-{EmployeeArray[1,2]}-{EmployeeArray[1,3]}-{EmployeeArray[1,4]}-{EmployeeArray[1,5]}-{EmployeeArray[1,6]}, {EmployeeArray[2,0]}-{EmployeeArray[2,1]}-{EmployeeArray[2,2]}-{EmployeeArray[2,3]}-{EmployeeArray[2,4]}-{EmployeeArray[2,5]}-{EmployeeArray[2,6]}");
            Console.WriteLine($"Customers: {CustomerArray[0,0]}-{CustomerArray[0,1]}-{CustomerArray[0,2]}-{CustomerArray[0,3]}-{CustomerArray[0,4]}-{CustomerArray[0,5]}-{CustomerArray[0,6]}, {CustomerArray[1,0]}-{CustomerArray[1,1]}-{CustomerArray[1,2]}-{CustomerArray[1,3]}-{CustomerArray[1,4]}-{CustomerArray[1,5]}-{CustomerArray[1,6]}, {CustomerArray[2,0]}-{CustomerArray[2,1]}-{CustomerArray[2,2]}-{CustomerArray[2,3]}-{CustomerArray[2,4]}-{CustomerArray[2,5]}-{CustomerArray[2,6]}");
            
        }
        }
        }}