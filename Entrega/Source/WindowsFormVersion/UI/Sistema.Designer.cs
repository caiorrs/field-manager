namespace WindowsFormVersion.Servidor_Central
{
    partial class SistemaUI
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
            this.btn_CortarAgora = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CortarAgora
            // 
            this.btn_CortarAgora.Location = new System.Drawing.Point(23, 118);
            this.btn_CortarAgora.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CortarAgora.Name = "btn_CortarAgora";
            this.btn_CortarAgora.Size = new System.Drawing.Size(145, 60);
            this.btn_CortarAgora.TabIndex = 2;
            this.btn_CortarAgora.Text = "Cortar Agora";
            this.btn_CortarAgora.UseVisualStyleBackColor = true;
            this.btn_CortarAgora.Click += new System.EventHandler(this.Btn_CortarAgora_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(23, 38);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(145, 60);
            this.btnConfigurar.TabIndex = 6;
            this.btnConfigurar.Text = "Configurar sistema";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            // 
            // SistemaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 209);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btn_CortarAgora);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaUI";
            this.Text = "SistemaUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TESTEUI_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.TESTEUI_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CortarAgora;
        private System.Windows.Forms.Button btnConfigurar;
    }
}