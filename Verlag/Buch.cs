using System;
using System.Collections.Generic;
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

        public Buch(string titel, string autor, int auflage) : this(titel, autor)
        {
            this.titel = titel;
            this.autor = autor;
            this.auflage = auflage;
        }
        public Buch(string titel, string autor) 
        {
            this.titel = titel;
            this.autor = autor;
            this.auflage = 1;
        }

        public string Titel
        {
            get { return titel; } 
        }

        public string Autor
        {
            get { return autor;  }
        }

        public int Auflage
        {
            get { return auflage; }
        }


    }
}
