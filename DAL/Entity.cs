using System;
using System.Runtime.Serialization;

namespace DAL
{
    [Serializable] [DataContract]
    public class Student : IAbilityToSing, ICourse
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Birthday { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Course { get; set; }
        [DataMember]
        public int Group { get; set; }
        [DataMember]
        public bool AbilityToSing { get; set; }

        public Student(int id, string lastname, string name, string birthday, bool abilityToSing,  int age, int course, int group)
        {
            ID = id;
            LastName = lastname;
            Name = name;
            Birthday = birthday;
            AbilityToSing = abilityToSing;
            Age = age;
            Course = course;
            Group = group;
        }

        public Student()
        {
        }
    }
    [Serializable] [DataContract]
    public class Teacher : IAbilityToSing
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Birthday { get; set; }
        [DataMember]
        public bool AbilityToSing { get; set; }

        public Teacher(string name, string lastname, int id, bool abilityToSing, string birthday)
        {
            ID = id;
            Name = name;
            LastName = lastname;
            AbilityToSing = abilityToSing;
            Birthday = birthday;
        }
        public Teacher()
        {

        }
    }
    [Serializable] [DataContract]
    public class Astronaut : IAbilityToSing
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Birthday { get; set; }
        [DataMember]
        public bool AbilityToSing { get; set; }

        public Astronaut(string name, string lastname, int id, bool abilityToSing, string birthday)
        {
            ID = id;
            Name = name;
            LastName = lastname;
            AbilityToSing = abilityToSing;
            Birthday = birthday;
        }
        public Astronaut()
        {

        }
    }

    interface ICourse
    {
        int Course { get; set; }
    }
    interface IAbilityToSing
    {
        bool AbilityToSing { get; set; }
    }
}
