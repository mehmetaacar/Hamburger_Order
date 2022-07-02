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
    
    public partial class AddExtraMaterial : Form
    {
        public AddExtraMaterial()
        {
            InitializeComponent();
        }

        private void btnAddExtraMaterial_Click(object sender, EventArgs e)
        {
            
            Sauce sauce = new Sauce(txtBoxAddExtraMaterial.Text);
            DataList.sauces.Add(sauce);
            MessageBox.Show("Ekstra Malzeme Eklendi.");
        }
    }
}
