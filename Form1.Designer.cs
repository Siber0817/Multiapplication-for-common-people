namespace MultiApka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttoncoffein = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncoffein
            // 
            this.buttoncoffein.Location = new System.Drawing.Point(38, 54);
            this.buttoncoffein.Name = "buttoncoffein";
            this.buttoncoffein.Size = new System.Drawing.Size(254, 113);
            this.buttoncoffein.TabIndex = 0;
            this.buttoncoffein.Text = "Kofeinová Kalkulačka";
            this.buttoncoffein.UseVisualStyleBackColor = true;
            this.buttoncoffein.Click += new System.EventHandler(this.buttoncoffein_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 113);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kalkulačka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(38, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 113);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dýchací cvičení";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(450, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 113);
            this.button4.TabIndex = 3;
            this.button4.Text = "Placeholder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 434);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttoncoffein);
            this.Name = "Form1";
            this.Text = "MultiApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncoffein;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

