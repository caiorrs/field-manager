using System;

namespace WindowsFormVersion
{
    partial class Configuracoes
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
            this.umidadeMinConf = new System.Windows.Forms.TrackBar();
            this.umidadeMaxConf = new System.Windows.Forms.TrackBar();
            this.textoTituloConfiguracoes = new System.Windows.Forms.Label();
            this.textoUmidadeMin = new System.Windows.Forms.Label();
            this.textoUmidadeMax = new System.Windows.Forms.Label();
            this.alturaCorteConf = new System.Windows.Forms.TrackBar();
            this.textoAlturaGrama = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.valorUmidadeMin = new System.Windows.Forms.Label();
            this.valorUmidadeMax = new System.Windows.Forms.Label();
            this.valorAlturaCorte = new System.Windows.Forms.Label();
            this.btnFecharConf = new System.Windows.Forms.Button();
            this.listaCidades = new System.Windows.Forms.ComboBox();
            this.listaGramas = new System.Windows.Forms.ComboBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelGrama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMinConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMaxConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCorteConf)).BeginInit();
            this.SuspendLayout();
            // 
            // umidadeMinConf
            // 
            this.umidadeMinConf.LargeChange = 50;
            this.umidadeMinConf.Location = new System.Drawing.Point(35, 147);
            this.umidadeMinConf.Maximum = 100;
            this.umidadeMinConf.Name = "umidadeMinConf";
            this.umidadeMinConf.Size = new System.Drawing.Size(235, 45);
            this.umidadeMinConf.TabIndex = 1;
            this.umidadeMinConf.Scroll += new System.EventHandler(this.UmidadeMinConf_Scroll);
            // 
            // umidadeMaxConf
            // 
            this.umidadeMaxConf.LargeChange = 50;
            this.umidadeMaxConf.Location = new System.Drawing.Point(35, 282);
            this.umidadeMaxConf.Maximum = 100;
            this.umidadeMaxConf.Name = "umidadeMaxConf";
            this.umidadeMaxConf.Size = new System.Drawing.Size(235, 45);
            this.umidadeMaxConf.TabIndex = 2;
            this.umidadeMaxConf.Scroll += new System.EventHandler(this.UmidadeMaxConf_Scroll);
            // 
            // textoTituloConfiguracoes
            // 
            this.textoTituloConfiguracoes.AutoSize = true;
            this.textoTituloConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTituloConfiguracoes.Location = new System.Drawing.Point(289, 23);
            this.textoTituloConfiguracoes.Name = "textoTituloConfiguracoes";
            this.textoTituloConfiguracoes.Size = new System.Drawing.Size(190, 31);
            this.textoTituloConfiguracoes.TabIndex = 3;
            this.textoTituloConfiguracoes.Text = "Configurações";
            // 
            // textoUmidadeMin
            // 
            this.textoUmidadeMin.AutoSize = true;
            this.textoUmidadeMin.Location = new System.Drawing.Point(111, 105);
            this.textoUmidadeMin.Name = "textoUmidadeMin";
            this.textoUmidadeMin.Size = new System.Drawing.Size(104, 13);
            this.textoUmidadeMin.TabIndex = 4;
            this.textoUmidadeMin.Text = "Umidade Mínima (%)";
            // 
            // textoUmidadeMax
            // 
            this.textoUmidadeMax.AutoSize = true;
            this.textoUmidadeMax.Location = new System.Drawing.Point(110, 239);
            this.textoUmidadeMax.Name = "textoUmidadeMax";
            this.textoUmidadeMax.Size = new System.Drawing.Size(105, 13);
            this.textoUmidadeMax.TabIndex = 5;
            this.textoUmidadeMax.Text = "Umidade Máxima (%)";
            // 
            // alturaCorteConf
            // 
            this.alturaCorteConf.LargeChange = 50;
            this.alturaCorteConf.Location = new System.Drawing.Point(478, 147);
            this.alturaCorteConf.Maximum = 50;
            this.alturaCorteConf.Minimum = 5;
            this.alturaCorteConf.Name = "alturaCorteConf";
            this.alturaCorteConf.Size = new System.Drawing.Size(235, 45);
            this.alturaCorteConf.TabIndex = 6;
            this.alturaCorteConf.Value = 5;
            this.alturaCorteConf.Scroll += new System.EventHandler(this.AlturaCorteConf_Scroll);
            // 
            // textoAlturaGrama
            // 
            this.textoAlturaGrama.AutoSize = true;
            this.textoAlturaGrama.Location = new System.Drawing.Point(521, 105);
            this.textoAlturaGrama.Name = "textoAlturaGrama";
            this.textoAlturaGrama.Size = new System.Drawing.Size(151, 13);
            this.textoAlturaGrama.TabIndex = 7;
            this.textoAlturaGrama.Text = "Altura de Corte da Grama (mm)";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(383, 414);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // valorUmidadeMin
            // 
            this.valorUmidadeMin.AutoSize = true;
            this.valorUmidadeMin.Location = new System.Drawing.Point(149, 187);
            this.valorUmidadeMin.Name = "valorUmidadeMin";
            this.valorUmidadeMin.Size = new System.Drawing.Size(10, 13);
            this.valorUmidadeMin.TabIndex = 9;
            this.valorUmidadeMin.Text = ".";
            this.valorUmidadeMin.Click += new System.EventHandler(this.ValorUmidadeMin_Click);
            // 
            // valorUmidadeMax
            // 
            this.valorUmidadeMax.AutoSize = true;
            this.valorUmidadeMax.Location = new System.Drawing.Point(149, 330);
            this.valorUmidadeMax.Name = "valorUmidadeMax";
            this.valorUmidadeMax.Size = new System.Drawing.Size(10, 13);
            this.valorUmidadeMax.TabIndex = 10;
            this.valorUmidadeMax.Text = ".";
            // 
            // valorAlturaCorte
            // 
            this.valorAlturaCorte.AutoSize = true;
            this.valorAlturaCorte.Location = new System.Drawing.Point(592, 195);
            this.valorAlturaCorte.Name = "valorAlturaCorte";
            this.valorAlturaCorte.Size = new System.Drawing.Size(10, 13);
            this.valorAlturaCorte.TabIndex = 11;
            this.valorAlturaCorte.Text = ".";
            this.valorAlturaCorte.Click += new System.EventHandler(this.ValorAlturaCorte_Click);
            // 
            // btnFecharConf
            // 
            this.btnFecharConf.Location = new System.Drawing.Point(295, 415);
            this.btnFecharConf.Name = "btnFecharConf";
            this.btnFecharConf.Size = new System.Drawing.Size(75, 23);
            this.btnFecharConf.TabIndex = 12;
            this.btnFecharConf.Text = "Fechar";
            this.btnFecharConf.UseVisualStyleBackColor = true;
            this.btnFecharConf.Click += new System.EventHandler(this.BtnFecharConf_Click);
            // 
            // listaCidades
            // 
            this.listaCidades.FormattingEnabled = true;
            this.listaCidades.Location = new System.Drawing.Point(524, 249);
            this.listaCidades.Name = "listaCidades";
            this.listaCidades.Size = new System.Drawing.Size(121, 21);
            this.listaCidades.TabIndex = 13;
            this.listaCidades.SelectedIndexChanged += new System.EventHandler(this.ListaCidades_SelectedIndexChanged);
            // 
            // listaGramas
            // 
            this.listaGramas.FormattingEnabled = true;
            this.listaGramas.Location = new System.Drawing.Point(524, 306);
            this.listaGramas.Name = "listaGramas";
            this.listaGramas.Size = new System.Drawing.Size(121, 21);
            this.listaGramas.TabIndex = 14;
            this.listaGramas.SelectedIndexChanged += new System.EventHandler(this.ListaGramas_SelectedIndexChanged);
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(562, 224);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 15;
            this.labelCidade.Text = "Cidade";
            // 
            // labelGrama
            // 
            this.labelGrama.AutoSize = true;
            this.labelGrama.Location = new System.Drawing.Point(549, 282);
            this.labelGrama.Name = "labelGrama";
            this.labelGrama.Size = new System.Drawing.Size(77, 13);
            this.labelGrama.TabIndex = 16;
            this.labelGrama.Text = "Tipo de Grama";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGrama);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.listaGramas);
            this.Controls.Add(this.listaCidades);
            this.Controls.Add(this.btnFecharConf);
            this.Controls.Add(this.valorAlturaCorte);
            this.Controls.Add(this.valorUmidadeMax);
            this.Controls.Add(this.valorUmidadeMin);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textoAlturaGrama);
            this.Controls.Add(this.alturaCorteConf);
            this.Controls.Add(this.textoUmidadeMax);
            this.Controls.Add(this.textoUmidadeMin);
            this.Controls.Add(this.textoTituloConfiguracoes);
            this.Controls.Add(this.umidadeMaxConf);
            this.Controls.Add(this.umidadeMinConf);
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMinConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMaxConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCorteConf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ListaGramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListaCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TrackBar umidadeMinConf;
        private System.Windows.Forms.TrackBar umidadeMaxConf;
        private System.Windows.Forms.Label textoTituloConfiguracoes;
        private System.Windows.Forms.Label textoUmidadeMin;
        private System.Windows.Forms.Label textoUmidadeMax;
        private System.Windows.Forms.TrackBar alturaCorteConf;
        private System.Windows.Forms.Label textoAlturaGrama;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label valorUmidadeMin;
        private System.Windows.Forms.Label valorUmidadeMax;
        private System.Windows.Forms.Label valorAlturaCorte;
        private System.Windows.Forms.Button btnFecharConf;
        private System.Windows.Forms.ComboBox listaCidades;
        private System.Windows.Forms.ComboBox listaGramas;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelGrama;
    }
}