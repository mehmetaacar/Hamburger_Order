
namespace Hamburger_Acar
{
    partial class AddExtraMaterial
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
            this.btnAddExtraMaterial = new System.Windows.Forms.Button();
            this.txtBoxAddExtraMaterial = new System.Windows.Forms.TextBox();
            this.numUpDownAddExtraMaterial = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAddExtraMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddExtraMaterial
            // 
            this.btnAddExtraMaterial.Location = new System.Drawing.Point(55, 110);
            this.btnAddExtraMaterial.Name = "btnAddExtraMaterial";
            this.btnAddExtraMaterial.Size = new System.Drawing.Size(234, 23);
            this.btnAddExtraMaterial.TabIndex = 5;
            this.btnAddExtraMaterial.Text = "Ekstra Malzeme Ekle";
            this.btnAddExtraMaterial.UseVisualStyleBackColor = true;
            this.btnAddExtraMaterial.Click += new System.EventHandler(this.btnAddExtraMaterial_Click);
            // 
            // txtBoxAddExtraMaterial
            // 
            this.txtBoxAddExtraMaterial.Location = new System.Drawing.Point(55, 41);
            this.txtBoxAddExtraMaterial.Name = "txtBoxAddExtraMaterial";
            this.txtBoxAddExtraMaterial.Size = new System.Drawing.Size(234, 20);
            this.txtBoxAddExtraMaterial.TabIndex = 4;
            // 
            // numUpDownAddExtraMaterial
            // 
            this.numUpDownAddExtraMaterial.Location = new System.Drawing.Point(55, 84);
            this.numUpDownAddExtraMaterial.Name = "numUpDownAddExtraMaterial";
            this.numUpDownAddExtraMaterial.Size = new System.Drawing.Size(234, 20);
            this.numUpDownAddExtraMaterial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İKİNCİ BİR EMRE KADAR FİYAT GİRİŞİ YAPMAYINIZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ekstra Malzeme Adı";
            // 
            // AddExtraMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExtraMaterial);
            this.Controls.Add(this.txtBoxAddExtraMaterial);
            this.Controls.Add(this.numUpDownAddExtraMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddExtraMaterial";
            this.Text = "Add Extra Material";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAddExtraMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExtraMaterial;
        private System.Windows.Forms.TextBox txtBoxAddExtraMaterial;
        private System.Windows.Forms.NumericUpDown numUpDownAddExtraMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}