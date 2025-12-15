using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlenAssetManagement
{
    public partial class AddAsset : Form
    {
        public AddAsset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SystemName = SystemNameInput.Text;
            string Manufacturer = ManufacturerInput.Text;
            string Model = ModelInput.Text;
            string DeviceType = DeviceTypeInput.Text;
            string IPAddress = IPAddressInput.Text;
            string PurchaseDate= PurchaseDateInput.Text;
            string Notes = NotesInput.Text;

        }
    }
}
