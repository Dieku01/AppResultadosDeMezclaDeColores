namespace AppResultadosDeMezclaDeColores
{
    partial class frmPrincipal
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
            this.cbColor1 = new System.Windows.Forms.ComboBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.btnMezclar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColorRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbColor1
            // 
            this.cbColor1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor1.FormattingEnabled = true;
            this.cbColor1.Location = new System.Drawing.Point(93, 18);
            this.cbColor1.Name = "cbColor1";
            this.cbColor1.Size = new System.Drawing.Size(224, 25);
            this.cbColor1.TabIndex = 1;
            this.cbColor1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor1_DrawItem);
            this.cbColor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColor1_KeyPress);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(89, 95);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 24);
            this.lblRes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color 2:";
            // 
            // cbColor2
            // 
            this.cbColor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor2.FormattingEnabled = true;
            this.cbColor2.Location = new System.Drawing.Point(93, 59);
            this.cbColor2.Name = "cbColor2";
            this.cbColor2.Size = new System.Drawing.Size(224, 25);
            this.cbColor2.TabIndex = 9;
            this.cbColor2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor2_DrawItem);
            this.cbColor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColor2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color 2:";
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(418, 24);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(0, 20);
            this.lblColor1.TabIndex = 12;
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(418, 61);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(0, 20);
            this.lblColor2.TabIndex = 13;
            // 
            // btnMezclar
            // 
            this.btnMezclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMezclar.Location = new System.Drawing.Point(170, 148);
            this.btnMezclar.Name = "btnMezclar";
            this.btnMezclar.Size = new System.Drawing.Size(147, 32);
            this.btnMezclar.TabIndex = 14;
            this.btnMezclar.Text = "&Obtener mezcla";
            this.btnMezclar.UseVisualStyleBackColor = true;
            this.btnMezclar.Click += new System.EventHandler(this.btnMezclar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mezcla:";
            // 
            // btnColor1
            // 
            this.btnColor1.Enabled = false;
            this.btnColor1.Location = new System.Drawing.Point(323, 19);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(25, 25);
            this.btnColor1.TabIndex = 16;
            this.btnColor1.UseVisualStyleBackColor = true;
            // 
            // btnColor2
            // 
            this.btnColor2.Enabled = false;
            this.btnColor2.Location = new System.Drawing.Point(323, 59);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(25, 25);
            this.btnColor2.TabIndex = 17;
            this.btnColor2.UseVisualStyleBackColor = true;
            // 
            // btnColorRes
            // 
            this.btnColorRes.Enabled = false;
            this.btnColorRes.Location = new System.Drawing.Point(211, 92);
            this.btnColorRes.Name = "btnColorRes";
            this.btnColorRes.Size = new System.Drawing.Size(137, 35);
            this.btnColorRes.TabIndex = 18;
            this.btnColorRes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 205);
            this.Controls.Add(this.btnColorRes);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMezclar);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbColor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.cbColor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "Mezclador colores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbColor1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Button btnMezclar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColorRes;
    }
}

