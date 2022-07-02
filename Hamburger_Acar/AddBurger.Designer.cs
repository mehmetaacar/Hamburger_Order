
namespace Hamburger_Acar
{
    partial class AddBurger
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
            this.btnAddBurger = new System.Windows.Forms.Button();
            this.txtBoxAddBurger = new System.Windows.Forms.TextBox();
            this.numUpDownAddBurger = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAddBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBurger
            // 
            this.btnAddBurger.Location = new System.Drawing.Point(58, 97);
            this.btnAddBurger.Name = "btnAddBurger";
            this.btnAddBurger.Size = new System.Drawing.Size(234, 23);
            this.btnAddBurger.TabIndex = 8;
            this.btnAddBurger.Text = "Burger Ekle";
            this.btnAddBurger.UseVisualStyleBackColor = true;
            // 
            // txtBoxAddBurger
            // 
            this.txtBoxAddBurger.Location = new System.Drawing.Point(58, 45);
            this.txtBoxAddBurger.Name = "txtBoxAddBurger";
            this.txtBoxAddBurger.Size = new System.Drawing.Size(234, 20);
            this.txtBoxAddBurger.TabIndex = 7;
            // 
            // numUpDownAddBurger
            // 
            this.numUpDownAddBurger.Location = new System.Drawing.Point(58, 71);
            this.numUpDownAddBurger.Name = "numUpDownAddBurger";
            this.numUpDownAddBurger.Size = new System.Drawing.Size(234, 20);
            this.numUpDownAddBurger.TabIndex = 6;
            // 
            // AddBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnAddBurger);
            this.Controls.Add(this.txtBoxAddBurger);
            this.Controls.Add(this.numUpDownAddBurger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBurger";
            this.Text = "AddBurger";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAddBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBurger;
        private System.Windows.Forms.TextBox txtBoxAddBurger;
        private System.Windows.Forms.NumericUpDown numUpDownAddBurger;
    }
}