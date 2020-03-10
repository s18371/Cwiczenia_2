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
            int liczba = 0;
            //wczytywanie
            var fi = new FileInfo(path);
            var list = new List<Student>();
            using (var stream = new StreamReader(fi.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    liczba++;
                    string[] student = line.Split(',');
                    var stu = new Student
                    {
                        Imie = student[0],
                        Nazwisko = student[1],
                        Kireunek = student[2],
                        TrybSt = student[3],
                        Eska = int.Parse(student[4]),
                        DataUr=student[5],
                        Email = student[6],
                        ImieM=student[7],
                        ImieO=student[8]
                    };
                    bool istnieje = false;
                    foreach(Student st in list)
                    {
                        if (st.Eska.Equals(stu.Eska))
                        {
                            istnieje = true;
                        }
                    }
                    if (istnieje == false|| student.Length==9)
                    {
                        list.Add(stu);
                    }
                    ///foreach Student
                    ///if
                    ///list.Add(stu);

                }
                Console.WriteLine("koniec tworzenia");
               
                
                Console.WriteLine(list.Count);
                Console.WriteLine(liczba);


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
            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("uczelnia"));
            serializer.Serialize(writer, list);
            /*
            var jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText("data.json", jsonString);*/
            
        }
    }
}
