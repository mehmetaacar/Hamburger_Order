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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        AddBurger addBurger = new AddBurger();
        AddExtraMaterial addExtraMaterial = new AddExtraMaterial();
        AdminPanel adminPanel = new AdminPanel();
        AddMenu addMenu = new AddMenu();
        CreateOrder createOrder = new CreateOrder();

        void HideForms()
        {
            createOrder.Hide();
            adminPanel.Hide();
            addBurger.Hide();
            addExtraMaterial.Hide();
            addMenu.Hide();
            
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        { 
            createOrder.MdiParent = this;
            this.ClientSize = new Size(1350, 700);
            createOrder.Dock = DockStyle.Fill;
            HideForms();
            createOrder.Show();


        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addExtraMaterial.MdiParent = this;
            this.ClientSize = new Size(350, 200);
            addExtraMaterial.Dock = DockStyle.Fill;
            HideForms();
            addExtraMaterial.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMenu.MdiParent = this;
            this.ClientSize = new Size(350, 200);
            addMenu.Dock = DockStyle.Fill;
            HideForms();
            addMenu.Show();
        }

        private void burgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBurger = new AddBurger();
            MessageBox.Show("BAKIMDADIR.");
            //addBurger.MdiParent = this;
            //this.ClientSize = new Size(350, 200);
            //addBurger.Dock = DockStyle.Fill;
            //HideForms();
            //addBurger.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            createOrder.MdiParent = this;
            this.ClientSize = new Size(1350, 700);
            createOrder.Dock = DockStyle.Fill;
            createOrder.ShowMenus();
            createOrder.ShowSauces();
            HideForms();
            createOrder.Show();
            
        }

        private void adminPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {

            adminPanel = new AdminPanel();
            adminPanel.MdiParent = this;
            this.ClientSize = new Size(600, 494);
            adminPanel.Dock = DockStyle.Fill;
            HideForms();
            adminPanel.Show();


            //adminPanel.TotalGiro();
            //adminPanel.AddOrdersToAdminPanel();
            //adminPanel.TotalNumberOfOrders();

        }

        
    }
}
