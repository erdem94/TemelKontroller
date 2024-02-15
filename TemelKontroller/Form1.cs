using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemelKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonGiris_MouseEnter(object sender, EventArgs e)
        {
            butonGiris.BackColor = Color.Blue;
            butonGiris.ForeColor = Color.Green;
        }

        private void butonGiris_MouseLeave(object sender, EventArgs e)
        {
            butonGiris.BackColor=SystemColors.Window;
            butonGiris.ForeColor=SystemColors.WindowText;
        }

        private void MouseGiris_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "mouse tıklandı";      
        }

        private void MouseGiris_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "mouse serbest bırakıldı";
        }
    }
}
