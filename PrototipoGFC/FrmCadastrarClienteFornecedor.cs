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
    public partial class FrmCadastrarClienteFornecedor : Form
    {
        public FrmCadastrarClienteFornecedor()
        {
            InitializeComponent();
        }

        private void FrmCadastrarClienteFornecedor_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja cadastrar esse cliente/fornecedor?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                MessageBox.Show("Cliente/Fornecedor cadastrado na base", "Operacao bem sucedida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
