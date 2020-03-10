    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    namespace Cw2
    {

        public class Program
        {
            public static void Main(string[] args)
            {
                In();

                //Wczytywanie 
                //var fi = new FileInfo(path);
                //using (var stream = new StreamReader(fi.OpenRead()))
                //{
                //    string line = null;
                //    while ((line = stream.ReadLine()) != null)
                //    {
                //        string[] kolumny = line.Split(',');
                //        Console.WriteLine(line);
                //    }
                //}
                ////stream.Dispose();

                ////XML
                //var list = new List<Student>();
                //var st = new Student
                //{
                //    Imie = "Jan",
                //    Nazwisko = "Kowalski",
                //    Email = "kowalski@wp.pl"
                //};
                //list.Add(st);

                //FileStream writer = new FileStream(@"data.xml", FileMode.Create);
                //XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                //                           new XmlRootAttribute("uczelnia"));
                //serializer.Serialize(writer, list);
                //serializer.Serialize(writer, list);

            }

            public static void In() {
                try
                {
                    string path = @"C:\Users\xinox\Desktop\sql\APBD\GitHub\Cw2\Cw2\Data\dane.csv";
                    var lines = File.ReadLines(path);
                    HashSet<Student> students = new HashSet<Student>(new OwnComparer());
                    foreach (string s in lines)
                    {
                    students.Add(new Student(s.Split(",")));
                    }
                    Console.WriteLine(students.Count);
            } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            
            }

            public static void writeLog(string msg)
            {
                Console.WriteLine("log");
            }

        }
    }
//var today = DateTime.Today
//today.ToShortDateString()
//StringComparer.InvariantCultureIgnoreCase.GetGashCode($"{student.Firstname} {student.lastname} ...