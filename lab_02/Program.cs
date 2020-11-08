using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace lab_02
{
    class Program  
    {
        

        static void Main(string[] args)
        { 
            FileStream writer = new FileStream(@"list.xml", FileMode.Create);
            

            var list = new List<Student>();

            FileInfo file = new FileInfo("C:\\DZO\\STUDIA\\SEMESTR 5\\APBD\\WEEK_02\\dane.csv");

            using (var stream = new StreamReader(file.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] student = line.Split(',');
                    var st = new Student
                    {
                        IDStudent = student[4],
                        FirstName = student[0],
                        LastName = student[1],
                        DoB = student[5],
                        Email = student[6],
                        MothersName = student[7],
                        FathersName = student[8]


               
                      
                    };
                    list.Add(st);
                }
            }

          
                       
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("university"));
            xmlserializer.Serialize(writer, list);

            


        }
    }
}
