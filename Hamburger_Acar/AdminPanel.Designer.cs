
namespace Hamburger_Acar
{
    partial class AdminPanel
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblGiro = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblExtraMaterialIncome = new System.Windows.Forms.Label();
            this.lblPieceTotalProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 548);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // lblGiro
            // 
            this.lblGiro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblGiro.AutoSize = true;
            this.lblGiro.Cursor = System.Windows.Forms.Cursors.No;
            this.lblGiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiro.Location = new System.Drawing.Point(423, 166);
            this.lblGiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiro.Name = "lblGiro";
            this.lblGiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGiro.Size = new System.Drawing.Size(48, 24);
            this.lblGiro.TabIndex = 1;
            this.lblGiro.Text = "Ciro";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTotalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalOrder.Location = new System.Drawing.Point(423, 246);
            this.lblTotalOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalOrder.Size = new System.Drawing.Size(149, 24);
            this.lblTotalOrder.TabIndex = 2;
            this.lblTotalOrder.Text = "Toplam Sipariş";
            // 
            // lblExtraMaterialIncome
            // 
            this.lblExtraMaterialIncome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblExtraMaterialIncome.AutoSize = true;
            this.lblExtraMaterialIncome.Cursor = System.Windows.Forms.Cursors.No;
            this.lblExtraMaterialIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtraMaterialIncome.Location = new System.Drawing.Point(423, 326);
            this.lblExtraMaterialIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtraMaterialIncome.Name = "lblExtraMaterialIncome";
            this.lblExtraMaterialIncome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExtraMaterialIncome.Size = new System.Drawing.Size(203, 24);
            this.lblExtraMaterialIncome.TabIndex = 3;
            this.lblExtraMaterialIncome.Text = "Extra Malzeme Geliri";
            // 
            // lblPieceTotalProduct
            // 
            this.lblPieceTotalProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPieceTotalProduct.AutoSize = true;
            this.lblPieceTotalProduct.Cursor = System.Windows.Forms.Cursors.No;
            this.lblPieceTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPieceTotalProduct.Location = new System.Drawing.Point(423, 422);
            this.lblPieceTotalProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieceTotalProduct.Name = "lblPieceTotalProduct";
            this.lblPieceTotalProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPieceTotalProduct.Size = new System.Drawing.Size(199, 24);
            this.lblPieceTotalProduct.TabIndex = 4;
            this.lblPieceTotalProduct.Text = "Satılan Toplam Ürün";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.lblPieceTotalProduct);
            this.Controls.Add(this.lblExtraMaterialIncome);
            this.Controls.Add(this.lblTotalOrder);
            this.Controls.Add(this.lblGiro);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblGiro;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblExtraMaterialIncome;
        private System.Windows.Forms.Label lblPieceTotalProduct;
    }
}