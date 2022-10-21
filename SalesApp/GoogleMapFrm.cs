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
    public partial class GoogleMapFrm : Form
    {
        public GoogleMapFrm(string address)
        {           
            InitializeComponent();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            webBrowser1.ScriptErrorsSuppressed = true;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("https://google.com//maps?q=");
            stringBuilder.Append(address);
            webBrowser1.Navigate(stringBuilder.ToString());
        }
    }
}
