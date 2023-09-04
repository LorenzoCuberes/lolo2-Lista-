using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String texto = "";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                texto = texto + " Nombre: " + nom.Text + "      Cantidad:" + Cantidad.Text + "\n";
                label1.Text = "Lista: "+texto;
            }
            catch (Exception ex)
            {
            }

        }
    }
}
