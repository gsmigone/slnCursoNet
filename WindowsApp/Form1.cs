using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.EntidadesEjercicio3;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            Autor autor1 = new Autor();
            Empleado empleado1 = new Empleado();
            Autor autor2 = new Autor();
            Empleado empleado2 = new Empleado();
            Publicador publicador1 = new Publicador();
            Publicador publicador2 = new Publicador();
            Titulo titulo1 = new Titulo();
            Titulo titulo2 = new Titulo();
            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

            //set propiedades
            autor1.Apellido = "Migone Autor";
            autor1.Nombre = "Sebastian";
            autor1.FechaNacimiento = new DateTime(1992, 10, 1);
            

            empleado1.Apellido = "Migone Empleado";
            empleado1.Nombre = "Gaston";
            empleado1.Titulo = "ingeniero";

            MessageBox.Show(empleado1.Apellido + " " + empleado1.Nombre);
            MessageBox.Show(autor1.Apellido + " " + autor1.Nombre);

            //Hay que seguir completando

        }
    }
}
