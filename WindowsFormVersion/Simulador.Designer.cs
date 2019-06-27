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
            this.gbTempo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(235, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Altura atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.umidadeTrackBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(285, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Umidade";
            // 
            // umidadeTrackBar
            // 
            this.umidadeTrackBar.LargeChange = 50;
            this.umidadeTrackBar.Location = new System.Drawing.Point(6, 19);
            this.umidadeTrackBar.Maximum = 500;
            this.umidadeTrackBar.Name = "umidadeTrackBar";
            this.umidadeTrackBar.Size = new System.Drawing.Size(235, 45);
            this.umidadeTrackBar.TabIndex = 0;
            this.umidadeTrackBar.ValueChanged += new System.EventHandler(this.UmidadeTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Umidade atual";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // gb_Grama
            // 
            this.gb_Grama.Controls.Add(this.groupBox1);
            this.gb_Grama.Controls.Add(this.groupBox2);
            this.gb_Grama.Location = new System.Drawing.Point(12, 12);
            this.gb_Grama.Name = "gb_Grama";
            this.gb_Grama.Size = new System.Drawing.Size(551, 214);
            this.gb_Grama.TabIndex = 7;
            this.gb_Grama.TabStop = false;
            this.gb_Grama.Text = "Grama";
            // 
            // gbChuva
            // 
            this.gbChuva.Controls.Add(this.checkBox1);
            this.gbChuva.Location = new System.Drawing.Point(13, 233);
            this.gbChuva.Name = "gbChuva";
            this.gbChuva.Size = new System.Drawing.Size(265, 100);
            this.gbChuva.TabIndex = 8;
            this.gbChuva.TabStop = false;
            this.gbChuva.Text = "Chuva";
            // 
            // gbTempo
            // 
            this.gbTempo.Controls.Add(this.label3);
            this.gbTempo.Controls.Add(this.label4);
            this.gbTempo.Location = new System.Drawing.Point(297, 233);
            this.gbTempo.Name = "gbTempo";
            this.gbTempo.Size = new System.Drawing.Size(266, 100);
            this.gbTempo.TabIndex = 9;
            this.gbTempo.TabStop = false;
            this.gbTempo.Text = "Tempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hora agora:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Está chovendo?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "mostra a hora, (data.ToString()) atual do sistema, chama tipo Natureza.Tempo.Inst" +
    "ance.Now()";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 343);
            this.Controls.Add(this.gbTempo);
            this.Controls.Add(this.gbChuva);
            this.Controls.Add(this.gb_Grama);
            this.Name = "Simulador";
            this.Text = "Simulador da natureza";
            this.Load += new System.EventHandler(this.Form1_Load);
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

