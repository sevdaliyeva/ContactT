using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactT
{
    internal class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Faculty { get; set; } 
        public string Surname { get; set; } 
        public int Age { get; set; }
        public Student(int id, string name, string faculty,string surname,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Faculty = faculty; 
            this.Id = id;   
            this.Surname = surname; 
        }
        public override string ToString()
        {
            return Id +" "+ Name + " " + Surname + " " + Faculty + " " + Age;
        }

    }
}
