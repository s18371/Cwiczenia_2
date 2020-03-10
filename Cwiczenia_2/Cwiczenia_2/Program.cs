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

            string path = null;
            string outPath = null;
            string format = null;

            /*string path = @"Dane\dane.csv";;
            string outPath = @"result.xml";
            string format = "xml";*/
            string pathLogi = @Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "logi.txt");
            StreamWriter logi = File.CreateText(pathLogi);
            //File logi = new File(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "/logi.txt"), FileMode.Create);
            //File logFile = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logi.txt"));
            string log = "";
            try
            {
                if (args[0] != null)
                {
                    path = args[0];
                }
                else
                {
                    //path = @"Dane\dane.csv";
                }
                if (args[1] != null)
                {
                    outPath = args[1];
                }
                else
                {
                    //outPath = @"result.xml";
                }
                if (args[2] != null) { 
                    format = args[2];
                }
                else
                {
                    //format = "xml";
                }
                
                //path = @"Dane\dane.csv";
                //string[] plik = path.Split('/');
                
            }
            catch(ArgumentException e)
            {
                File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "podana sciezka nie jest poprawna" + Environment.NewLine);
            }
            catch(FileNotFoundException e)
            {
                File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "plik nie istnieje" + Environment.NewLine);
            }
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
                    //Console.WriteLine(line);
                    liczba++;
                    string[] student = line.Split(',');
                    if (student.Length == 9) {
                        var stu = new Student
                        {
                            Imie = student[0],
                            Nazwisko = student[1],
                            Kireunek = student[2],
                            TrybSt = student[3],
                            Eska = int.Parse(student[4]),
                            DataUr = student[5],
                            Email = student[6],
                            ImieM = student[7],
                            ImieO = student[8]
                        };
                        bool istnieje = false;
                        foreach (Student st in list)
                        {
                            if (st.Eska.Equals(stu.Eska))
                            {
                                istnieje = true;
                                //logFile.WriteLine("pominieto");
                                File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "pominieto "+st.Eska + Environment.NewLine);
                            }
                            
                        }
                        if (istnieje == false)
                        {
                            list.Add(stu);
                            //logi.WriteLine("Pominieto");
                        }
                    }
                    else
                    {
                        
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
            if (format.Equals("xml"))
            {
                FileStream writer = new FileStream(outPath, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("uczelnia"));
                serializer.Serialize(writer, list);
            }
            if (format.Equals("json"))
            {
                var jsonString = JsonSerializer.Serialize(list);
                File.WriteAllText("data.json", jsonString);
            }
            
        }
    }
}
