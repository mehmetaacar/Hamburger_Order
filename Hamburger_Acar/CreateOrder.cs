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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        // Drink drink = new Drink(4.99); //İÇECEK MENÜYE DAHİL.
        
        List<CheckBox> chckBxList = new List<CheckBox>();
        List<RadioButton> rdioBtnList = new List<RadioButton>();

        DateTime orderDate;
        string orderText="";
        double orderPrice = 0;

        /// <summary>
        /// Initialize own sauces
        /// </summary>
        void InitSauces()
        {
            Sauce ketchup = new Sauce("Ketçap");
            DataList.sauces.Add(ketchup);
            Sauce mayonnaise = new Sauce("Mayonez");
            DataList.sauces.Add(mayonnaise);
            Sauce ranchsauce = new Sauce("Ranch Sos");
            DataList.sauces.Add(ranchsauce);
            Sauce barbecuesauce = new Sauce("Barbekü Sos");
            DataList.sauces.Add(barbecuesauce);
            Sauce garlicmayo = new Sauce("Sarımsaklı Mayonez");
            DataList.sauces.Add(garlicmayo);
        }
        void InitMenus()
        {
            Menu bigMac = new Menu("Big Mac Menü", 58.99,"Big Mac Burger",0);
            DataList.menus.Add(bigMac);
            Menu mcChicken = new Menu("McChicken Menü", 47.99, "McChicken Burger",0);
            DataList.menus.Add(mcChicken);
            Menu doubleCheeseBurger = new Menu("Double Cheese Burger Menü", 56.99,"Double Cheese Burger",0);
            DataList.menus.Add(doubleCheeseBurger);
            Menu quarterPounder = new Menu("Quarter Pounder Menü", 71.99,"Quarter Pounder Burger",0);
            DataList.menus.Add(quarterPounder);
            Menu mcRoyal = new Menu("McRoyal Menü", 58.99,"McRoyal Burger",0);
            DataList.menus.Add(mcRoyal);
            Menu kofteBurger = new Menu("Köfte Burger Menü", 58.99,"Köfte Burger",0);
            DataList.menus.Add(kofteBurger);

        }
        public void ShowMenus()
        {
            cmboBxMenu.Items.Clear();
            foreach (Menu menu in DataList.menus)
            {
                cmboBxMenu.Items.Add(menu.MenuName);
            }
        }
        public void ShowSauces()
        {
            fLPExtraMtrl.Controls.Clear();
            foreach (Sauce sauce in DataList.sauces)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = sauce.Name;
                checkBox.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                chckBxList.Add(checkBox);
                fLPExtraMtrl.Controls.Add(checkBox);
            }
        }
        public void ShowSizes()
        {
            foreach (string item in (Enum.GetNames(typeof(Menu.Size))))
            {
                RadioButton rdBtn = new RadioButton();
                rdBtn.Text = item;
                rdBtn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                rdioBtnList.Add(rdBtn);

                fLPSize.Controls.Add(rdBtn);

            }
        }


        void CheckAndSelectSize(ref string orderText, ref double orderPrice, ref bool isOrderCreated)
        {
            int a = 0;
            
            foreach (RadioButton rb in rdioBtnList)
            {
                if (rb.Checked && rb.Text == "Küçük")
                {
                    orderText += ", Küçük Boy";
                    orderPrice += (int)Enum.Parse(typeof(Menu.Size), "Küçük");
                }
                else if (rb.Checked && rb.Text == "Orta")
                {
                    orderText += ", Orta Boy";
                    orderPrice += (int)Enum.Parse(typeof(Menu.Size), "Orta");
                }
                else if (rb.Checked && rb.Text == "Büyük")
                {
                    orderText += ", Büyük Boy";
                    orderPrice += (int)Enum.Parse(typeof(Menu.Size), "Büyük");
                }
                else if (rb.Checked && rb.Text == "Jumbo")
                {
                    orderText += ", Jumbo Boy";
                    orderPrice += (int)Enum.Parse(typeof(Menu.Size), "Jumbo");
                }
                else if (rb.Checked == false)
                {
                    a++;
                    if (a == 4)
                    {
                        isOrderCreated = false;
                        MessageBox.Show("Lütfen boyut seçimi yapınız");

                    }

                }


            }
        }
        void CheckAndSelectMenu(ref string orderText, ref double orderPrice, ref bool isOrderCreated)
        {
            bool isMenuSelected = false;
            foreach (Menu menu in DataList.menus)
            {
                if (menu.MenuName == cmboBxMenu.Text)
                {
                    orderPrice += menu.Price;
                    orderText += menu.ToString();
                    isMenuSelected = true;

                }
            }
            if (isMenuSelected == false)
            {
                MessageBox.Show("Lütfen bir menü seçimi yapınız");
                isOrderCreated = false;
            }


        }
        void CheckAndSelectDrink(ref string orderText, ref bool isOrderCreated)
        {
            bool isDrinkSelected = false;
            foreach (string drink in Enum.GetNames(typeof(Drinks)))
            {
                if (drink == cmbBoxDrink.Text)
                {
                    orderText += ", " + drink;
                    isDrinkSelected = true;
                }

            }
            if (isDrinkSelected == false)
            {
                MessageBox.Show("Lütfen bir içecek seçimi yapınız");
                isOrderCreated = false;
            }


        }
        void CheckAndSelectSauce(ref string orderText, ref double orderPrice)
        {
            foreach (CheckBox cbx in chckBxList)
            {
                if (cbx.Checked)
                {
                    foreach (Sauce sauce in DataList.sauces)
                    {
                        if (sauce.Name == cbx.Text)
                        {
                            orderText += ", " + sauce.Name;
                            orderPrice += sauce.Price;
                        }
                    }
                }


            }
        }
        void ClearControls()
        {
            cmbBoxDrink.SelectedIndex = -1;
            cmboBxMenu.SelectedIndex = -1;

            foreach (CheckBox checkBox in chckBxList)
            {
                checkBox.Checked = false;
            }

            foreach (RadioButton radioButton in rdioBtnList)
            {
                radioButton.Checked = false;
            }
        }
        void CalculateBasket(ref string orderText, ref double orderPrice)
        {

            bool isOrderCreated = true;
            orderText = null;


            CheckAndSelectMenu(ref orderText, ref orderPrice, ref isOrderCreated);
            CheckAndSelectSize(ref orderText, ref orderPrice, ref isOrderCreated);
            CheckAndSelectDrink(ref orderText, ref isOrderCreated);
            CheckAndSelectSauce(ref orderText, ref orderPrice);
            



            if (isOrderCreated)
            {
                if (numUpDownPiece.Value == (int)numUpDownPiece.Value) // Adet int mi değil mi ?
                {
                    orderPrice = orderPrice * (int)numUpDownPiece.Value;
                    orderText += " x" + numUpDownPiece.Value;
                    numUpDownPiece.Value = 1;

                    lblPrice.Text = "TUTAR: " + orderPrice.ToString() + " TL";
                    lstBxTempOrder.Items.Add(orderText);

                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir adet giriniz.");
                    orderPrice = 0;
                    orderText = null;
                    ClearControls();
                }
                
                
            }
            else
            {
                orderPrice = 0;
                orderText = null;
                ClearControls();
            }


        }
        void PassToAdminPanel(ref DateTime orderDate)
        {
            try
            {
                if (lstBxTempOrder.Items.Count == 0)
                {
                    MessageBox.Show("Lütfen sepetinizi kontrol ediniz");
                }
                else
                {
                    orderDate = DateTime.Now;
                    string totalOrdersInBasket = orderDate + "  ";
                    foreach (string orders in lstBxTempOrder.Items)
                    {
                        totalOrdersInBasket += orders;
                    }


                    DataList.order.Add(totalOrdersInBasket, orderPrice);
                    lblPrice.Text = "TUTAR: 0 TL";
                    lstBxTempOrder.Items.Clear();
                    orderPrice = 0;
                    totalOrdersInBasket = "";
                    MessageBox.Show("Sipariş tamamlanmıştır.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lütfen sepetinizi kontrol ediniz\n" + ex.Message);
            }
        }


        private void CreateOrder_Load(object sender, EventArgs e)
        {
            InitMenus();
            ShowMenus();
            InitSauces();
            ShowSauces();
            ShowSizes();
            numUpDownPiece.Minimum = 1;
            numUpDownPiece.Maximum = 100;
            cmbBoxDrink.Items.AddRange(Enum.GetNames(typeof(Drinks)));
            lblPrice.Text = "TUTAR: 0 TL";
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            CalculateBasket(ref orderText, ref orderPrice);
        }

        private void btnTakeOutBasket_Click(object sender, EventArgs e)
        {
            //DataList.orderText.Remove(lstBxTempOrder.Items.IndexOf(order))

            if (lstBxTempOrder.SelectedItem is null)
            {
                MessageBox.Show("Lütfen silinecek sipariş detayını seçiniz");
            }
            else
            {
                lstBxTempOrder.Items.RemoveAt(lstBxTempOrder.SelectedIndex);
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            PassToAdminPanel(ref orderDate);
        }

        void addBasketOld()
        {
            //string order="";
            //double totalPrice = 0;

            //if (cmboBxMenu.SelectedIndex==-1 || cmbBoxDrink.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Lütfen Menü Seçimi yapınız ");
            //    return;
            //}

            //foreach (Menu menu in DataList.menus)
            //{
            //    if (menu.MenuName==cmboBxMenu.Text)
            //    {
            //        order += menu.ToString();
            //        totalPrice += menu.Price;
            //        cmboBxMenu.SelectedIndex = -1;
            //    }

            //}


            //foreach (string drink in (Enum.GetNames(typeof(Drinks))))
            //{
            //    if (cmbBoxDrink.Text == drink)
            //    {
            //        //içecek fiyat menüye dahil
            //        order += "+" + drink;

            //        cmbBoxDrink.SelectedIndex = -1;
            //    }
            //}
            //foreach (CheckBox checkBox in chckBxList)
            //{
            //    if (checkBox.Checked)
            //    {
            //        foreach (Sauce sauce in DataList.sauces)
            //        {
            //            if (sauce.Name==checkBox.Text)
            //            {
            //                order += "+" + sauce.Name;
            //                totalPrice += 2;
            //            }
            //        }
            //    }
            //}

            //foreach (RadioButton radioBtn in rdioBtnList)
            //{
            //    if (radioBtn.Checked)
            //    {
            //        foreach (string size in (Enum.GetNames(typeof(Menu.Size))))
            //        {
            //            if (radioBtn.Text == size)
            //            {
            //                order += "+" + size;
            //            }
            //        }
            //    } 
            //}

            //ClearControls();

            //order += " x" + numUpDownPiece.Value.ToString();
            //totalPrice *= (double)numUpDownPiece.Value;
            //numUpDownPiece.Value = 1;
            //price += totalPrice;
            //lstBxTempOrder.Items.Add(order);
            //lblPrice.Text = "TUTAR: " + price.ToString() + " TL";
            //DataList.orderText.Add(order);
            //DataList.priceOfOrders.Add(totalPrice);
        } //eski sistem


    }
}
