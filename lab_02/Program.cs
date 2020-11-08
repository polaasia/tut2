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
            FileStream writer = new FileStream(@"result.xml", FileMode.Create);
            FileStream errorsLog = new FileStream(@"log.txt", FileMode.Create);

            var list = new List<Student>();
            var studieslist = new List<Studies>();
            var errors = new List<string>();

            FileInfo file = new FileInfo("C:\\DZO\\STUDIA\\SEMESTR 5\\APBD\\WEEK_02\\dane.csv");

            if (file.Exists)
            {
                using (var stream = new StreamReader(file.OpenRead()))
                {
                    string line = null;
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] student = line.Split(',');

                        if (student.Length == 9)
                        {
                            if (false){/* check if surname does not contain digit*/ }
                            else {
                                var studies = new Studies { StudiesName = student[2], StudiesMode = student[3], numberOfStudents = 0 };

                                var st = new Student
                                {
                                    IDStudent = student[4],
                                    FirstName = student[0],
                                    LastName = student[1],
                                    DoB = student[5],
                                    Email = student[6],
                                    MothersName = student[7],
                                    FathersName = student[8],


                                };

                                list.Add(st);
                                if (studieslist.Contains(studies))
                                {
                                    studies.numberOfStudents++;
                                }
                                else
                                {
                                    studieslist.Add(studies);
                                    studies.numberOfStudents = 1;
                                }
                            } 
                        }
                        else
                        {
                            errors.Add(student.ToString());
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("File does not exist");
            }



            University uni = new University { CreatedAt = DateTime.Now.Date, Author = "s19188", Students = list, ActiveStudies = studieslist};
            UniversityWrapper uwrap = new UniversityWrapper { University = uni };

            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("university"));
            xmlserializer.Serialize(writer, list);

            var jsonString = JsonSerializer.Serialize(uwrap, typeof(UniversityWrapper));
            File.WriteAllText("data.json", jsonString );

            


        }
    }
}
