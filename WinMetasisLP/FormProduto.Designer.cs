
namespace WinMetasisLP
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdtProdutoId = new System.Windows.Forms.TextBox();
            this.EdtDescricao = new System.Windows.Forms.TextBox();
            this.EdtPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // EdtProdutoId
            // 
            this.EdtProdutoId.Location = new System.Drawing.Point(72, 6);
            this.EdtProdutoId.Name = "EdtProdutoId";
            this.EdtProdutoId.Size = new System.Drawing.Size(100, 20);
            this.EdtProdutoId.TabIndex = 3;
            this.EdtProdutoId.Leave += new System.EventHandler(this.btnLoad_Click);
            // 
            // EdtDescricao
            // 
            this.EdtDescricao.Location = new System.Drawing.Point(72, 31);
            this.EdtDescricao.Name = "EdtDescricao";
            this.EdtDescricao.Size = new System.Drawing.Size(408, 20);
            this.EdtDescricao.TabIndex = 4;
            // 
            // EdtPreco
            // 
            this.EdtPreco.Location = new System.Drawing.Point(72, 57);
            this.EdtPreco.Name = "EdtPreco";
            this.EdtPreco.Size = new System.Drawing.Size(100, 20);
            this.EdtPreco.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(72, 83);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "Salvar";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Preco});
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProdutos.Location = new System.Drawing.Point(0, 127);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(800, 323);
            this.dgProdutos.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(234, 83);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(109, 23);
            this.btnLoadGrid.TabIndex = 11;
            this.btnLoadGrid.Text = "Atualizar Lista";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(259, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.EdtPreco);
            this.Controls.Add(this.EdtDescricao);
            this.Controls.Add(this.EdtProdutoId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdtProdutoId;
        private System.Windows.Forms.TextBox EdtDescricao;
        private System.Windows.Forms.MaskedTextBox EdtPreco;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.Button btnClean;
    }
}