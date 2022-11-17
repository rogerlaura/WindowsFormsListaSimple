using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaSimple
{
    internal class TlistAsig:TLista
    {
        public TlistAsig() : base() { }

        public void crearLista(string a, int hr)
        {
            insertar(new TNodoAsig(a, hr));
        }

        public TNodo sucessor()
        {
            return getProxCursor();
        }

        public TNodo antecessor()
        {
            return getAntCursor();
        }

        public bool eliminarLista()
        {
            eliminar();
            return true;
        }
        public bool BuscarAsig(String nom)
        {
            bool bus = false;
            TNodo p;
            p = primero;
            while (p != null && bus == false)
            {
                if (((TNodoAsig)p).dameAsig().Equals(nom))
                    bus = true;
                else
                    p = p.pEnlace;
            }
            if (bus)
                cursor = p;
            return bus;
        }
        public void Listar(ListBox lista,ListBox horas)
        {
            lista.Items.Clear();
            horas.Items.Clear();
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA VACIA");
            }
            else
            {
                TNodo puntero = this.primero;
                while (puntero != null)
                {
                    lista.Items.Add(((TNodoAsig)puntero).dameAsig());
                    horas.Items.Add(((TNodoAsig)puntero).dameHoras());
                    puntero = puntero.pEnlace;
                }
            }
        }
        public void AsignaturaMayor(Label asignatura,Label hora)
        {
            int mayor = 0;
            string asig = "asignatura", h = "hora";
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA VACIA");
            }
            else
            {
                TNodo puntero = this.primero;
                while (puntero != null)
                {
                    if (((TNodoAsig)puntero).dameHoras() >=mayor )
                    {
                        mayor = ((TNodoAsig)puntero).dameHoras();
                        asig = ((TNodoAsig)puntero).dameAsig();
                        h = ((TNodoAsig)puntero).dameHoras().ToString();

                    }
                    puntero = puntero.pEnlace;
                }
            }
            asignatura.Text = asig;
            hora.Text = h;
            
        }
        public TNodo AsignaturaMenor()
        {
            int menor = 100;
            TNodo asig=null;
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA VACIA");
            }
            else
            {
                TNodo puntero = this.primero;
                while (puntero != null)
                {
                    if(menor>= ((TNodoAsig)puntero).dameHoras())
                    {
                        menor = ((TNodoAsig)puntero).dameHoras();
                        asig = puntero;

                    }
                    puntero = puntero.pEnlace;
                }
            }
            return asig;
        }
        public void AsignaturaPromedio(Label label)
        {
            double cantidad = 0, suma = 0;
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA VACIA");
            }
            else
            {
                TNodo puntero = this.primero;
                while (puntero != null)
                {
                    cantidad++;
                    suma += ((TNodoAsig)puntero).dameHoras();
                    puntero = puntero.pEnlace;
                }
                label.Text = suma + "/" + cantidad + " = " + suma / cantidad;
            }
        }
        public void AsignaturaPrimos(ListBox lista)
        {
            
            lista.Items.Clear();
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA VACIA");
            }
            else
            {
                TNodo puntero = this.primero;

                while (puntero != null)
                {
                    if (this.NumeroPrimo(((TNodoAsig)puntero).dameHoras()))
                    {
                        lista.Items.Add( ((TNodoAsig)puntero).dameAsig() + "  => " + ((TNodoAsig)puntero).dameHoras());
                    }
                    puntero = puntero.pEnlace;
                }
            }
        }
        public bool NumeroPrimo(int n)
        {
            int contador = 0;
            for(int i=1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    contador++;
                }
            }
            if(contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
