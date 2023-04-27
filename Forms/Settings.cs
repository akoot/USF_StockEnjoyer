using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stocks
{
    /// <summary>
    /// Main class that holds all of the information and functions between forms and such.
    /// </summary>
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            new Stocks();

            stockBox.Items.Add("One");
            stockBox.Items.Add("Two");
            stockBox.Items.Add("Three");
        }
    }
}
