namespace WindowsFormVersion
{
    partial class Simulador
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.umidadeTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gb_Grama = new System.Windows.Forms.GroupBox();
            this.gbChuva = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbTempo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeTrackBar)).BeginInit();
            this.gb_Grama.SuspendLayout();
            this.gbChuva.SuspendLayout();
            this.gbTempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 23);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(313, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Altura atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(332, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.umidadeTrackBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(380, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(332, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Umidade";
            // 
            // umidadeTrackBar
            // 
            this.umidadeTrackBar.LargeChange = 50;
            this.umidadeTrackBar.Location = new System.Drawing.Point(8, 23);
            this.umidadeTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.umidadeTrackBar.Maximum = 100;
            this.umidadeTrackBar.Name = "umidadeTrackBar";
            this.umidadeTrackBar.Size = new System.Drawing.Size(313, 56);
            this.umidadeTrackBar.TabIndex = 0;
            this.umidadeTrackBar.ValueChanged += new System.EventHandler(this.UmidadeTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Umidade atual";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 137);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // gb_Grama
            // 
            this.gb_Grama.Controls.Add(this.groupBox1);
            this.gb_Grama.Controls.Add(this.groupBox2);
            this.gb_Grama.Location = new System.Drawing.Point(16, 15);
            this.gb_Grama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Grama.Name = "gb_Grama";
            this.gb_Grama.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Grama.Size = new System.Drawing.Size(735, 263);
            this.gb_Grama.TabIndex = 7;
            this.gb_Grama.TabStop = false;
            this.gb_Grama.Text = "Grama";
            // 
            // gbChuva
            // 
            this.gbChuva.Controls.Add(this.checkBox1);
            this.gbChuva.Location = new System.Drawing.Point(17, 287);
            this.gbChuva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChuva.Name = "gbChuva";
            this.gbChuva.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChuva.Size = new System.Drawing.Size(353, 123);
            this.gbChuva.TabIndex = 8;
            this.gbChuva.TabStop = false;
            this.gbChuva.Text = "Chuva";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 54);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Está chovendo?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // gbTempo
            // 
            this.gbTempo.Controls.Add(this.label3);
            this.gbTempo.Controls.Add(this.label4);
            this.gbTempo.Location = new System.Drawing.Point(396, 287);
            this.gbTempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTempo.Name = "gbTempo";
            this.gbTempo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTempo.Size = new System.Drawing.Size(355, 123);
            this.gbTempo.TabIndex = 9;
            this.gbTempo.TabStop = false;
            this.gbTempo.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 52);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hora agora:";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.gbTempo);
            this.Controls.Add(this.gbChuva);
            this.Controls.Add(this.gb_Grama);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simulador";
            this.Text = "Simulador da natureza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulador_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Simulador_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umidadeTrackBar)).EndInit();
            this.gb_Grama.ResumeLayout(false);
            this.gbChuva.ResumeLayout(false);
            this.gbChuva.PerformLayout();
            this.gbTempo.ResumeLayout(false);
            this.gbTempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar umidadeTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gb_Grama;
        private System.Windows.Forms.GroupBox gbChuva;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

