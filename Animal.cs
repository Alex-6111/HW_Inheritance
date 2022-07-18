using System;
using System.Text;
using static System.Console;

namespace HW_Inheritance
{
    public class Animal
    {
       public string? Name { get; set; }
       public string? Description { get; set; } 

        public Animal(string? name, string? description)
        {
            Name = name;
            Description = description;
        }

        public Animal()
        {
            Name = "Jack";
            Description = "German shepherd";
        }


        public virtual void TypeInformation()
        {
            WriteLine("Hello, this is a class Animal!");
        }

        public virtual void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Description -> {Description}");
        }
    }

    public class Tiger : Animal
    {
        public Tiger(string? name, string? description) : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public Tiger()
        {
            Name = "Ninja";
            Description = "Сhinese tiger";
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Tiger!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Description -> {Description}");
        }
    }

    public class Crocodile : Animal
    {
        public Crocodile(string? name, string? description) : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public Crocodile()
        {
            Name = "Gena";
            Description = "Crested crocodile";
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Crocodile!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Description -> {Description}");
        }
    }

    public class Kangaroo : Animal
    {
        public Kangaroo(string? name, string? description) : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public Kangaroo()
        {
            Name = "Bob";
            Description = "Big red kangaroo";
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class Kangaroo!");
        }

        public override void OutInfo()
        {
            WriteLine($"Name -> {Name}");
            WriteLine($"Description -> {Description}");
        }
    }
}
