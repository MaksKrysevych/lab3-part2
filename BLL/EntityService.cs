using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class EntityService
    {
        public void AddStudent(List<Student> students)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Course:");
                int course = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Group:");
                int group = Convert.ToInt32(Console.ReadLine());

                bool abilityToSing;

                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                DateTime birth = DateTime.Parse(birthday);
                DateTime today = DateTime.Today;
                int age = today.Year - birth.Year;

                students.Add(new Student(id, lastname, name, birthday, abilityToSing, age, course, group));
            }
        }
        public void AddTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();

                bool abilityToSing;

                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                teachers.Add(new Teacher(lastname, name, id, abilityToSing, birthday));
            }
        }
        public void AddAstronaut(List<Astronaut> astronauts)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();

                bool abilityToSing;
                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                astronauts.Add(new Astronaut(lastname, name, id, abilityToSing, birthday));
            }
        }

        public void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("ID of student:");
            int key = int.Parse(Console.ReadLine());
            students.Remove(students.Find(r => r.ID == key));
        }
        public void DeleteTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("ID of teacher:");
            int key = int.Parse(Console.ReadLine());
            teachers.Remove(teachers.Find(r => r.ID == key));
        }
        public void DeleteAstronaut(List<Astronaut> astronauts)
        {
            Console.WriteLine("ID of astronaut:");
            int key = int.Parse(Console.ReadLine());
            astronauts.Remove(astronauts.Find(r => r.ID == key));
        }

        public void ShowAllInfo(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + s.ID);
                Console.WriteLine("Lastname: " + s.LastName);
                Console.WriteLine("Firstname: " + s.Name);
                Console.WriteLine("Birthday: " + s.Birthday);
                Console.WriteLine("Ability to sing:" + s.AbilityToSing);
                Console.WriteLine("Age: " + s.Age);
                Console.WriteLine("Course: " + s.Course);
                Console.WriteLine("Group: " + s.Group);
                Console.WriteLine();
            }
            foreach (Teacher t in teachers)
            {
                Console.WriteLine("ID: " + t.ID);
                Console.WriteLine("Lastname: " + t.LastName);
                Console.WriteLine("Firstname: " + t.Name);
                Console.WriteLine("Ability to sing:" + t.AbilityToSing);
                Console.WriteLine("Birthday: " + t.Birthday);
                Console.WriteLine();
            }
            foreach (Astronaut a in astronauts)
            {
                Console.WriteLine("ID: " + a.ID);
                Console.WriteLine("Lastname: " + a.LastName);
                Console.WriteLine("Firstname: " + a.Name);
                Console.WriteLine("Ability to sing:" + a.AbilityToSing);
                Console.WriteLine("Birthday: " + a.Birthday);
                Console.WriteLine();
            }
        }

        public void UpdateStudent(List<Student> students)
        {
            Console.WriteLine("ID of student:");
            var key = int.Parse(Console.ReadLine());
            if (students.Contains(students.Find(r => r.ID == key)))
            {
                Console.WriteLine("New course:");
                var NewCourse = int.Parse(Console.ReadLine());
                students[students.FindIndex(r => r.ID == key)].Course = NewCourse;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
    }
}
