using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibRelacionesPOO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                
                Alumno alumno = new Alumno(textBox1.Text);

                MessageBox.Show(alumno.Nombre);

                textBox1.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
