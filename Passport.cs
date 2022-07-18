using System;
using System.Text;
using static System.Console;

namespace HW_Inheritance
{
    public class Passport
    {        
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? MiddleName { get; set; }
        public string? Address { get; set; }
        public string? BirthDate { get; set; }

        public Passport()
        {
            this.Surname = null;
            this.Name = null;
            this.MiddleName = null;
            this.Address = null;
            this.BirthDate = null;
        }
        public Passport(string? surname, string? name, string? middleName, string? address, string? birthDate) : this()
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Address = address;
            BirthDate = birthDate;
        }

        public virtual void TypeInformation()
        {
            WriteLine("Hello, this is a class Passport!");
        }

        public virtual void OutInfo()
        {            
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Name -> {Name}");
            WriteLine($"Middle name -> {MiddleName}");
            WriteLine($"Address -> {Address}");
            WriteLine($"Date of birth -> {BirthDate}");
        }
    }

    public class ForeignPassport : Passport
    {
        public string? Visa { get; set; }
        public int? Number { get; set; }

        public ForeignPassport(string? surname, string? name, string? middleName, string? address, string? birthDate,string? visa, int? number) : 
            base(surname, name, middleName, address, birthDate)
        {
            Visa = visa;
            Number = number;
        }

        public override void TypeInformation()
        {
            WriteLine("Hello, this is a class ForeignPassport!");
        }

        public override void OutInfo()
        {
            WriteLine($"Surname -> {Surname}");
            WriteLine($"Name -> {Name}");
            WriteLine($"Middle name -> {MiddleName}");
            WriteLine($"Address -> {Address}");
            WriteLine($"Date of birth -> {BirthDate}");
            WriteLine($"Visa -> {Visa}");
            WriteLine($"Number -> {Number}");
        }

    }
}
