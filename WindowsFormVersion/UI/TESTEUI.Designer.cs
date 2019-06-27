namespace WindowsFormVersion.Servidor_Central
{
    partial class TESTEUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TESTEUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CortarAgora = new System.Windows.Forms.Button();
            this.btn_agendarCorte = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digamos que aqui seja a UI do nosso programa";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(87, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 102);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btn_CortarAgora
            // 
            this.btn_CortarAgora.Location = new System.Drawing.Point(905, 464);
            this.btn_CortarAgora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CortarAgora.Name = "btn_CortarAgora";
            this.btn_CortarAgora.Size = new System.Drawing.Size(145, 60);
            this.btn_CortarAgora.TabIndex = 2;
            this.btn_CortarAgora.Text = "Cortar Agora";
            this.btn_CortarAgora.UseVisualStyleBackColor = true;
            this.btn_CortarAgora.Click += new System.EventHandler(this.Btn_CortarAgora_Click);
            // 
            // btn_agendarCorte
            // 
            this.btn_agendarCorte.Location = new System.Drawing.Point(737, 464);
            this.btn_agendarCorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agendarCorte.Name = "btn_agendarCorte";
            this.btn_agendarCorte.Size = new System.Drawing.Size(145, 60);
            this.btn_agendarCorte.TabIndex = 3;
            this.btn_agendarCorte.Text = "Agendar Corte";
            this.btn_agendarCorte.UseVisualStyleBackColor = true;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(575, 464);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(137, 60);
            this.btnConfigurar.TabIndex = 6;
            this.btnConfigurar.Text = "Configurar sistema";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            // 
            // TESTEUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btn_agendarCorte);
            this.Controls.Add(this.btn_CortarAgora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TESTEUI";
            this.Text = "TESTEUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TESTEUI_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.TESTEUI_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CortarAgora;
        private System.Windows.Forms.Button btn_agendarCorte;
        private System.Windows.Forms.Button btnConfigurar;
    }
}