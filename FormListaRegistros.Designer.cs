﻿namespace Sistema_de_Pontos
{
    partial class FormListaRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaRegistros));
            this.TituloRegistros = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.campoId = new System.Windows.Forms.Label();
            this.durExpediente = new System.Windows.Forms.Label();
            this.DurIntervalo = new System.Windows.Forms.Label();
            this.CampoSaida = new System.Windows.Forms.Label();
            this.campoFimIntervalo = new System.Windows.Forms.Label();
            this.CampoIntervalo = new System.Windows.Forms.Label();
            this.campoEntrada = new System.Windows.Forms.Label();
            this.campoData = new System.Windows.Forms.Label();
            this.campoNomeFuncionario = new System.Windows.Forms.Label();
            this.painelListagem = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFiltroNome = new System.Windows.Forms.Panel();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.iconBusca = new System.Windows.Forms.PictureBox();
            this.pnlFiltroData = new System.Windows.Forms.Panel();
            this.inputData = new System.Windows.Forms.DateTimePicker();
            this.iconData = new System.Windows.Forms.PictureBox();
            this.pnlFiltroHora = new System.Windows.Forms.Panel();
            this.inputHora = new System.Windows.Forms.DateTimePicker();
            this.iconHora = new System.Windows.Forms.PictureBox();
            this.aplicarFiltros = new MetroFramework.Controls.MetroButton();
            this.iconLimparFiltro = new System.Windows.Forms.PictureBox();
            this.pnlPorPeriodo = new System.Windows.Forms.Panel();
            this.ate = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Label();
            this.lblporPeriodo = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFiltroNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBusca)).BeginInit();
            this.pnlFiltroData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconData)).BeginInit();
            this.pnlFiltroHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLimparFiltro)).BeginInit();
            this.pnlPorPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloRegistros
            // 
            this.TituloRegistros.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloRegistros.Location = new System.Drawing.Point(1, 23);
            this.TituloRegistros.Margin = new System.Windows.Forms.Padding(0);
            this.TituloRegistros.Name = "TituloRegistros";
            this.TituloRegistros.Size = new System.Drawing.Size(265, 33);
            this.TituloRegistros.TabIndex = 0;
            this.TituloRegistros.Text = "PONTOS REGISTRADOS:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.22989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.77012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.campoId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.durExpediente, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.DurIntervalo, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.CampoSaida, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoFimIntervalo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.CampoIntervalo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoEntrada, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoData, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.campoNomeFuncionario, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // campoId
            // 
            this.campoId.AutoSize = true;
            this.campoId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoId.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoId.ForeColor = System.Drawing.Color.MistyRose;
            this.campoId.Location = new System.Drawing.Point(3, 0);
            this.campoId.Name = "campoId";
            this.campoId.Size = new System.Drawing.Size(34, 47);
            this.campoId.TabIndex = 8;
            this.campoId.Text = "ID";
            this.campoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durExpediente
            // 
            this.durExpediente.AutoSize = true;
            this.durExpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durExpediente.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durExpediente.ForeColor = System.Drawing.Color.MistyRose;
            this.durExpediente.Location = new System.Drawing.Point(799, 0);
            this.durExpediente.Name = "durExpediente";
            this.durExpediente.Size = new System.Drawing.Size(108, 47);
            this.durExpediente.TabIndex = 7;
            this.durExpediente.Text = "Duração do Expediente";
            this.durExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurIntervalo
            // 
            this.DurIntervalo.AutoSize = true;
            this.DurIntervalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurIntervalo.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurIntervalo.ForeColor = System.Drawing.Color.MistyRose;
            this.DurIntervalo.Location = new System.Drawing.Point(702, 0);
            this.DurIntervalo.Name = "DurIntervalo";
            this.DurIntervalo.Size = new System.Drawing.Size(91, 47);
            this.DurIntervalo.TabIndex = 6;
            this.DurIntervalo.Text = "Duração do Intervalo";
            this.DurIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CampoSaida
            // 
            this.CampoSaida.AutoSize = true;
            this.CampoSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampoSaida.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoSaida.ForeColor = System.Drawing.Color.MistyRose;
            this.CampoSaida.Location = new System.Drawing.Point(627, 0);
            this.CampoSaida.Name = "CampoSaida";
            this.CampoSaida.Size = new System.Drawing.Size(69, 47);
            this.CampoSaida.TabIndex = 5;
            this.CampoSaida.Text = "Saída";
            this.CampoSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoFimIntervalo
            // 
            this.campoFimIntervalo.AutoSize = true;
            this.campoFimIntervalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoFimIntervalo.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFimIntervalo.ForeColor = System.Drawing.Color.MistyRose;
            this.campoFimIntervalo.Location = new System.Drawing.Point(535, 0);
            this.campoFimIntervalo.Name = "campoFimIntervalo";
            this.campoFimIntervalo.Size = new System.Drawing.Size(86, 47);
            this.campoFimIntervalo.TabIndex = 4;
            this.campoFimIntervalo.Text = "Fim de Intervalo";
            this.campoFimIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CampoIntervalo
            // 
            this.CampoIntervalo.AutoSize = true;
            this.CampoIntervalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampoIntervalo.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoIntervalo.ForeColor = System.Drawing.Color.MistyRose;
            this.CampoIntervalo.Location = new System.Drawing.Point(448, 0);
            this.CampoIntervalo.Name = "CampoIntervalo";
            this.CampoIntervalo.Size = new System.Drawing.Size(81, 47);
            this.CampoIntervalo.TabIndex = 3;
            this.CampoIntervalo.Text = "Início de Intervalo";
            this.CampoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoEntrada
            // 
            this.campoEntrada.AutoSize = true;
            this.campoEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoEntrada.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEntrada.ForeColor = System.Drawing.Color.MistyRose;
            this.campoEntrada.Location = new System.Drawing.Point(368, 0);
            this.campoEntrada.Name = "campoEntrada";
            this.campoEntrada.Size = new System.Drawing.Size(74, 47);
            this.campoEntrada.TabIndex = 2;
            this.campoEntrada.Text = "Entrada";
            this.campoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoData
            // 
            this.campoData.AutoSize = true;
            this.campoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoData.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoData.ForeColor = System.Drawing.Color.MistyRose;
            this.campoData.Location = new System.Drawing.Point(270, 0);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(92, 47);
            this.campoData.TabIndex = 1;
            this.campoData.Text = "Data do Registro";
            this.campoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoNomeFuncionario
            // 
            this.campoNomeFuncionario.AutoSize = true;
            this.campoNomeFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campoNomeFuncionario.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNomeFuncionario.ForeColor = System.Drawing.Color.MistyRose;
            this.campoNomeFuncionario.Location = new System.Drawing.Point(43, 0);
            this.campoNomeFuncionario.Name = "campoNomeFuncionario";
            this.campoNomeFuncionario.Size = new System.Drawing.Size(221, 47);
            this.campoNomeFuncionario.TabIndex = 0;
            this.campoNomeFuncionario.Text = "Funcionário";
            this.campoNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // painelListagem
            // 
            this.painelListagem.AutoScroll = true;
            this.painelListagem.Location = new System.Drawing.Point(6, 151);
            this.painelListagem.Name = "painelListagem";
            this.painelListagem.Size = new System.Drawing.Size(928, 371);
            this.painelListagem.TabIndex = 2;
            // 
            // pnlFiltroNome
            // 
            this.pnlFiltroNome.Controls.Add(this.inputNome);
            this.pnlFiltroNome.Controls.Add(this.iconBusca);
            this.pnlFiltroNome.Location = new System.Drawing.Point(6, 74);
            this.pnlFiltroNome.Name = "pnlFiltroNome";
            this.pnlFiltroNome.Size = new System.Drawing.Size(274, 24);
            this.pnlFiltroNome.TabIndex = 3;
            // 
            // inputNome
            // 
            this.inputNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputNome.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Location = new System.Drawing.Point(0, 0);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(250, 22);
            this.inputNome.TabIndex = 1;
            // 
            // iconBusca
            // 
            this.iconBusca.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBusca.Image = ((System.Drawing.Image)(resources.GetObject("iconBusca.Image")));
            this.iconBusca.Location = new System.Drawing.Point(250, 0);
            this.iconBusca.Name = "iconBusca";
            this.iconBusca.Size = new System.Drawing.Size(24, 24);
            this.iconBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBusca.TabIndex = 0;
            this.iconBusca.TabStop = false;
            // 
            // pnlFiltroData
            // 
            this.pnlFiltroData.Controls.Add(this.inputData);
            this.pnlFiltroData.Controls.Add(this.iconData);
            this.pnlFiltroData.Location = new System.Drawing.Point(298, 74);
            this.pnlFiltroData.Name = "pnlFiltroData";
            this.pnlFiltroData.Size = new System.Drawing.Size(146, 24);
            this.pnlFiltroData.TabIndex = 4;
            // 
            // inputData
            // 
            this.inputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputData.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputData.Location = new System.Drawing.Point(0, 0);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(122, 22);
            this.inputData.TabIndex = 1;
            // 
            // iconData
            // 
            this.iconData.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconData.Image = ((System.Drawing.Image)(resources.GetObject("iconData.Image")));
            this.iconData.Location = new System.Drawing.Point(122, 0);
            this.iconData.Name = "iconData";
            this.iconData.Size = new System.Drawing.Size(24, 24);
            this.iconData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconData.TabIndex = 0;
            this.iconData.TabStop = false;
            // 
            // pnlFiltroHora
            // 
            this.pnlFiltroHora.Controls.Add(this.inputHora);
            this.pnlFiltroHora.Controls.Add(this.iconHora);
            this.pnlFiltroHora.Location = new System.Drawing.Point(466, 74);
            this.pnlFiltroHora.Name = "pnlFiltroHora";
            this.pnlFiltroHora.Size = new System.Drawing.Size(106, 24);
            this.pnlFiltroHora.TabIndex = 4;
            // 
            // inputHora
            // 
            this.inputHora.CustomFormat = "HH:mm";
            this.inputHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputHora.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputHora.Location = new System.Drawing.Point(0, 0);
            this.inputHora.Name = "inputHora";
            this.inputHora.ShowUpDown = true;
            this.inputHora.Size = new System.Drawing.Size(82, 22);
            this.inputHora.TabIndex = 2;
            // 
            // iconHora
            // 
            this.iconHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconHora.Image = ((System.Drawing.Image)(resources.GetObject("iconHora.Image")));
            this.iconHora.Location = new System.Drawing.Point(82, 0);
            this.iconHora.Name = "iconHora";
            this.iconHora.Size = new System.Drawing.Size(24, 24);
            this.iconHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHora.TabIndex = 0;
            this.iconHora.TabStop = false;
            // 
            // aplicarFiltros
            // 
            this.aplicarFiltros.BackColor = System.Drawing.Color.OrangeRed;
            this.aplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.aplicarFiltros.Location = new System.Drawing.Point(595, 68);
            this.aplicarFiltros.Name = "aplicarFiltros";
            this.aplicarFiltros.Size = new System.Drawing.Size(227, 30);
            this.aplicarFiltros.TabIndex = 5;
            this.aplicarFiltros.Text = "APLICAR FILTROS";
            this.aplicarFiltros.UseCustomBackColor = true;
            this.aplicarFiltros.UseCustomForeColor = true;
            this.aplicarFiltros.UseSelectable = true;
            // 
            // iconLimparFiltro
            // 
            this.iconLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLimparFiltro.Image = ((System.Drawing.Image)(resources.GetObject("iconLimparFiltro.Image")));
            this.iconLimparFiltro.Location = new System.Drawing.Point(886, 68);
            this.iconLimparFiltro.Name = "iconLimparFiltro";
            this.iconLimparFiltro.Size = new System.Drawing.Size(30, 30);
            this.iconLimparFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLimparFiltro.TabIndex = 6;
            this.iconLimparFiltro.TabStop = false;
            // 
            // pnlPorPeriodo
            // 
            this.pnlPorPeriodo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPorPeriodo.Controls.Add(this.ate);
            this.pnlPorPeriodo.Controls.Add(this.de);
            this.pnlPorPeriodo.Controls.Add(this.lblporPeriodo);
            this.pnlPorPeriodo.Controls.Add(this.dataFim);
            this.pnlPorPeriodo.Controls.Add(this.dataInicio);
            this.pnlPorPeriodo.Location = new System.Drawing.Point(595, 4);
            this.pnlPorPeriodo.Name = "pnlPorPeriodo";
            this.pnlPorPeriodo.Size = new System.Drawing.Size(321, 61);
            this.pnlPorPeriodo.TabIndex = 7;
            // 
            // ate
            // 
            this.ate.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ate.ForeColor = System.Drawing.Color.OrangeRed;
            this.ate.Location = new System.Drawing.Point(159, 31);
            this.ate.Name = "ate";
            this.ate.Size = new System.Drawing.Size(36, 24);
            this.ate.TabIndex = 6;
            this.ate.Text = "até";
            // 
            // de
            // 
            this.de.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.ForeColor = System.Drawing.Color.OrangeRed;
            this.de.Location = new System.Drawing.Point(3, 30);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(28, 24);
            this.de.TabIndex = 5;
            this.de.Text = "de";
            // 
            // lblporPeriodo
            // 
            this.lblporPeriodo.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporPeriodo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblporPeriodo.Location = new System.Drawing.Point(37, 0);
            this.lblporPeriodo.Name = "lblporPeriodo";
            this.lblporPeriodo.Size = new System.Drawing.Size(280, 27);
            this.lblporPeriodo.TabIndex = 4;
            this.lblporPeriodo.Text = "Filtrar por período:";
            // 
            // dataFim
            // 
            this.dataFim.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataFim.Location = new System.Drawing.Point(201, 30);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(116, 21);
            this.dataFim.TabIndex = 3;
            // 
            // dataInicio
            // 
            this.dataInicio.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInicio.Location = new System.Drawing.Point(37, 31);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(116, 21);
            this.dataInicio.TabIndex = 2;
            // 
            // FormListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.pnlPorPeriodo);
            this.Controls.Add(this.iconLimparFiltro);
            this.Controls.Add(this.aplicarFiltros);
            this.Controls.Add(this.pnlFiltroHora);
            this.Controls.Add(this.pnlFiltroData);
            this.Controls.Add(this.pnlFiltroNome);
            this.Controls.Add(this.painelListagem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TituloRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaRegistros";
            this.Text = "FormRegistros";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFiltroNome.ResumeLayout(false);
            this.pnlFiltroNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBusca)).EndInit();
            this.pnlFiltroData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconData)).EndInit();
            this.pnlFiltroHora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLimparFiltro)).EndInit();
            this.pnlPorPeriodo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TituloRegistros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label campoNomeFuncionario;
        private System.Windows.Forms.Label campoData;
        private System.Windows.Forms.Label campoEntrada;
        private System.Windows.Forms.Label CampoIntervalo;
        private System.Windows.Forms.Label campoFimIntervalo;
        private System.Windows.Forms.Label CampoSaida;
        private System.Windows.Forms.Label DurIntervalo;
        private System.Windows.Forms.Label durExpediente;
        private System.Windows.Forms.FlowLayoutPanel painelListagem;
        private System.Windows.Forms.Label campoId;
        private System.Windows.Forms.Panel pnlFiltroNome;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.PictureBox iconBusca;
        private System.Windows.Forms.Panel pnlFiltroData;
        private System.Windows.Forms.PictureBox iconData;
        private System.Windows.Forms.Panel pnlFiltroHora;
        private System.Windows.Forms.PictureBox iconHora;
        private System.Windows.Forms.DateTimePicker inputData;
        private MetroFramework.Controls.MetroButton aplicarFiltros;
        private System.Windows.Forms.PictureBox iconLimparFiltro;
        private System.Windows.Forms.Panel pnlPorPeriodo;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label de;
        private System.Windows.Forms.Label lblporPeriodo;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.Label ate;
        private System.Windows.Forms.DateTimePicker inputHora;
    }
}