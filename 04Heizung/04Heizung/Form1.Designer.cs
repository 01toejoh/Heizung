namespace _04Heizung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.trb_Heizung1 = new System.Windows.Forms.TrackBar();
            this.trb_Heizung2 = new System.Windows.Forms.TrackBar();
            this.trb_Heizung3 = new System.Windows.Forms.TrackBar();
            this.lbl_Value1 = new System.Windows.Forms.Label();
            this.lbl_Value2 = new System.Windows.Forms.Label();
            this.lbl_Value3 = new System.Windows.Forms.Label();
            this.lbl_Farbe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung3)).BeginInit();
            this.SuspendLayout();
            // 
            // trb_Heizung1
            // 
            this.trb_Heizung1.Location = new System.Drawing.Point(54, 51);
            this.trb_Heizung1.Maximum = 30;
            this.trb_Heizung1.Minimum = 5;
            this.trb_Heizung1.Name = "trb_Heizung1";
            this.trb_Heizung1.Size = new System.Drawing.Size(239, 45);
            this.trb_Heizung1.TabIndex = 0;
            this.trb_Heizung1.Value = 5;
            this.trb_Heizung1.Scroll += new System.EventHandler(this.trb_Heizung1_Scroll);
            // 
            // trb_Heizung2
            // 
            this.trb_Heizung2.Location = new System.Drawing.Point(54, 136);
            this.trb_Heizung2.Maximum = 30;
            this.trb_Heizung2.Minimum = 5;
            this.trb_Heizung2.Name = "trb_Heizung2";
            this.trb_Heizung2.Size = new System.Drawing.Size(239, 45);
            this.trb_Heizung2.TabIndex = 1;
            this.trb_Heizung2.Value = 5;
            this.trb_Heizung2.Scroll += new System.EventHandler(this.trb_Heizung2_Scroll);
            // 
            // trb_Heizung3
            // 
            this.trb_Heizung3.Location = new System.Drawing.Point(54, 237);
            this.trb_Heizung3.Maximum = 30;
            this.trb_Heizung3.Minimum = 5;
            this.trb_Heizung3.Name = "trb_Heizung3";
            this.trb_Heizung3.Size = new System.Drawing.Size(239, 45);
            this.trb_Heizung3.TabIndex = 2;
            this.trb_Heizung3.Value = 5;
            this.trb_Heizung3.Scroll += new System.EventHandler(this.trb_Heizung3_Scroll);
            // 
            // lbl_Value1
            // 
            this.lbl_Value1.AutoSize = true;
            this.lbl_Value1.Location = new System.Drawing.Point(125, 12);
            this.lbl_Value1.Name = "lbl_Value1";
            this.lbl_Value1.Size = new System.Drawing.Size(55, 13);
            this.lbl_Value1.TabIndex = 3;
            this.lbl_Value1.Text = "Heizung 1";
            // 
            // lbl_Value2
            // 
            this.lbl_Value2.AutoSize = true;
            this.lbl_Value2.Location = new System.Drawing.Point(125, 99);
            this.lbl_Value2.Name = "lbl_Value2";
            this.lbl_Value2.Size = new System.Drawing.Size(55, 13);
            this.lbl_Value2.TabIndex = 4;
            this.lbl_Value2.Text = "Heizung 2";
            // 
            // lbl_Value3
            // 
            this.lbl_Value3.AutoSize = true;
            this.lbl_Value3.Location = new System.Drawing.Point(125, 203);
            this.lbl_Value3.Name = "lbl_Value3";
            this.lbl_Value3.Size = new System.Drawing.Size(55, 13);
            this.lbl_Value3.TabIndex = 5;
            this.lbl_Value3.Text = "Heizung 3";
            // 
            // lbl_Farbe
            // 
            this.lbl_Farbe.AutoSize = true;
            this.lbl_Farbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Farbe.Location = new System.Drawing.Point(151, 303);
            this.lbl_Farbe.Name = "lbl_Farbe";
            this.lbl_Farbe.Size = new System.Drawing.Size(40, 39);
            this.lbl_Farbe.TabIndex = 6;
            this.lbl_Farbe.Text = "█";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Farbe);
            this.Controls.Add(this.lbl_Value3);
            this.Controls.Add(this.lbl_Value2);
            this.Controls.Add(this.lbl_Value1);
            this.Controls.Add(this.trb_Heizung3);
            this.Controls.Add(this.trb_Heizung2);
            this.Controls.Add(this.trb_Heizung1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Heizung3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trb_Heizung1;
        private System.Windows.Forms.TrackBar trb_Heizung2;
        private System.Windows.Forms.TrackBar trb_Heizung3;
        private System.Windows.Forms.Label lbl_Value1;
        private System.Windows.Forms.Label lbl_Value2;
        private System.Windows.Forms.Label lbl_Value3;
        private System.Windows.Forms.Label lbl_Farbe;
        private System.Windows.Forms.Label label1;
    }
}

