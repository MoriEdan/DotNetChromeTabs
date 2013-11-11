using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DotNetChromeTabs
{
    public partial class TestForm : Form
    {
        private ChromeTabControl control;

        public TestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            // Let's create a new tab control
            control = new ChromeTabControl();

            // Let's make the top bar transparent and look better
            ChromeTabControl.AeroFunctions.ChromifyWindow(this, control);

            // Add a handler for when the new tab button is clicked
            control.NewTabClicked += control_NewTabClicked;

            // Let's add it to the form
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);

            // Let's add 2 test pages to it
            control.TabPages.AddNoAnimate(new TestPage());
            control.TabPages.AddNoAnimate(new TestPage());

        }

        void control_NewTabClicked(object sender, EventArgs e)
        {
            // Let's add in a new tab page
            control.TabPages.Add(new TestPage());
        }


    }
}
