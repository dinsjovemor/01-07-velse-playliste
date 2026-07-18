using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07_øvelse.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        
        public User Owner { get; set; }

    }
}
