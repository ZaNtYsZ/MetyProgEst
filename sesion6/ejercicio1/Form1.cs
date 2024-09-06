using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre tbNombre.Text;
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void agregar()
        {
            string nombre tbNombre.Text.Trim;
            if (string,IsnullorEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmMover_Click(object sender, EventArgs e)
        {
            int cant = cmbNombres.Items.Count}
            for (int i = 0; i<cant; i++)
            {
                string nombre = cmbNombres.Items[i].ToString();

       
        } btmNombre2.Items.Add(nombre);
    }  

}

             
           
