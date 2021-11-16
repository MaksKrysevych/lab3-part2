using BLL;
using DAL;
using System;
using System.Collections.Generic;

namespace lab3
{
    class Menu
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Astronaut> astronauts = new List<Astronaut>();

        Object s = null;

        public void MainMenu()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine("1. Actions with classes");
            Console.WriteLine("2. Actions with serealization");
            Console.WriteLine("3. Close menu");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.Clear();
                        FirstMenu();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        SecondMenu();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        void FirstMenu()
        {
            Console.WriteLine("Choose class:");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Teacher");
            Console.WriteLine("3. Astronaut");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Students();
                        break;
                    }

                case 2:
                    {
                        Teachers();
                        break;
                    }

                case 3:
                    {
                        Astronauts();
                    break;
                    }
                default:
                    break;
            }
        }
        void SecondMenu()
        {
            bool WorkingOfMenu = true;
            while (WorkingOfMenu)
            {
                Console.WriteLine("Operations:");
                Console.WriteLine("1. Binary serealization");
                Console.WriteLine("2. XML-serealization");
                Console.WriteLine("3. JSON serealization");
                Console.WriteLine("4. Custom serealization");
                Console.WriteLine("5. Close menu");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BinaryProvider binary = new BinaryProvider();
                            binary.BinarySerialization(students, teachers, astronauts);
                            break;
                        }
                    case 2:
                        {
                            XMLProvider xml = new XMLProvider();
                            xml.XMLSerialization(students, teachers, astronauts);
                            break;
                        }
                    case 3:
                        {
                            JSONProvider json = new JSONProvider();
                            json.JSONSerialization(students, teachers, astronauts);
                            break;
                        }
                    case 4:
                        {
                            //CustomProvider custom = new CustomProvider();
                            //custom.CustomSerialize(typeof(Student), students, "custom.txt");
                            //s = custom.CustomDeserialize(typeof(Student), "custom.txt") as Student;

                            break;
                        }
                    case 5:
                        {
                            WorkingOfMenu = false;
                            Console.Clear();
                            MainMenu();
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        void Students()
        {
            bool WorkingOfMenu = true;
            while (WorkingOfMenu)
            {
                Console.WriteLine("Operations:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Delete student");
                Console.WriteLine("3. Show students");
                Console.WriteLine("4. Update course of student");
                Console.WriteLine("5. Close menu");
                EntityContext ec = new EntityContext();
                EntityService es = new EntityService();
                int optionOfStudent = Convert.ToInt32(Console.ReadLine());
                switch (optionOfStudent)
                {
                    case 1:
                        {
                            es.AddStudent(students);
                            ec.AddStudents(students);
                            break;
                        }
                    case 2:
                        {
                            es.DeleteStudent(students);
                            ec.DeleteAllInfo();
                            ec.AddStudents(students);
                            break;
                        }
                    case 3:
                        {
                            es.ShowAllInfo(students, teachers, astronauts);
                            break;
                        }
                    case 4:
                        {
                            es.UpdateStudent(students);
                            ec.DeleteAllInfo();
                            ec.AddStudents(students);
                            break;
                        }
                    case 5:
                        {
                            WorkingOfMenu = false;
                            Console.Clear();
                            MainMenu();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        void Teachers()
        {
            bool WorkingOfMenu = true;
            while (WorkingOfMenu)
            {
                Console.WriteLine("Operations:");
                Console.WriteLine("1. Add teacher");
                Console.WriteLine("2. Delete teacher");
                Console.WriteLine("3. Show all people");
                Console.WriteLine("4. Close menu");
                EntityContext ec = new EntityContext();
                EntityService es = new EntityService();
                int optionOfTeacher = Convert.ToInt32(Console.ReadLine());
                switch (optionOfTeacher)
                {
                    case 1:
                        {
                            es.AddTeacher(teachers);
                            ec.AddTeacher(teachers);
                            break;
                        }
                    case 2:
                        {
                            es.DeleteTeacher(teachers);
                            ec.DeleteAllInfo();
                            ec.AddTeacher(teachers);

                            break;
                        }
                    case 3:
                        {
                            es.ShowAllInfo(students, teachers, astronauts);
                            break;
                        }
                    case 4:
                        {
                            WorkingOfMenu = false;
                            Console.Clear();
                            MainMenu();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        void Astronauts()
        {
            bool WorkingOfMenu = true;
            while (WorkingOfMenu)
            {
                Console.WriteLine("Operations:");
                Console.WriteLine("1. Add astronaut");
                Console.WriteLine("2. Delete astronaut");
                Console.WriteLine("3. Show all people");
                Console.WriteLine("4. Close menu");
                EntityContext ec = new EntityContext();
                EntityService es = new EntityService();
                int optionOfAstronaut = Convert.ToInt32(Console.ReadLine());
                switch (optionOfAstronaut)
                {
                    case 1:
                        {
                            es.AddAstronaut(astronauts);
                            ec.AddAstronaut(astronauts);
                            break;
                        }
                    case 2:
                        {
                            es.DeleteAstronaut(astronauts);
                            ec.DeleteAllInfo();
                            ec.AddAstronaut(astronauts);
                            break;
                        }
                    case 3:
                        {
                            es.ShowAllInfo(students, teachers, astronauts);
                            break;
                        }
                    case 4:
                        {
                            WorkingOfMenu = false;
                            Console.Clear();
                            MainMenu();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
