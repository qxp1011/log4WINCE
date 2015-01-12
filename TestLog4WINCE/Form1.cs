using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using  log4net;
using logEncapsulation;
using LogLayer;

namespace TestLog4WINCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
#if logDebug
                Log.Write(ex);
#endif
            }
        }
    }
}