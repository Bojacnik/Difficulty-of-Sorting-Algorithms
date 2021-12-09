
namespace SamostatnaPrace
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
            this.btnLaunchExcel = new System.Windows.Forms.Button();
            this.btnDrawGraphDifficulty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunchExcel
            // 
            this.btnLaunchExcel.Location = new System.Drawing.Point(12, 12);
            this.btnLaunchExcel.Name = "btnLaunchExcel";
            this.btnLaunchExcel.Size = new System.Drawing.Size(189, 72);
            this.btnLaunchExcel.TabIndex = 0;
            this.btnLaunchExcel.Text = "Spusť Excel";
            this.btnLaunchExcel.UseVisualStyleBackColor = true;
            this.btnLaunchExcel.Click += new System.EventHandler(this.btnLaunchExcel_Click);
            // 
            // btnDrawGraphDifficulty
            // 
            this.btnDrawGraphDifficulty.Enabled = false;
            this.btnDrawGraphDifficulty.Location = new System.Drawing.Point(12, 90);
            this.btnDrawGraphDifficulty.Name = "btnDrawGraphDifficulty";
            this.btnDrawGraphDifficulty.Size = new System.Drawing.Size(189, 68);
            this.btnDrawGraphDifficulty.TabIndex = 5;
            this.btnDrawGraphDifficulty.Text = "Vykresli graf složitosti";
            this.btnDrawGraphDifficulty.UseVisualStyleBackColor = true;
            this.btnDrawGraphDifficulty.Click += new System.EventHandler(this.btnDrawGraphDifficulty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 170);
            this.Controls.Add(this.btnDrawGraphDifficulty);
            this.Controls.Add(this.btnLaunchExcel);
            this.Name = "Form1";
            this.Text = "Difficulty Graph";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchExcel;
        private System.Windows.Forms.Button btnDrawGraphDifficulty;
    }
}

