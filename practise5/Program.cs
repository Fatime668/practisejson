using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace practise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Fatima", "Hasanzade", 21);
            Employee emp1 = new Employee("Fatima", "Hasanzade", 22);
            Employee emp2 = new Employee("Fatima", "Hasanzade", 23);
            Employee emp3 = new Employee("Fatima", "Hasanzade", 24);

            List<Employee> employees = new List<Employee>();
            employees.Add(emp);
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            string json = JsonConvert.SerializeObject(employees);
            Console.WriteLine(json);
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\tu7dkjdue\source\repos\practise5\practise5\jsonfile.json"))
            {
                streamWriter.Write(json);
            }
            string result;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\tu7dkjdue\source\repos\practise5\practise5\jsonfile.json"))
            {
                result = streamReader.ReadLine();
            }

            var des = JsonConvert.DeserializeObject(result);
            Console.WriteLine(des);







        }
    }
}
