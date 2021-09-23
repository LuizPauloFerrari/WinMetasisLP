
namespace WinMetasisLP
{
    partial class FormProdutoSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.edtProdutoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EdtPrecoFim = new System.Windows.Forms.MaskedTextBox();
            this.edtPrecoIni = new System.Windows.Forms.MaskedTextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProdutos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Preco});
            this.dgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(649, 341);
            this.dgProdutos.TabIndex = 11;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            this.dgProdutos.DoubleClick += new System.EventHandler(this.dgProdutos_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.edtProdutoId);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.EdtDescricao);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.edtPrecoIni);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.EdtPrecoFim);
            this.flowLayoutPanel1.Controls.Add(this.btnLoad);
            this.flowLayoutPanel1.Controls.Add(this.btnOk);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 268);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 73);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtProdutoId
            // 
            this.edtProdutoId.Location = new System.Drawing.Point(88, 13);
            this.edtProdutoId.Name = "edtProdutoId";
            this.edtProdutoId.Size = new System.Drawing.Size(67, 20);
            this.edtProdutoId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(161, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EdtDescricao
            // 
            this.EdtDescricao.Location = new System.Drawing.Point(246, 13);
            this.EdtDescricao.Name = "EdtDescricao";
            this.EdtDescricao.Size = new System.Drawing.Size(384, 20);
            this.EdtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço Inicial:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(161, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço Inicial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(324, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Atualizar";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(405, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(486, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 21);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(649, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdtPrecoFim
            // 
            this.EdtPrecoFim.Location = new System.Drawing.Point(246, 39);
            this.EdtPrecoFim.Name = "EdtPrecoFim";
            this.EdtPrecoFim.Size = new System.Drawing.Size(72, 20);
            this.EdtPrecoFim.TabIndex = 11;
            // 
            // edtPrecoIni
            // 
            this.edtPrecoIni.Location = new System.Drawing.Point(88, 39);
            this.edtPrecoIni.Name = "edtPrecoIni";
            this.edtPrecoIni.Size = new System.Drawing.Size(67, 20);
            this.edtPrecoIni.TabIndex = 12;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // Preco
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle2;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // FormProdutoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgProdutos);
            this.Name = "FormProdutoSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtProdutoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox edtPrecoIni;
        private System.Windows.Forms.MaskedTextBox EdtPrecoFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}