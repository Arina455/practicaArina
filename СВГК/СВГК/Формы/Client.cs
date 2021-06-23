using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СВГК
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void заказчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Client_Load(object sender, EventArgs e)
        {
            

        }

       

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.Show();
        }
    }
}
