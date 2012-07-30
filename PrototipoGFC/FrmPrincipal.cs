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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
        }

        private void clientesFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 1;
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 8;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 9;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 2;
        }

        private void moedaIndeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 3;
        }

        private void centroDeCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 4;
        }

        private void portadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 5;
        }

        private void operacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 6;
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 7;
        }

        private void criarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 10;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 11;
        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 12;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
