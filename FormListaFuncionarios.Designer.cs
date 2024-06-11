namespace Sistema_de_Pontos
{
    partial class FormListaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.aplicarFiltros = new MetroFramework.Controls.MetroButton();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.painelListagem = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.campoId = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.Label();
            this.CampoEndereco = new System.Windows.Forms.Label();
            this.campoCpf = new System.Windows.Forms.Label();
            this.campoSobrenome = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.Label();
            this.iconLimparFiltro = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLimparFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTAGEM DE FUNCIONÁRIOS";
            // 
            // aplicarFiltros
            // 
            this.aplicarFiltros.BackColor = System.Drawing.Color.OrangeRed;
            this.aplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.aplicarFiltros.Location = new System.Drawing.Point(649, 61);
            this.aplicarFiltros.Name = "aplicarFiltros";
            this.aplicarFiltros.Size = new System.Drawing.Size(227, 30);
            this.aplicarFiltros.TabIndex = 13;
            this.aplicarFiltros.Text = "APLICAR FILTROS";
            this.aplicarFiltros.UseCustomBackColor = true;
            this.aplicarFiltros.UseCustomForeColor = true;
            this.aplicarFiltros.UseSelectable = true;
            this.aplicarFiltros.Click += new System.EventHandler(this.aplicarFiltros_Click);
            // 
            // inputNome
            // 
            this.inputNome.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Location = new System.Drawing.Point(2, 67);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(389, 24);
            this.inputNome.TabIndex = 1;
            // 
            // painelListagem
            // 
            this.painelListagem.AutoScroll = true;
            this.painelListagem.Location = new System.Drawing.Point(2, 144);
            this.painelListagem.Name = "painelListagem";
            this.painelListagem.Size = new System.Drawing.Size(928, 371);
            this.painelListagem.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.campoId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoTelefone, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.CampoEndereco, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoCpf, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoSobrenome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoNome, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 47);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // campoId
            // 
            this.campoId.AutoSize = true;
            this.campoId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoId.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoId.ForeColor = System.Drawing.Color.MistyRose;
            this.campoId.Location = new System.Drawing.Point(3, 0);
            this.campoId.Name = "campoId";
            this.campoId.Size = new System.Drawing.Size(54, 47);
            this.campoId.TabIndex = 8;
            this.campoId.Text = "ID";
            this.campoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoTelefone
            // 
            this.campoTelefone.AutoSize = true;
            this.campoTelefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoTelefone.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.ForeColor = System.Drawing.Color.MistyRose;
            this.campoTelefone.Location = new System.Drawing.Point(783, 0);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(124, 47);
            this.campoTelefone.TabIndex = 4;
            this.campoTelefone.Text = "Telefone";
            this.campoTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CampoEndereco
            // 
            this.CampoEndereco.AutoSize = true;
            this.CampoEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampoEndereco.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoEndereco.ForeColor = System.Drawing.Color.MistyRose;
            this.CampoEndereco.Location = new System.Drawing.Point(549, 0);
            this.CampoEndereco.Name = "CampoEndereco";
            this.CampoEndereco.Size = new System.Drawing.Size(228, 47);
            this.CampoEndereco.TabIndex = 3;
            this.CampoEndereco.Text = "Endereço";
            this.CampoEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoCpf
            // 
            this.campoCpf.AutoSize = true;
            this.campoCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoCpf.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCpf.ForeColor = System.Drawing.Color.MistyRose;
            this.campoCpf.Location = new System.Drawing.Point(395, 0);
            this.campoCpf.Name = "campoCpf";
            this.campoCpf.Size = new System.Drawing.Size(148, 47);
            this.campoCpf.TabIndex = 2;
            this.campoCpf.Text = "CPF";
            this.campoCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoSobrenome
            // 
            this.campoSobrenome.AutoSize = true;
            this.campoSobrenome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoSobrenome.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSobrenome.ForeColor = System.Drawing.Color.MistyRose;
            this.campoSobrenome.Location = new System.Drawing.Point(213, 0);
            this.campoSobrenome.Name = "campoSobrenome";
            this.campoSobrenome.Size = new System.Drawing.Size(176, 47);
            this.campoSobrenome.TabIndex = 1;
            this.campoSobrenome.Text = "Sobrenome";
            this.campoSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoNome
            // 
            this.campoNome.AutoSize = true;
            this.campoNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoNome.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.ForeColor = System.Drawing.Color.MistyRose;
            this.campoNome.Location = new System.Drawing.Point(63, 0);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(144, 47);
            this.campoNome.TabIndex = 0;
            this.campoNome.Text = "Nome";
            this.campoNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconLimparFiltro
            // 
            this.iconLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLimparFiltro.Image = ((System.Drawing.Image)(resources.GetObject("iconLimparFiltro.Image")));
            this.iconLimparFiltro.Location = new System.Drawing.Point(882, 61);
            this.iconLimparFiltro.Name = "iconLimparFiltro";
            this.iconLimparFiltro.Size = new System.Drawing.Size(30, 30);
            this.iconLimparFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLimparFiltro.TabIndex = 14;
            this.iconLimparFiltro.TabStop = false;
            this.iconLimparFiltro.Click += new System.EventHandler(this.iconLimparFiltro_Click);
            // 
            // FormListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.iconLimparFiltro);
            this.Controls.Add(this.aplicarFiltros);
            this.Controls.Add(this.painelListagem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaFuncionarios";
            this.Text = "FormFuncionarios";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLimparFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLimparFiltro;
        private MetroFramework.Controls.MetroButton aplicarFiltros;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.FlowLayoutPanel painelListagem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label campoId;
        private System.Windows.Forms.Label campoTelefone;
        private System.Windows.Forms.Label CampoEndereco;
        private System.Windows.Forms.Label campoCpf;
        private System.Windows.Forms.Label campoSobrenome;
        private System.Windows.Forms.Label campoNome;
    }
}