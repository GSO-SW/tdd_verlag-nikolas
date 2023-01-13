using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string titel;
        private string autor;
        private string ISBN13;

        private int auflage;

        public Buch(string autor, string titel, int auflage, string ISBN13) : this(autor,titel,auflage)
        {
           

            ISBN13 = ISBN13.Remove(4);
            if (ISBN13.Length == 9)
            {
                Random randonpruef = new Random();
                int isbn13_RanNumber = randonpruef.Next(1000, 9999);
                ISBN13 = $"{ISBN13}{isbn13_RanNumber}";
            }

            ISBN13 = String.Concat(4, "-");
            this.ISBN13 = ISBN13;
        }

        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.auflage = auflage;
            
        }
        public Buch(string autor, string titel) 
        {
            this.titel = titel;

            if (autor == "")
                throw new ArgumentException();
            if (autor == "#")
                throw new ArgumentException();
            if (autor == ";")
                throw new ArgumentException();
            if (autor == "§")
                throw new ArgumentException();
            if (autor == "%")
                throw new ArgumentException();
            if (autor == null)
                throw new ArgumentException();

            this.autor = autor;
            
            auflage = 1;
        }

        public string Titel
        {
            get { return titel; } 
        }

        public string Autor
        {
            get { return autor;  }
            set { autor = value; }
        }

        public int Auflage
        {
            get { return auflage; }
            set { if(value <= 0)
                { throw new ArgumentOutOfRangeException(); }
                        auflage = value; }
        }
        public string AISBN13
        {
            get
            {
                return ISBN13;
            }
        }


    }
}
