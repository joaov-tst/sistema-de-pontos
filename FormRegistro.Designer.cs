namespace Sistema_de_Pontos
{
    partial class FormRegistro
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.inputTopoRegistro = new MetroFramework.Controls.MetroComboBox();
            this.inputCPF = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMainMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlMainMessage.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(101, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código de Funcionário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(101, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Registro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRegistrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(275, 132);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 45);
            this.btnRegistrar.Style = MetroFramework.MetroColorStyle.White;
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseCustomBackColor = true;
            this.btnRegistrar.UseCustomForeColor = true;
            this.btnRegistrar.UseSelectable = true;
            this.btnRegistrar.UseStyleColors = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // inputTopoRegistro
            // 
            this.inputTopoRegistro.FormattingEnabled = true;
            this.inputTopoRegistro.ItemHeight = 23;
            this.inputTopoRegistro.Items.AddRange(new object[] {
            "Início do Expediente",
            "Início do Intervalo",
            "Fim do Intervalo",
            "Fim do Expediente",
            "..."});
            this.inputTopoRegistro.Location = new System.Drawing.Point(106, 148);
            this.inputTopoRegistro.Name = "inputTopoRegistro";
            this.inputTopoRegistro.Size = new System.Drawing.Size(148, 29);
            this.inputTopoRegistro.TabIndex = 7;
            this.inputTopoRegistro.UseSelectable = true;
            // 
            // inputCPF
            // 
            this.inputCPF.BackColor = System.Drawing.Color.MistyRose;
            // 
            // 
            // 
            this.inputCPF.CustomButton.Image = null;
            this.inputCPF.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.inputCPF.CustomButton.Name = "";
            this.inputCPF.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.inputCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputCPF.CustomButton.TabIndex = 1;
            this.inputCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputCPF.CustomButton.UseSelectable = true;
            this.inputCPF.CustomButton.Visible = false;
            this.inputCPF.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.inputCPF.IconRight = true;
            this.inputCPF.Lines = new string[0];
            this.inputCPF.Location = new System.Drawing.Point(106, 65);
            this.inputCPF.MaxLength = 32767;
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.PasswordChar = '\0';
            this.inputCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputCPF.SelectedText = "";
            this.inputCPF.SelectionLength = 0;
            this.inputCPF.SelectionStart = 0;
            this.inputCPF.ShortcutsEnabled = true;
            this.inputCPF.Size = new System.Drawing.Size(270, 35);
            this.inputCPF.TabIndex = 6;
            this.inputCPF.UseCustomBackColor = true;
            this.inputCPF.UseCustomForeColor = true;
            this.inputCPF.UseSelectable = true;
            this.inputCPF.UseStyleColors = true;
            this.inputCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.label3.Size = new System.Drawing.Size(493, 134);
            this.label3.TabIndex = 11;
            this.label3.Text = "Identifique-se com o seu código de funcionário, informe o tipo do registro está f" +
    "azendo e clique para bater o ponto.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlMainMessage);
            this.panel1.Controls.Add(this.inputCPF);
            this.panel1.Controls.Add(this.inputTopoRegistro);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel1.Size = new System.Drawing.Size(493, 332);
            this.panel1.TabIndex = 12;
            // 
            // pnlMainMessage
            // 
            this.pnlMainMessage.Controls.Add(this.pnlMessage);
            this.pnlMainMessage.Location = new System.Drawing.Point(106, 193);
            this.pnlMainMessage.Name = "pnlMainMessage";
            this.pnlMainMessage.Size = new System.Drawing.Size(270, 65);
            this.pnlMainMessage.TabIndex = 11;
            this.pnlMainMessage.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(262, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Minha mensagem";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.Tomato;
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMessage.Location = new System.Drawing.Point(0, 20);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(270, 45);
            this.pnlMessage.TabIndex = 12;
            // 
            // timerMessage
            // 
            this.timerMessage.Tick += new System.EventHandler(this.timerMessage_Tick);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(493, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMainMessage.ResumeLayout(false);
            this.pnlMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroComboBox inputTopoRegistro;
        private MetroFramework.Controls.MetroTextBox inputCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Timer timerMessage;
    }
}