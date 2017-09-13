namespace ValidaUuuiSat
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRfcReceptor = new System.Windows.Forms.TextBox();
            this.txtRfcEmisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCadenaTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Validar UUID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estatus De UUID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estatus...";
            // 
            // txtRfcReceptor
            // 
            this.txtRfcReceptor.Location = new System.Drawing.Point(118, 29);
            this.txtRfcReceptor.Name = "txtRfcReceptor";
            this.txtRfcReceptor.Size = new System.Drawing.Size(100, 20);
            this.txtRfcReceptor.TabIndex = 3;
            this.txtRfcReceptor.Text = "SARM8209281F1";
            // 
            // txtRfcEmisor
            // 
            this.txtRfcEmisor.Location = new System.Drawing.Point(9, 29);
            this.txtRfcEmisor.Name = "txtRfcEmisor";
            this.txtRfcEmisor.Size = new System.Drawing.Size(100, 20);
            this.txtRfcEmisor.TabIndex = 5;
            this.txtRfcEmisor.Text = "BEN9501023I0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RFC RECEPTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL FACTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RFC EMISOR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCadenaTotal
            // 
            this.txtCadenaTotal.Location = new System.Drawing.Point(226, 29);
            this.txtCadenaTotal.Name = "txtCadenaTotal";
            this.txtCadenaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCadenaTotal.TabIndex = 4;
            this.txtCadenaTotal.Text = "440.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "UUID";
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(332, 29);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(232, 20);
            this.txtUUID.TabIndex = 10;
            this.txtUUID.Text = "EC609EC1-5F63-4333-A2B8-2EDC10B68075";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 259);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRfcEmisor);
            this.Controls.Add(this.txtCadenaTotal);
            this.Controls.Add(this.txtRfcReceptor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRfcReceptor;
        private System.Windows.Forms.TextBox txtRfcEmisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCadenaTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUUID;
    }
}

