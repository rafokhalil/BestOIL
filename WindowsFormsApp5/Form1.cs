using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class BestOIL : Form
    {

        List<OIL> oILs = new List<OIL>
        {
            new OIL{Type="A92",Price=1},new OIL{Type="A95",Price=1.40},new OIL{Type="Diesel",Price=0.6}
        };

        public BestOIL()
        {
            InitializeComponent();
        }

        private void BestOIL_Load(object sender, EventArgs e)
        {
            OILComboBox.Items.AddRange(oILs.ToArray());
            OILComboBox.DataSource = oILs;
            OILComboBox.DisplayMember = "Type";
        }

        private void OILComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var petrol = OILComboBox.SelectedItem as OIL;
            ShowTxtBox.Text = petrol.Price.ToString();
        }

        private void LiterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LiterTxtBox.Enabled = true;
            var oil = OILComboBox.SelectedItem as OIL;
            var text = double.Parse(LiterTxtBox.Text) * oil.Price;
        }

        
    }
}