using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Student : Person
    {
        private float avgScore;
        private string faculty;

        public Student() {}

        public Student(string id, string fullname, float  avgScore, string faculty)
            : base(id, fullname)
        {
            this.AvgScore = avgScore;
            this.Faculty = faculty;
        }
        public float AvgScore { get => avgScore; set => avgScore = value;}
        public string Faculty { get => faculty; set => faculty = value;}

        public override void Input()
        {
            base.Input();
            Console.WriteLine($"Khoa: {this.Faculty}");
            Faculty = Console.ReadLine();
            Console.WriteLine($"ĐTB: {this.AvgScore}");
            AvgScore = float.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("ĐTB: {0} - Khoa: {1}", this.AvgScore, this.Faculty);
        }

    }
}
