using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparacion_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            int x, y;

            x = int.Parse(txtnum1.Text);
            y = int.Parse(txtnum2.Text);

            if (x>y)
            {
                lblresultado.Text = " El numero mayor es: " + x + " y el numero menor es: " + y;
            }
            else
            {
                if (y>x)
                {
                    lblresultado.Text = " El numero mayor es: " + y + " y el numero menor es: " + x;
                }
                else
                {
                    lblresultado.Text = x + " y " + y + " son valores iguales";
                }
            }
        }
    }
}
