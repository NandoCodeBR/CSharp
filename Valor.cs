using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            lbl1.Text = "Valor investido agora é " + valorInvestido;
        
        }
    }
}
