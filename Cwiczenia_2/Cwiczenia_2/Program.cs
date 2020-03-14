using Cwiczenia_2.Models;
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
            File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "Uruchoomienie....."+  Environment.NewLine);
            //File logi = new File(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "/logi.txt"), FileMode.Create);
            //File logFile = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logi.txt"));
            string log = "";
            try
            {

                if (args[0] != null)
                {
                    try
                    {
                        path = args[0];
                        Console.WriteLine("ustalono plik wejsciowy z args");
                    }
                    catch
                    {
                        File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "podana sciezka nie jest poprawna" + Environment.NewLine);
                        path = @"Dane\dane.csv";
                        
                    }
                }
                else
                {
                    path = @"Dane\dane.csv";
                }
                if (args[1] != null)
                {
                    try
                    {
                        outPath = args[1];
                        Console.WriteLine("ustalono sciezke pliku docelowego z args");
                    }
                    catch
                    {
                        File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "podana sciezka nie jest poprawna" + Environment.NewLine);
                        outPath = @"result.xml";

                    }
                    
                }
                else
                {
                    outPath = @"result.xml";
                }
                
                if (args[2] != null)
                {
                    try
                    {
                        format = args[2];
                        Console.WriteLine("format to "+args[2]);
                    }
                    catch
                    {
                        File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "podana sciezka nie jest poprawna" + Environment.NewLine);
                        format = "xml";
                    }
                }
                else
                {
                    format = "xml";
                }
                
                //path = @"Dane\dane.csv";
                //string[] plik = path.Split('/');
                
           
                Console.WriteLine("Rozpoczynam działanie...");
                int liczba = 0;
            
                var fi = new FileInfo(path);
                var list = new List<Student>();
                Console.WriteLine("Utworzono listą na studentow");
                var kierunkis = new List<string>();
                var liczbynakierunkach = new List<int>();
                var listaKier = new List<activeStudies>();
                Console.WriteLine("Utworzono listą na kierunki");
                using (var stream = new StreamReader(fi.OpenRead()))
                {
                    string line = null;

                    //string line = null;
                    Console.WriteLine("wczytuje dane studentow i tworze obiekty");
                    while ((line = stream.ReadLine()) != null)
                        {
                    //Console.WriteLine(line);
                            liczba++;

                            string[] student = line.Split(',');
                            if (student.Length == 9) {
                                bool istnieje = false;
                                for (int i = 0; i < 9; i++)
                                {
                                if (student[i].Equals("") || student[i].Equals(" "))
                                {
                                    istnieje = true;
                                    File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "za malo danych dla studenta" + Environment.NewLine);
                                }
                                }
                                var stu = new Student
                            
                                {
                                    
                                    Imie = student[0],
                                    Nazwisko = student[1],
                                    Studia = new Studies
                                    {
                                        Kierunek = student[2],
                                        TrybSt = student[3]
                                    },
                                    Eska = int.Parse(student[4]),
                                    DataUr = student[5],
                                    Email = student[6],
                                    ImieM = student[7],
                                    ImieO = student[8]
                                };
                                //bool istnieje = false;
                                foreach (Student st in list)
                                {
                                    if ((stu.equals(st)))
                                    {
                                        
                                        //list.Add(stu);
                                        istnieje = true;
                                        //logFile.WriteLine("pominieto");
                                        //File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "pominieto "+st.Eska + Environment.NewLine);
                                    }
                                    else{
                                        File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "duplikat "+st.Eska + Environment.NewLine);
                                    }
                                    
                            
                                }
                                if (istnieje == false)
                                {
                                    list.Add(stu);
                                    if (!(kierunkis.Contains(stu.Studia.Kierunek)))
                                    {
                                        
                                        kierunkis.Add(stu.Studia.Kierunek);
                                        liczbynakierunkach.Add(0);
                                        activeStudies KierunekJakis = new activeStudies { };
                                        KierunekJakis.name = stu.Studia.Kierunek;
                                        KierunekJakis.numberOfStud = "1";
                                        listaKier.Add(KierunekJakis);
                                    }
                                    else {
                                    int index = kierunkis.FindIndex(x => x == stu.Studia.Kierunek);
                                    listaKier[index].numberOfStud = (1+ int.Parse(listaKier[index].numberOfStud)).ToString();

                                    }
                                    /*int index = kierunkis.FindIndex(x => x == stu.Studia.Kierunek);
                                    int item = liczbynakierunkach[index];
                                    liczbynakierunkach[index] = (liczbynakierunkach[index] + 1);*/




                            }
                            }
                        }
                    /*foreach(string kierunki in kierunkis)
                    {
                        Console.WriteLine(kierunki);
                    }*/
                    Console.WriteLine("koniec tworzenia");

                    Console.WriteLine("liczba studentow w pliku to "+liczba);
                    Console.WriteLine("liczba studentow dodanych do listy to " +list.Count);
                }
                var listaActAndliczby = new List<string>();
                for (int i = 0; i < kierunkis.Count; i++)
                {
                    listaActAndliczby.Add("name:" + kierunkis[i] + " " + "numberOfStudents " + liczbynakierunkach[i]+"");
                }
                var ucz = new Uczelnia
                {
                    data = "13.03.2020",
                    author = "Seweryn_Kruk",
                    studenci = list,
                    kierunki = listaKier
                };
            
                if (format.Equals("xml"))
                {
                    Console.WriteLine("Tworze xml");
                    FileStream writer = new FileStream(outPath, FileMode.Create);
                    XmlSerializer serializer = new XmlSerializer(typeof(Uczelnia), new XmlRootAttribute("uczelnia"));
                    XmlSerializerNamespaces empty = new XmlSerializerNamespaces();
                    empty.Add("", "");
                    serializer.Serialize(writer, ucz,empty);
                }
                if (format.Equals("json"))
                {
                    Console.WriteLine("Tworze json");
                    var jsonString = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText("data.json", jsonString);
                }
                Console.WriteLine("zakończopno działnie programu");
            }
            catch (ArgumentException e)
            {
                File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "podana sciezka nie jest poprawna" + Environment.NewLine);
            }
            catch (FileNotFoundException e)
            {
                File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/logi.txt"), "plik nie istnieje" + Environment.NewLine);
            }

        }
    }
}
