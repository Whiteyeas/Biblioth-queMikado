using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothqueMikado.src
{
    class User
    {
        public string Name { get; set; }

        private string Password { get; set; }

        public string Rank { get; set; }

        public List<int> Favori { get; set; }

        public User(string name, string password, string rank)
        {
            Name = name;
            Password = password;
            Rank = rank;
            Favori = new List<int>();
        }

        public User(string name, string rank, List<int> favori)
        {
            Name = name;
            Rank = rank;
            Favori = favori;
        }
    }
}
