using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{


    public class StudentSystem
    {
        private Dictionary<string, Student> repo;
        public Dictionary<string, Student> Repo { get; private set; }

        public StudentSystem() {

            this.Repo = new Dictionary<string, Student>();
        }


        //Student student = new Student("Quyet",20,10);
        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();
            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var garade = double.Parse(args[3]);
                if (!Repo.ContainsKey(name))
                {
                    var student = new Student(name, age, garade);

                    Repo[name] = student;
                }
                else
                {
                    Console.WriteLine("Tk da ton tai");
                }
            }
            else
                if (args[0] == "Show")
            {
                var name = args[1];
                if (Repo.ContainsKey(name))
                {
                    var student = Repo[name];
                    string view = $"{student.Name} is {student.Age}" + $" years old and garade is {student.Garade}";
                    Console.WriteLine(view);
                }
                else
                {
                    Console.WriteLine("Ko co tk co name vay.");
                }

            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }
        public class Student
        {
            private string name;
            private int age;
            private double garade;

            public string Name { get; set; }
            public double Garade
            {
                get { return garade; }
                set { garade = value; }
            }

            public int Age { get; set; }

            public Student()
            {

            }
            public Student(string name, int age, double garade)
            {
                this.Name = name;
                this.Age = age;
                this.Garade = garade;
            }

            public Student(string name)
            {
                this.name = name;
            }
        }
    } }

