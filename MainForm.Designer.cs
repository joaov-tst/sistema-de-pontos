namespace Sistema_de_Pontos
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MudarForm = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinus = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlMain.Controls.Add(this.panel2);
            this.PnlMain.Controls.Add(this.panel1);
            this.PnlMain.Controls.Add(this.pnlMainForm);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMain.Location = new System.Drawing.Point(353, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(497, 470);
            this.PnlMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.MudarForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 55);
            this.panel2.TabIndex = 2;
            // 
            // MudarForm
            // 
            this.MudarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MudarForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MudarForm.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MudarForm.LinkColor = System.Drawing.Color.White;
            this.MudarForm.Location = new System.Drawing.Point(0, 0);
            this.MudarForm.Name = "MudarForm";
            this.MudarForm.Size = new System.Drawing.Size(493, 55);
            this.MudarForm.TabIndex = 13;
            this.MudarForm.TabStop = true;
            this.MudarForm.Text = "Entrar como gerente";
            this.MudarForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MudarForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MudarForm_Clicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureMinus);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 26);
            this.panel1.TabIndex = 2;
            // 
            // pictureMinus
            // 
            this.pictureMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinus.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinus.Image")));
            this.pictureMinus.Location = new System.Drawing.Point(437, 4);
            this.pictureMinus.Name = "pictureMinus";
            this.pictureMinus.Size = new System.Drawing.Size(15, 18);
            this.pictureMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinus.TabIndex = 1;
            this.pictureMinus.TabStop = false;
            this.pictureMinus.Click += new System.EventHandler(this.pictureMinus_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(468, 4);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(15, 18);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainForm.Location = new System.Drawing.Point(0, 0);
            this.pnlMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(493, 466);
            this.pnlMainForm.TabIndex = 1;
            this.pnlMainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainForm_Paint);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblBemVindo);
            this.pnl.Controls.Add(this.lblUsuario);
            this.pnl.Controls.Add(this.pictureBox1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(351, 470);
            this.pnl.TabIndex = 1;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Comfortaa SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(146, 168);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(207, 52);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "Bem vindo,";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Comfortaa", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(117, 207);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(245, 76);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário!";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Pontos.Properties.Resources.logo_solo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.PnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.PnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel MudarForm;
    }
}

