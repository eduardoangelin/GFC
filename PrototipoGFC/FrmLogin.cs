using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoGFC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nao foi possivel logar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
