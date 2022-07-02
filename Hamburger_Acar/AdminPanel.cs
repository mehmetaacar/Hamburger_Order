using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Menu = Classes.Menu;


namespace Hamburger_Acar
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            OrdersToShow();
            lblPieceTotalProduct.Hide();
            lblExtraMaterialIncome.Hide();
        
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedOrderInfo();
        }

        public void OrdersToShow()
        {
            try
            {
                listBox1.Items.Clear();
                double totalIncome = 0;

                foreach (KeyValuePair<string, double> order in DataList.order)
                {
                    listBox1.Items.Add(order.Key);
                }
                foreach (KeyValuePair<string, double> order in DataList.order)
                {
                    totalIncome += order.Value;
                }
                lblGiro.Text = "Ciro: " + totalIncome;
                lblTotalOrder.Text = "Toplam Sipariş Sayısı: " + DataList.order.Keys.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        void SelectedOrderInfo()
        {
            
            try
            {
                double selectedOrderPrice = 0;
                string selectedOrderText = "";
                foreach (KeyValuePair<string, double> order in DataList.order)
                {
                    if (order.Key == listBox1.SelectedItem.ToString())
                    {
                        selectedOrderText = order.Key;
                        selectedOrderPrice = order.Value;
                        break;
                    }


                }
                MessageBox.Show("Seçili Sipariş Detayı: " + selectedOrderText + "\n\nSeçili Sipariş Tutarı:" + selectedOrderPrice);
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Lütfen sipariş seçiniz.");
            }
            

        }

        
    }
}
