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
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP
{
    public partial class FormProdutoSearch : Form
    {
        public string ResultValue;
        EntityPage<Produto> _ProdutosPage;

        public FormProdutoSearch()
        {
            InitializeComponent();
            ResultValue = "";
            _ProdutosPage = new EntityPage<Produto>
            {
                PageNumber = 1,
                PageSize = 3
            };
            NuPage.Minimum = 1;
            NuPage.Maximum = 1;
        }

        public async void LoadGrid()
        {
            try
            {
                NuPage.Maximum = 99999;
                dgProdutos.Rows.Clear();

                ProdutoDTO _ProdutoModel = new ProdutoDTO
                {
                    ProdutoId = int.TryParse(edtProdutoId.Text, out int i) ? Convert.ToInt32(edtProdutoId.Text) : 0,
                    Descricao = EdtDescricao.Text,
                    PrecoIni = double.TryParse(edtPrecoIni.Text, out double n1) ? Convert.ToDouble(edtPrecoIni.Text) : 0,
                    PrecoFim = double.TryParse(EdtPrecoFim.Text, out double n2) ? Convert.ToDouble(EdtPrecoFim.Text) : 0
                };

                //List<Produto> _Produtos;
                //_Produtos = await UtilAPI.PostFilterAsync<List<Produto>,ProdutoDTO>(_ProdutoModel);

                _ProdutosPage = await
                        UtilAPI.PostFilterAsyncPage<Produto, ProdutoDTO>(
                            _ProdutoModel, 
                            _ProdutosPage.PageNumber, 
                            _ProdutosPage.PageSize);
     
                if (_ProdutosPage.Items != null)
                {
                    foreach (Produto _Produto in _ProdutosPage.Items)
                    {
                        dgProdutos.Rows.Add(_Produto.ProdutoId, _Produto.Descricao, _Produto.Preco);
                    }
                }
            }
            finally
            {
                NuPage.Value = _ProdutosPage.PageNumber <= 0 ? 1 : _ProdutosPage.PageNumber;
                NuPage.Maximum = _ProdutosPage.PageCount <= 0 ? 1 : _ProdutosPage.PageCount;
                lbCount.Text = $"Número de Registros: {_ProdutosPage.TotalItemCount}";
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //NuPage.Value++;
            LoadGrid();
        }

        private void DgProdutos_DoubleClick(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
        }

        private void DgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPosterior_Click(object sender, EventArgs e)
        {
            if (_ProdutosPage.PageNumber < _ProdutosPage.PageCount) 
            {
                _ProdutosPage.PageNumber++;
            };
            LoadGrid();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_ProdutosPage.PageNumber > 1) { _ProdutosPage.PageNumber--; };
            LoadGrid();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            _ProdutosPage.PageNumber = 1;
            LoadGrid();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            _ProdutosPage.PageNumber = _ProdutosPage.PageCount;
            LoadGrid();
        }
    }
}
