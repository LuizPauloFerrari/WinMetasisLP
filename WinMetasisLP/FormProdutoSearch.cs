using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMetasisLP.Entities;
using WinMetasisLP.Util;

namespace WinMetasisLP
{
    public partial class FormProdutoSearch : Form
    {
        public string ResultValue;
        
        public FormProdutoSearch()
        {
            InitializeComponent();
            ResultValue = "";
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            Produto _ProdutoModel;
            _ProdutoModel = new Produto();
            //await Task.Delay(5000);
            dgProdutos.Rows.Clear();

            List<Produto> _Produtos = new List<Produto>();

            _Produtos = await UtilAPI.GetAllAsync<List<Produto>>(_ProdutoModel);
            foreach (Produto _Produto in _Produtos)
            {
                dgProdutos.Rows.Add(_Produto.produtoId, _Produto.descricao, _Produto.preco);
            }
        }

        private void dgProdutos_DoubleClick(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
