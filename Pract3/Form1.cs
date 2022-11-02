using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3
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
            Autor autor2= new Autor();

            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();

            Publicador publicador1 = new Publicador();
            Publicador publicador2 = new Publicador();

            Titulo titulo1 = new Titulo();
            Titulo titulo2 = new Titulo();

            Venta venta1 = new Venta();
            Venta venta2 = new Venta();
        }
    }
}
