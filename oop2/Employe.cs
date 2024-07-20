using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Employe
    {
        //  field
        private string name;
        private double salary;

        // constuctor
        public Employe(string name, double salary)
        // properities to acess field and  modify provate field
        {
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                {
                    Console.WriteLine("salary cannot be negtative");
                }
            }
        }
    
            public void DisplayEmployeInfo()
                {
                    Console.WriteLine($"Name:{Name}");
                    Console.WriteLine($"salary:{Salary}");
                }
            }
        } 


    

