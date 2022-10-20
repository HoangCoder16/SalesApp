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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            CenterToScreen();
            timer1.Start();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                HomeFrm homeFrm = new HomeFrm();
                homeFrm.Show();
                this.Close();
            }
        }
    }
}
