using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Cwiczenia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Dane\dane.csv";
            Console.WriteLine("Hello World");

            //wczytywanie
            var fi = new FileInfo(path);
            var list = new List<Student>();
            using (var stream = new StreamReader(fi.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] student = line.Split(',');
                    var stu = new Student
                    {
                        Imie = student[0],
                        Nazwisko = student[1],
                        Kireunek = student[2],
                        Eska = student[3],
                        DataUr=student[4],
                        Email = student[5],
                        ImieM=student[6],
                        ImieO=student[7]
                    };
                    ///foreach Student
                    ///if
                    ///list.Add(stu);

                }
            }
            //stream.Dispose();

            //xml
            
            /*var st = new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "kowalski@wp.pl",
            };*/
            //list.Add(st);
            /*FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("uczelnia"));
            serializer.Serialize(writer, list);

            var jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText("data.json", jsonString);
            */
        }
    }
}
