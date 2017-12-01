using System;
using System.Collections.Generic;
using System.Linq;

namespace tp5.models
{
    public enum GradeType
    {
        Exam,
        Final,
        Paper
    }
    
    public class Grade
    {
        public GradeType Type { get; }
        public DateTime Date { get; }
        public float Value { get; }

        public Grade(GradeType type, DateTime date, float value)
        {
            Type = type;
            Date = date;
            Value = value;
        }
    }

    public static class GradeExtensions
    {
        public static float Average(this IEnumerable<Grade> grades)
        {
            return grades.Sum(grade => grade.Value) / grades.Count();
        }
    }
}
