
namespace Hamburger_Acar
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstBxTempOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblChooseMenu = new System.Windows.Forms.Label();
            this.cmboBxMenu = new System.Windows.Forms.ComboBox();
            this.fLPSize = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPExtraMtrl = new System.Windows.Forms.FlowLayoutPanel();
            this.numUpDownPiece = new System.Windows.Forms.NumericUpDown();
            this.lblPiece = new System.Windows.Forms.Label();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.btnTakeOutBasket = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbBoxDrink = new System.Windows.Forms.ComboBox();
            this.lblDrink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstBxTempOrder
            // 
            this.lstBxTempOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBxTempOrder.FormattingEnabled = true;
            this.lstBxTempOrder.ItemHeight = 25;
            this.lstBxTempOrder.Location = new System.Drawing.Point(504, 118);
            this.lstBxTempOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBxTempOrder.Name = "lstBxTempOrder";
            this.lstBxTempOrder.Size = new System.Drawing.Size(1122, 604);
            this.lstBxTempOrder.TabIndex = 1;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrder.Location = new System.Drawing.Point(496, 55);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(289, 38);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "SİPARİŞ LİSTESİ";
            // 
            // lblChooseMenu
            // 
            this.lblChooseMenu.AutoSize = true;
            this.lblChooseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChooseMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChooseMenu.Location = new System.Drawing.Point(8, 224);
            this.lblChooseMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseMenu.Name = "lblChooseMenu";
            this.lblChooseMenu.Size = new System.Drawing.Size(169, 29);
            this.lblChooseMenu.TabIndex = 3;
            this.lblChooseMenu.Text = "Menü Seçiniz";
            // 
            // cmboBxMenu
            // 
            this.cmboBxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboBxMenu.FormattingEnabled = true;
            this.cmboBxMenu.Location = new System.Drawing.Point(9, 257);
            this.cmboBxMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboBxMenu.Name = "cmboBxMenu";
            this.cmboBxMenu.Size = new System.Drawing.Size(361, 33);
            this.cmboBxMenu.TabIndex = 4;
            // 
            // fLPSize
            // 
            this.fLPSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fLPSize.ForeColor = System.Drawing.SystemColors.Control;
            this.fLPSize.Location = new System.Drawing.Point(9, 389);
            this.fLPSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fLPSize.Name = "fLPSize";
            this.fLPSize.Size = new System.Drawing.Size(488, 100);
            this.fLPSize.TabIndex = 5;
            this.fLPSize.Tag = "Boyut Seçin";
            // 
            // fLPExtraMtrl
            // 
            this.fLPExtraMtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fLPExtraMtrl.ForeColor = System.Drawing.SystemColors.Control;
            this.fLPExtraMtrl.Location = new System.Drawing.Point(9, 496);
            this.fLPExtraMtrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fLPExtraMtrl.Name = "fLPExtraMtrl";
            this.fLPExtraMtrl.Size = new System.Drawing.Size(488, 209);
            this.fLPExtraMtrl.TabIndex = 6;
            this.fLPExtraMtrl.Tag = "Ekstra Malzemeler";
            // 
            // numUpDownPiece
            // 
            this.numUpDownPiece.Location = new System.Drawing.Point(91, 714);
            this.numUpDownPiece.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownPiece.Name = "numUpDownPiece";
            this.numUpDownPiece.Size = new System.Drawing.Size(208, 22);
            this.numUpDownPiece.TabIndex = 7;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPiece.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPiece.Location = new System.Drawing.Point(16, 709);
            this.lblPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(66, 29);
            this.lblPiece.TabIndex = 8;
            this.lblPiece.Text = "Adet";
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.Location = new System.Drawing.Point(21, 773);
            this.btnAddBasket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(283, 38);
            this.btnAddBasket.TabIndex = 9;
            this.btnAddBasket.Text = "Sepete Ekle";
            this.btnAddBasket.UseVisualStyleBackColor = true;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // btnTakeOutBasket
            // 
            this.btnTakeOutBasket.Location = new System.Drawing.Point(312, 773);
            this.btnTakeOutBasket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTakeOutBasket.Name = "btnTakeOutBasket";
            this.btnTakeOutBasket.Size = new System.Drawing.Size(283, 38);
            this.btnTakeOutBasket.TabIndex = 10;
            this.btnTakeOutBasket.Text = "Sepetten Çıkar";
            this.btnTakeOutBasket.UseVisualStyleBackColor = true;
            this.btnTakeOutBasket.Click += new System.EventHandler(this.btnTakeOutBasket_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(1343, 757);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(283, 38);
            this.btnMakeOrder.TabIndex = 11;
            this.btnMakeOrder.Text = "Sipariş Ver";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(624, 757);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 29);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Tutar";
            // 
            // cmbBoxDrink
            // 
            this.cmbBoxDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxDrink.FormattingEnabled = true;
            this.cmbBoxDrink.Location = new System.Drawing.Point(9, 336);
            this.cmbBoxDrink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxDrink.Name = "cmbBoxDrink";
            this.cmbBoxDrink.Size = new System.Drawing.Size(361, 33);
            this.cmbBoxDrink.TabIndex = 14;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrink.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDrink.Location = new System.Drawing.Point(8, 303);
            this.lblDrink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(181, 29);
            this.lblDrink.TabIndex = 15;
            this.lblDrink.Text = "İçecek Seçiniz";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1662, 864);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.cmbBoxDrink);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.btnTakeOutBasket);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.lblPiece);
            this.Controls.Add(this.numUpDownPiece);
            this.Controls.Add(this.fLPExtraMtrl);
            this.Controls.Add(this.fLPSize);
            this.Controls.Add(this.cmboBxMenu);
            this.Controls.Add(this.lblChooseMenu);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lstBxTempOrder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateOrder";
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstBxTempOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblChooseMenu;
        private System.Windows.Forms.ComboBox cmboBxMenu;
        private System.Windows.Forms.FlowLayoutPanel fLPSize;
        private System.Windows.Forms.FlowLayoutPanel fLPExtraMtrl;
        private System.Windows.Forms.NumericUpDown numUpDownPiece;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Button btnTakeOutBasket;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbBoxDrink;
        private System.Windows.Forms.Label lblDrink;
    }
}

