using System;
using System.Text;
using static System.Console;

namespace HW_Inheritance
{
    public class Human
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }

        public Human()
        {
            this.Name = null;
            this.Surname = null;
            this.Age = null;
        }
        public Human(string? name, string? surname, int? age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public virtual void TypeInformation()
        {
            WriteLine("Hello, this is a class Human!");
        }

        public virtual void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Age -> {Age}");
        }

    }

    public class Builder : Human
    {
        public string? Specialty { get; set; }

        public Builder(string? name, string? surname, int? age, string? specialty) : base(name, surname, age)
        {
            Specialty = specialty;
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Builder!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Age -> {Age}");
            WriteLine($"Specialty -> {Specialty}");
        }

    }

    public class Sailor : Human
    {
        public string? Position { get; set; }

        public Sailor(string? name, string? surname, int? age, string? position) : base(name, surname, age)
        {
            Position = position;
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Sailor!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Age -> {Age}");
            WriteLine($"Specialty -> {Position}");
        }
    }

    public class Pilot : Human
    {
        public string? Rank { get; set; }

        public Pilot(string? name, string? surname, int? age, string? rank) : base(name, surname, age)
        {
            Rank = rank;
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Pilot!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Age -> {Age}");
            WriteLine($"Specialty -> {Rank}");
        }
    }
}
