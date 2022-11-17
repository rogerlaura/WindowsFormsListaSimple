using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsListaSimple
{
    struct nodoAsig
    {
        public string nomb;
        public int cantHrs;


    }
    internal class TNodoAsig:TNodo
    {
        public nodoAsig info;
        public TNodoAsig(string nom, int ch) : base()
        {
            info.nomb = nom;
            info.cantHrs = ch;
        }

        public string dameAsig()
        {
            return info.nomb;
        }

        public int dameHoras()
        {
            return info.cantHrs;
        }
    }
}
