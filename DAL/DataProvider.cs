using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace DAL
{
    public class BinaryProvider
    {
        public void BinarySerialization(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            BinaryFormatter binFormatterOfStudents = new BinaryFormatter();
            using (var file = new FileStream("students.bin", FileMode.OpenOrCreate))
            {
                binFormatterOfStudents.Serialize(file, students);
            }

            using (var file = new FileStream("students.bin", FileMode.OpenOrCreate))
            {
                var newStudents = binFormatterOfStudents.Deserialize(file) as List<Student>;

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            BinaryFormatter binFormatterOfTeachers = new BinaryFormatter();
            using (var file = new FileStream("teachers.bin", FileMode.OpenOrCreate))
            {
                binFormatterOfTeachers.Serialize(file, teachers);
            }

            using (var file = new FileStream("teachers.bin", FileMode.OpenOrCreate))
            {
                var newTeachers = binFormatterOfTeachers.Deserialize(file) as List<Teacher>;

                if (newTeachers != null)
                {
                    foreach (var teacher in newTeachers)
                    {
                        Console.WriteLine(teacher);
                    }
                }
            }

            BinaryFormatter binFormatterOfAstronauts = new BinaryFormatter();
            using (var file = new FileStream("astronauts.bin", FileMode.OpenOrCreate))
            {
                binFormatterOfAstronauts.Serialize(file, astronauts);
            }

            using (var file = new FileStream("astronauts.bin", FileMode.OpenOrCreate))
            {
                var newAstronauts = binFormatterOfAstronauts.Deserialize(file) as List<Astronaut>;

                if (newAstronauts != null)
                {
                    foreach (var astronaut in newAstronauts)
                    {
                        Console.WriteLine(astronaut);
                    }
                }
            }
        }
    }

    public class XMLProvider
    {
        public void XMLSerialization(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            XmlSerializer xmlFormatterOfStudents = new XmlSerializer(typeof(List<Student>));
            using (var file = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                xmlFormatterOfStudents.Serialize(file, students);
            }

            using (var file = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                var newStudents = xmlFormatterOfStudents.Deserialize(file) as List<Student>;

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            XmlSerializer xmlFormatterOfTeachers = new XmlSerializer(typeof(List<Teacher>));
            using (var file = new FileStream("teachers.xml", FileMode.OpenOrCreate))
            {
                xmlFormatterOfTeachers.Serialize(file, teachers);
            }

            using (var file = new FileStream("teachers.xml", FileMode.OpenOrCreate))
            {
                var newTeachers = xmlFormatterOfTeachers.Deserialize(file) as List<Teacher>;

                if (newTeachers != null)
                {
                    foreach (var teacher in newTeachers)
                    {
                        Console.WriteLine(teacher);
                    }
                }
            }

            XmlSerializer xmlFormatterOfAstronauts = new XmlSerializer(typeof(List<Astronaut>));
            using (var file = new FileStream("astronauts.xml", FileMode.OpenOrCreate))
            {
                xmlFormatterOfAstronauts.Serialize(file, astronauts);
            }

            using (var file = new FileStream("astronauts.xml", FileMode.OpenOrCreate))
            {
                var newActronauts = xmlFormatterOfAstronauts.Deserialize(file) as List<Astronaut>;

                if (newActronauts != null)
                {
                    foreach (var astronaut in newActronauts)
                    {
                        Console.WriteLine(astronaut);
                    }
                }
            }
        }
    }

    public class JSONProvider
    {
        public void JSONSerialization(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            DataContractJsonSerializer jsonFormatterOfStudents = new DataContractJsonSerializer(typeof(List<Student>));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatterOfStudents.WriteObject(file, students);
            }

            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatterOfStudents.ReadObject(file) as List<Student>;

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            DataContractJsonSerializer jsonFormatterOfTeachers = new DataContractJsonSerializer(typeof(List<Teacher>));
            using (var file = new FileStream("teachers.json", FileMode.OpenOrCreate))
            {
                jsonFormatterOfTeachers.WriteObject(file, teachers);
            }

            using (var file = new FileStream("teachers.json", FileMode.OpenOrCreate))
            {
                var newTeachers = jsonFormatterOfTeachers.ReadObject(file) as List<Teacher>;

                if (newTeachers != null)
                {
                    foreach (var teacher in newTeachers)
                    {
                        Console.WriteLine(teacher);
                    }
                }
            }

            DataContractJsonSerializer jsonFormatterOfAstronauts = new DataContractJsonSerializer(typeof(List<Astronaut>));
            using (var file = new FileStream("astronauts.json", FileMode.OpenOrCreate))
            {
                jsonFormatterOfAstronauts.WriteObject(file, astronauts);
            }

            using (var file = new FileStream("astronauts.json", FileMode.OpenOrCreate))
            {
                var newAstronauts = jsonFormatterOfAstronauts.ReadObject(file) as List<Astronaut>;

                if (newAstronauts != null)
                {
                    foreach (var astronaut in newAstronauts)
                    {
                        Console.WriteLine(astronaut);
                    }
                }
            }
        }
    }

}
