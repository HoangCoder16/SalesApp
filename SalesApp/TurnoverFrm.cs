using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class TurnoverFrm : Form
    {
        public TurnoverFrm(int numberItem, int numberCustomer, int numberMonney)
        {
            InitializeComponent();
            CenterToParent();
            richTextBoxItem.Text = numberItem.ToString();
            richTextBoxCustomer.Text = numberCustomer.ToString(); 
            richTextBoxMoney.Text = numberMonney.ToString();
        }
    }
}
