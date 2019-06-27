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
            this.textoTituloConfiguracoes = new System.Windows.Forms.Label();
            this.textoUmidadeMin = new System.Windows.Forms.Label();
            this.alturaCorteConf = new System.Windows.Forms.TrackBar();
            this.textoAlturaGrama = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.valorUmidadeMin = new System.Windows.Forms.Label();
            this.valorAlturaCorte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMinConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCorteConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // umidadeMinConf
            // 
            this.umidadeMinConf.Location = new System.Drawing.Point(50, 137);
            this.umidadeMinConf.Margin = new System.Windows.Forms.Padding(4);
            this.umidadeMinConf.Maximum = 100;
            this.umidadeMinConf.Name = "umidadeMinConf";
            this.umidadeMinConf.Size = new System.Drawing.Size(313, 56);
            this.umidadeMinConf.TabIndex = 1;
            this.umidadeMinConf.ValueChanged += new System.EventHandler(this.UmidadeMinConf_Scroll);
            // 
            // textoTituloConfiguracoes
            // 
            this.textoTituloConfiguracoes.AutoSize = true;
            this.textoTituloConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textoTituloConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTituloConfiguracoes.Location = new System.Drawing.Point(90, 23);
            this.textoTituloConfiguracoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textoTituloConfiguracoes.Name = "textoTituloConfiguracoes";
            this.textoTituloConfiguracoes.Size = new System.Drawing.Size(237, 39);
            this.textoTituloConfiguracoes.TabIndex = 3;
            this.textoTituloConfiguracoes.Text = "Configurações";
            // 
            // textoUmidadeMin
            // 
            this.textoUmidadeMin.AutoSize = true;
            this.textoUmidadeMin.Location = new System.Drawing.Point(151, 85);
            this.textoUmidadeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textoUmidadeMin.Name = "textoUmidadeMin";
            this.textoUmidadeMin.Size = new System.Drawing.Size(138, 17);
            this.textoUmidadeMin.TabIndex = 4;
            this.textoUmidadeMin.Text = "Umidade Mínima (%)";
            // 
            // alturaCorteConf
            // 
            this.alturaCorteConf.Location = new System.Drawing.Point(53, 349);
            this.alturaCorteConf.Margin = new System.Windows.Forms.Padding(4);
            this.alturaCorteConf.Maximum = 50;
            this.alturaCorteConf.Minimum = 5;
            this.alturaCorteConf.Name = "alturaCorteConf";
            this.alturaCorteConf.Size = new System.Drawing.Size(313, 56);
            this.alturaCorteConf.TabIndex = 6;
            this.alturaCorteConf.Value = 5;
            this.alturaCorteConf.ValueChanged += new System.EventHandler(this.AlturaCorteConf_Scroll);
            // 
            // textoAlturaGrama
            // 
            this.textoAlturaGrama.AutoSize = true;
            this.textoAlturaGrama.Location = new System.Drawing.Point(110, 295);
            this.textoAlturaGrama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textoAlturaGrama.Name = "textoAlturaGrama";
            this.textoAlturaGrama.Size = new System.Drawing.Size(206, 17);
            this.textoAlturaGrama.TabIndex = 7;
            this.textoAlturaGrama.Text = "Altura de Corte da Grama (mm)";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(216, 434);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // valorUmidadeMin
            // 
            this.valorUmidadeMin.AutoSize = true;
            this.valorUmidadeMin.Location = new System.Drawing.Point(191, 116);
            this.valorUmidadeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorUmidadeMin.Name = "valorUmidadeMin";
            this.valorUmidadeMin.Size = new System.Drawing.Size(32, 17);
            this.valorUmidadeMin.TabIndex = 9;
            this.valorUmidadeMin.Text = "MIN";
            this.valorUmidadeMin.Click += new System.EventHandler(this.ValorUmidadeMin_Click);
            // 
            // valorAlturaCorte
            // 
            this.valorAlturaCorte.AutoSize = true;
            this.valorAlturaCorte.Location = new System.Drawing.Point(194, 328);
            this.valorAlturaCorte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorAlturaCorte.Name = "valorAlturaCorte";
            this.valorAlturaCorte.Size = new System.Drawing.Size(34, 17);
            this.valorAlturaCorte.TabIndex = 11;
            this.valorAlturaCorte.Text = "ALT";
            this.valorAlturaCorte.Click += new System.EventHandler(this.ValorAlturaCorte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Umidade Ideal (%)";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 228);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(313, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.valorAlturaCorte);
            this.Controls.Add(this.valorUmidadeMin);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textoAlturaGrama);
            this.Controls.Add(this.alturaCorteConf);
            this.Controls.Add(this.textoUmidadeMin);
            this.Controls.Add(this.textoTituloConfiguracoes);
            this.Controls.Add(this.umidadeMinConf);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.Shown += new System.EventHandler(this.Configuracoes_Shown);
            this.VisibleChanged += new System.EventHandler(this.Configuracoes_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.umidadeMinConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCorteConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Label textoTituloConfiguracoes;
        private System.Windows.Forms.Label textoUmidadeMin;
        private System.Windows.Forms.TrackBar alturaCorteConf;
        private System.Windows.Forms.Label textoAlturaGrama;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label valorUmidadeMin;
        private System.Windows.Forms.Label valorAlturaCorte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
    }
}