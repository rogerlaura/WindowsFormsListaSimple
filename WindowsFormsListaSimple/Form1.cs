using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaSimple
{
    public partial class Form1 : Form
    {
        TlistAsig tlista;
        public Form1()
        {
            tlista= new TlistAsig();
            InitializeComponent();
        }


        private void btninsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int horas=int.Parse(txthoras.Text);
            tlista.crearLista(nombre, horas);
            tlista.Listar(listadatos, listahoras);
            cursor.Text=((TNodoAsig)tlista.getCursor()).dameAsig();
            Practica();
            txtnombre.Clear();
            txtnombre.Focus();
            txthoras.Clear();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            tlista.eliminarLista();
            tlista.Listar(listadatos,listahoras);
            Practica();
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            txtnombre.Text = ((TNodoAsig)tlista.getPrimero()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.getPrimero()).dameHoras().ToString();
            cursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            txtnombre.Text = ((TNodoAsig)tlista.getUltimo()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.getUltimo()).dameHoras().ToString();
            cursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            TNodo sig = tlista.sucessor();
            if (sig != null)
            {
                txtnombre.Text = ((TNodoAsig)tlista.sucessor()).dameAsig();
                txthoras.Text = ((TNodoAsig)sig).dameHoras().ToString();
                cursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            }
            else
            {
                MessageBox.Show("NO UN ELEMENTO SIGUIENTE");
            }
            
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            TNodo ant = tlista.antecessor();
            if (ant != null)
            {
                txtnombre.Text = ((TNodoAsig)ant).dameAsig();
                txthoras.Text = ((TNodoAsig)ant).dameHoras().ToString();
                cursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            }
            else
            {
                MessageBox.Show("No existe anterior");
            }
            
        }

        private void listadatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlista.BuscarAsig(listadatos.Text);
            cursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
        }
        public void Practica()
        {
            tlista.AsignaturaMayor(txtasignaturamayor,txthoramayor);
            if (tlista.AsignaturaMenor()!=null)
            {
                txtasignaturamenor.Text = ((TNodoAsig)tlista.AsignaturaMenor()).dameAsig();
                txthoramenor.Text = ((TNodoAsig)tlista.AsignaturaMenor()).dameHoras().ToString();
            }
            else
            {
                txtasignaturamenor.Text = "asignatura";
                txthoramenor.Text = "hora";
            }
            tlista.AsignaturaPromedio(lblprimo);
            tlista.AsignaturaPrimos(asignaturaprimos);
        }
    }
}
