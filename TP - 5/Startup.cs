using System;
using System.Collections.Generic;
using System.Linq;
using tp5.models;
using utils;

namespace tp5
{
    internal class Startup
    {
        public static void Main()
        {
            Utilities.Start(typeof(Startup));
        }

        public static List<Subject> GetSubjects()
        {
                                                         //Listado de materias
            
            var devolucion = new List<Subject>()
            {
                new Subject("Calidad de Software", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 8),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 9),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 6),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 10)
                }),
                new Subject(".net", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 6),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 5),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 9),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 9)
                }),
                new Subject("Integracion de Sistemas", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 6),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 8),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 6),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 4)
                }),
                new Subject("Administracion de proyectos", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 7),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 4),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 9),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 10)
                }),
                new Subject("Diseno de sistemas", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 10),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 7),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 5),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 4)
                }),
                new Subject("Integracion de tecnologia", 3, 1, new List<Grade>()
                {
                    new Grade(GradeType.Exam, new DateTime(2017, 5, 1), 5),
                    new Grade(GradeType.Exam, new DateTime(2017, 6, 1), 6),
                    new Grade(GradeType.Paper, new DateTime(2017, 6, 20), 8),
                    new Grade(GradeType.Final, new DateTime(2017, 8, 1), 9)
                }),
            };
                               // Retorno de Valor 
            return devolucion;
        }
        
        public static void primeraEntrada()
        {
            var devolucion = GetSubjects();

            foreach (var devolucion2 in devolucion.Where(q => q.Quarter == 1))
            {
                Console.WriteLine(devolucion2.Name);
            }
        }
        
        public static void segundaEntrada()
        {
            var devolucion = GetSubjects();

            foreach (var devolucion2 in devolucion.OrderBy(q => q.Name))
            {
                Console.WriteLine(devolucion2.Name);
            }
        }
        
        public static void terceraEntrada()
        {
            var devolucion = GetSubjects();

            foreach (var devolucion2 in devolucion)
            {
                foreach (var grade in devolucion2.Grades.Where(q => q.Type == GradeType.Paper))
                {
                    Console.WriteLine($"Asignatura: {devolucion2.Name} - Nota de trabajo practico: {grade.Value}");
                }
            }
        }
        
        public static void cuataEntrada()
        {
            var devolucion = GetSubjects();

            foreach (var devolucion2 in devolucion)
            {
                Console.WriteLine($"Asignatura: {devolucion2.Name} - Promedio de notas: {devolucion2.Grades.Average()}");
            }
        }
    }
}
