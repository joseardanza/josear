using System.Collections.Generic;

namespace tp5.models
{
    public class Subject
    {
        public string Name { get; }
        public byte Year { get; }
        public byte Quarter { get; }
        public List<Grade> Grades { get; }

        public Subject(string name, byte year, byte quarter, List<Grade> grades)
        {
            Name = name;
            Year = year;
            Quarter = quarter;
            Grades = grades;
        }
    }
}
