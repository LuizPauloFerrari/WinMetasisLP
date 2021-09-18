using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMetasisLP.Entities;
using WinMetasisLP.Util;

namespace WinMetasisLP
{
    public partial class FormProduto : Form
    {
        //static HttpClient client = new HttpClient();

        public FormProduto()
        {
            InitializeComponent();

            UtilAPI.ConfigureClient();

            //client.BaseAddress
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            //Reload
            Produto _Produto = new Produto
            {
                produtoId = Convert.ToInt32(EdtProdutoId.Text)
            };

            _Produto = await UtilAPI.GetAsync(_Produto, $"/api/Produto/{_Produto.produtoId}");

            //Refresh
            EdtProdutoId.Text = _Produto.produtoId.ToString();
            EdtDescricao.Text = _Produto.descricao;
            EdtPreco.Text = _Produto.preco.ToString();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            //Reload
            Produto _Produto = new Produto
            {
                //produtoId = Convert.ToInt32(EdtProdutoId.Text)
                descricao =EdtDescricao.Text,
                preco = Convert.ToDouble(EdtPreco.Text)
            };

            var url = await UtilAPI.CreateAsync<Produto>(_Produto, "Produto");
            _Produto = await UtilAPI.GetAsync(_Produto, url.PathAndQuery);

            //Refresh
            EdtProdutoId.Text = _Produto.produtoId.ToString();

        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            //Reload
            Produto _Produto = new Produto
            {
                produtoId = Convert.ToInt32(EdtProdutoId.Text),
                descricao = EdtDescricao.Text,
                preco = Convert.ToDouble(EdtPreco.Text)
            };

            await UtilAPI.UpdateAsync(_Produto, $"Produto/{_Produto.produtoId}");

            //Refresh
            EdtProdutoId.Text = _Produto.produtoId.ToString();
            EdtDescricao.Text = _Produto.descricao;
            EdtPreco.Text = _Produto.preco.ToString();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //Reload
            Produto _Produto = new Produto
            {
                produtoId = Convert.ToInt32(EdtProdutoId.Text)
            };

            var statusCode = await UtilAPI.DeleteAsync(_Produto.produtoId, "Produto");
            MessageBox.Show($"Registro Excluído! (HTTP Status = {(int)statusCode})");

            //Refresh
            EdtProdutoId.Text = _Produto.produtoId.ToString();
            EdtDescricao.Text = _Produto.descricao;
            EdtPreco.Text = _Produto.preco.ToString();
        }

        private async void btnLoadGrid_Click(object sender, EventArgs e)
        {
            //await Task.Delay(5000);
            dgProdutos.Rows.Clear();

            List<Produto> _Produtos = new List<Produto>();

            _Produtos = await UtilAPI.GetAllAsync<List<Produto>>(_Produtos, "Produto");
            foreach(Produto _Produto in _Produtos)
            {
                dgProdutos.Rows.Add(_Produto.produtoId, _Produto.descricao, _Produto.preco);
            }
            
        }
    }
}
