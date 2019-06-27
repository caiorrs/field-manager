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
            this.label1.Location = new System.Drawing.Point(65, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digamos que aqui seja a UI do nosso programa";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btn_CortarAgora
            // 
            this.btn_CortarAgora.Location = new System.Drawing.Point(679, 377);
            this.btn_CortarAgora.Name = "btn_CortarAgora";
            this.btn_CortarAgora.Size = new System.Drawing.Size(109, 49);
            this.btn_CortarAgora.TabIndex = 2;
            this.btn_CortarAgora.Text = "Cortar Agora";
            this.btn_CortarAgora.UseVisualStyleBackColor = true;
            // 
            // btn_agendarCorte
            // 
            this.btn_agendarCorte.Location = new System.Drawing.Point(553, 377);
            this.btn_agendarCorte.Name = "btn_agendarCorte";
            this.btn_agendarCorte.Size = new System.Drawing.Size(109, 49);
            this.btn_agendarCorte.TabIndex = 3;
            this.btn_agendarCorte.Text = "Agendar Corte";
            this.btn_agendarCorte.UseVisualStyleBackColor = true;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(431, 377);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(103, 49);
            this.btnConfigurar.TabIndex = 6;
            this.btnConfigurar.Text = "Configurar sistema";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            // 
            // TESTEUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btn_agendarCorte);
            this.Controls.Add(this.btn_CortarAgora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TESTEUI";
            this.Text = "TESTEUI";
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