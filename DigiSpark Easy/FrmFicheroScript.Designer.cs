namespace DigiSpark_Easy
{
    partial class FrmFicheroScript
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
            this.lblurlfichero = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblurlfichero
            // 
            this.lblurlfichero.AutoSize = true;
            this.lblurlfichero.Location = new System.Drawing.Point(12, 28);
            this.lblurlfichero.Name = "lblurlfichero";
            this.lblurlfichero.Size = new System.Drawing.Size(70, 13);
            this.lblurlfichero.TabIndex = 0;
            this.lblurlfichero.Text = "URL Fichero:";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(88, 26);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(390, 20);
            this.txturl.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::DigiSpark_Easy.Properties.Resources.accept_circular_button_outline__1_;
            this.btnAceptar.Location = new System.Drawing.Point(181, 57);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(64, 64);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::DigiSpark_Easy.Properties.Resources.round_delete_button__1_;
            this.btnCancelar.Location = new System.Drawing.Point(251, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 64);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmFicheroScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 140);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurlfichero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmFicheroScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFicheroScript";
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblurlfichero;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.PictureBox btnCancelar;
    }
}