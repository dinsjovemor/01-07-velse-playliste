using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07_øvelse.Models
{
    public class Song
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }

        public string AlbumName { get; set; }

        public int ReleaseYear { get; set; }

        public int LengthInSeconds { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }


    }
}
