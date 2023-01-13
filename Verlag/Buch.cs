using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string titel;
        private string autor;

        private int auflage;

        public Buch(string autor, string titel, int auflage) : this(titel, autor)
        {
            this.titel = titel;
            this.autor = autor;
            if(auflage <= 0)
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


    }
}
