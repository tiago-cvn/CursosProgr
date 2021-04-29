using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

       
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoria frm = new frm_categoria();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_categoria frm = new frm_categoria();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_categoria frm = new frm_categoria();
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void produtosCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}   
