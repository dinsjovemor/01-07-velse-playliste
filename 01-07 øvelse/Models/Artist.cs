using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07_øvelse.Models
{
    public class Artist
    {
        public string Name { get; set; } //Definerer en property (Som er en field )
        public string Description { get; set; }
        public int AmountOfMembers { get; set; }
        public int YearFormed { get; set; }

        public bool IsActive { get; set; } = true; //Definerer en property (Som er en field ) med default value


        public Artist()
        {

        }

        // parametre
        // definerer reglerne for hvordan man kan oprette en ny instans

        public Artist(string name, string description, int amountOfMembers, int yearFormed, bool isActive)
        {
            Name = name;
            Description = description;
            AmountOfMembers = amountOfMembers;
            YearFormed = yearFormed;
            IsActive = isActive;
        }

        public void PrintArtist() 
        {
            Console.WriteLine($"Artist: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Numbers: {AmountOfMembers}");
            Console.WriteLine($"Year formed: {YearFormed}");
            if (IsActive == true)
            {
                Console.WriteLine($"Active or not: Yes");
            }
            else
            {
                Console.WriteLine($"Active or not: No");
            }
        }
    }
}
