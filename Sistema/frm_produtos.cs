using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;
namespace Sistema
{
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_categoriaTableAdapter.Fill(this.db_sistemaDataSet.tb_categoria);
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.produtos;
            this.tbcategoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {

                this.produtosBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto Cadastrada com socesso!");

            }
        }
        private bool validar()
        {
            if (txt_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo e obrigatorio");
                txt_descricao.Focus();
                return false;
            }
            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza!", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    this.produtosBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto excluida com socesso!");

                

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.CancelEdit();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((categoria)e.Value).desc_categoria;
        }
    }
}
