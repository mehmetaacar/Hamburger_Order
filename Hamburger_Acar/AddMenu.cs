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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }
        
        
        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu(txtBoxAddMenu.Text, (double)numUpDownAddMenu.Value);
                DataList.menus.Add(menu);
                MessageBox.Show("Menü Eklendi.");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void AddMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
