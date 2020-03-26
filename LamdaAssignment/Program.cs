using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaAssignment
{
    class Program
    {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>()
            
            
        {
        new Employee() { Fname = "Joe", Lname = "Smith", Id = 1 },
        new Employee() { Fname = "Joe", Lname = "Johnson", Id = 2 },
        new Employee() { Fname = "Ted", Lname = "Hill", Id = 3 },
        new Employee() { Fname = "John", Lname = "Lennon", Id = 4 },
        new Employee() { Fname = "Tim", Lname = "Tebow", Id = 5 },
        new Employee() { Fname = "Mike", Lname = "Jordan", Id = 6 },
        new Employee() { Fname = "Nancy", Lname = "Owens", Id = 7 },
        new Employee() { Fname = "Tammy", Lname = "Taylor", Id = 8 },
        new Employee() { Fname = "Ricky", Lname = "Rubio", Id = 9 },
        new Employee() { Fname = "Wyatt", Lname = "Earp", Id = 10 }
            };




            foreach (Employee employee in employees)            // For each loop that adds duplicate first name "Joe" to new list
            {
                if (employee.Fname == "Joe")
                {
                    List<string> newList = new List<string>();
                    newList.Add(employee.Fname + " " + employee.Lname + " " + employee.Id);
                    newList.ForEach(Console.WriteLine);
                    Console.WriteLine(); 

                }
            }



            List<Employee> employees1 = employees.Where(x => x.Fname == "Joe").ToList();        // Lamda that does the same as above
            foreach (Employee employee1 in employees1)
            {
                Console.WriteLine(employee1.Fname + " " + employee1.Lname + " " + employee1.Id);
            }



            List<Employee> employees2 = employees.Where(x => x.Id > 5).ToList();        // Lamda that iterates list and adds ID numbers greater than 5 to new list
            foreach (Employee employee2 in employees2)
            {
                Console.WriteLine(employee2.Fname + " " + employee2.Lname + " " + employee2.Id);
            }

            Console.ReadLine();   

            

        }





    }
    }

    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Id { get; set; }

    }

