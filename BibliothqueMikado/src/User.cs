using System;
using System.Collections.Generic;
using System.Text;


    public class User
    {
        public string Name { get; set; }

        private string Password { get; set; }

        public string Rank { get; set; }

        public List<int> Favori { get; set; }

        public int Id { get; set; }

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

        public bool AddMedia(Media media)
        {
            Favori.Add(media.Id);
            return true;
        }
        public bool RemoveMedia(int id)
        {
            if (id < 0) throw new ArgumentException("Index is negative");
            if (id > Favori.Count) throw new ArgumentOutOfRangeException("Index is out of range");
            Favori.Remove(Id);
            return true;
        }
    }

