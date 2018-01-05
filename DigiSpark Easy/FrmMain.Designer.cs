namespace DigiSpark_Easy
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnDelay = new System.Windows.Forms.Button();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnString = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnGUI = new System.Windows.Forms.Button();
            this.btnGUId = new System.Windows.Forms.Button();
            this.btnGUIr = new System.Windows.Forms.Button();
            this.btnGUIx = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnEspacio = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.txtDefiniciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelayDefault = new System.Windows.Forms.TextBox();
            this.btnDelayDefault = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(12, 12);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScript.Size = new System.Drawing.Size(549, 552);
            this.txtScript.TabIndex = 0;
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(568, 13);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(75, 23);
            this.btnDelay.TabIndex = 1;
            this.btnDelay.Text = "Delay";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(649, 15);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 20);
            this.txtDelay.TabIndex = 2;
            this.txtDelay.Text = "0";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(649, 67);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(174, 78);
            this.txtString.TabIndex = 4;
            this.txtString.Text = "Texto por defecto";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(568, 65);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 3;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnGUI);
            this.grp1.Controls.Add(this.btnGUId);
            this.grp1.Controls.Add(this.btnGUIr);
            this.grp1.Controls.Add(this.btnGUIx);
            this.grp1.Location = new System.Drawing.Point(568, 151);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(300, 54);
            this.grp1.TabIndex = 5;
            this.grp1.TabStop = false;
            this.grp1.Text = "GUI (CNTRL+)";
            // 
            // btnGUI
            // 
            this.btnGUI.Location = new System.Drawing.Point(6, 19);
            this.btnGUI.Name = "btnGUI";
            this.btnGUI.Size = new System.Drawing.Size(67, 23);
            this.btnGUI.TabIndex = 3;
            this.btnGUI.Tag = "0";
            this.btnGUI.Text = "GUI";
            this.btnGUI.UseVisualStyleBackColor = true;
            this.btnGUI.Click += new System.EventHandler(this.btnGUIx_Click_1);
            // 
            // btnGUId
            // 
            this.btnGUId.Location = new System.Drawing.Point(225, 19);
            this.btnGUId.Name = "btnGUId";
            this.btnGUId.Size = new System.Drawing.Size(67, 23);
            this.btnGUId.TabIndex = 2;
            this.btnGUId.Tag = "KEY_D";
            this.btnGUId.Text = "D";
            this.btnGUId.UseVisualStyleBackColor = true;
            this.btnGUId.Click += new System.EventHandler(this.btnGUIx_Click_1);
            // 
            // btnGUIr
            // 
            this.btnGUIr.Location = new System.Drawing.Point(152, 19);
            this.btnGUIr.Name = "btnGUIr";
            this.btnGUIr.Size = new System.Drawing.Size(67, 23);
            this.btnGUIr.TabIndex = 1;
            this.btnGUIr.Tag = "KEY_R";
            this.btnGUIr.Text = "R";
            this.btnGUIr.UseVisualStyleBackColor = true;
            this.btnGUIr.Click += new System.EventHandler(this.btnGUIx_Click_1);
            // 
            // btnGUIx
            // 
            this.btnGUIx.Location = new System.Drawing.Point(79, 19);
            this.btnGUIx.Name = "btnGUIx";
            this.btnGUIx.Size = new System.Drawing.Size(67, 23);
            this.btnGUIx.TabIndex = 0;
            this.btnGUIx.Tag = "KEY_X";
            this.btnGUIx.Text = "X";
            this.btnGUIx.UseVisualStyleBackColor = true;
            this.btnGUIx.Click += new System.EventHandler(this.btnGUIx_Click_1);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.button1);
            this.grp2.Controls.Add(this.btnDer);
            this.grp2.Controls.Add(this.btnTab);
            this.grp2.Controls.Add(this.btnDelete);
            this.grp2.Controls.Add(this.btnAbajo);
            this.grp2.Controls.Add(this.btnArriba);
            this.grp2.Controls.Add(this.btnEspacio);
            this.grp2.Controls.Add(this.btnEnter);
            this.grp2.Controls.Add(this.btnIzq);
            this.grp2.Location = new System.Drawing.Point(599, 211);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(224, 147);
            this.grp2.TabIndex = 6;
            this.grp2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 12;
            this.button1.Tag = "KEY_F4";
            this.button1.Text = "Alt+F4";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDer
            // 
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(151, 61);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(67, 36);
            this.btnDer.TabIndex = 11;
            this.btnDer.Tag = "KEY_RIGHTARROW";
            this.btnDer.Text = "→";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(8, 19);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(67, 36);
            this.btnTab.TabIndex = 10;
            this.btnTab.Tag = "KEY_TAB";
            this.btnTab.Text = "TAB";
            this.btnTab.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(151, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Tag = "KEY_DELETE";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAbajo
            // 
            this.btnAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbajo.Location = new System.Drawing.Point(81, 103);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(67, 36);
            this.btnAbajo.TabIndex = 8;
            this.btnAbajo.Tag = "KEY_DOWNARROW";
            this.btnAbajo.Text = "↓";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArriba.Location = new System.Drawing.Point(79, 19);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(67, 36);
            this.btnArriba.TabIndex = 7;
            this.btnArriba.Tag = "KEY_UP";
            this.btnArriba.Text = "↑";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnEspacio
            // 
            this.btnEspacio.Location = new System.Drawing.Point(79, 61);
            this.btnEspacio.Name = "btnEspacio";
            this.btnEspacio.Size = new System.Drawing.Size(67, 36);
            this.btnEspacio.TabIndex = 6;
            this.btnEspacio.Tag = "KEY_SPACE";
            this.btnEspacio.Text = "SPACE";
            this.btnEspacio.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(8, 103);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(67, 36);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Tag = "KEY_ENTER";
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnIzq
            // 
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.Location = new System.Drawing.Point(8, 61);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(67, 36);
            this.btnIzq.TabIndex = 4;
            this.btnIzq.Tag = "KEY_LEFTARROW";
            this.btnIzq.Text = "←";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // txtDefiniciones
            // 
            this.txtDefiniciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefiniciones.Location = new System.Drawing.Point(568, 389);
            this.txtDefiniciones.Multiline = true;
            this.txtDefiniciones.Name = "txtDefiniciones";
            this.txtDefiniciones.Size = new System.Drawing.Size(300, 175);
            this.txtDefiniciones.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "#define";
            // 
            // txtDelayDefault
            // 
            this.txtDelayDefault.Location = new System.Drawing.Point(664, 41);
            this.txtDelayDefault.Name = "txtDelayDefault";
            this.txtDelayDefault.Size = new System.Drawing.Size(100, 20);
            this.txtDelayDefault.TabIndex = 10;
            this.txtDelayDefault.Text = "0";
            // 
            // btnDelayDefault
            // 
            this.btnDelayDefault.Enabled = false;
            this.btnDelayDefault.Location = new System.Drawing.Point(568, 39);
            this.btnDelayDefault.Name = "btnDelayDefault";
            this.btnDelayDefault.Size = new System.Drawing.Size(90, 23);
            this.btnDelayDefault.TabIndex = 9;
            this.btnDelayDefault.Text = "Delay default";
            this.btnDelayDefault.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 577);
            this.Controls.Add(this.txtDelayDefault);
            this.Controls.Add(this.btnDelayDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDefiniciones);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.txtScript);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "DigiSpark Easy";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grp1.ResumeLayout(false);
            this.grp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button btnGUI;
        private System.Windows.Forms.Button btnGUId;
        private System.Windows.Forms.Button btnGUIr;
        private System.Windows.Forms.Button btnGUIx;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnEspacio;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.TextBox txtDefiniciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDelayDefault;
        private System.Windows.Forms.Button btnDelayDefault;
    }
}

