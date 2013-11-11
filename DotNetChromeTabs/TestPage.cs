using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetChromeTabs
{

    /// <summary>
    /// Example tab page.
    /// </summary>
    public partial class TestPage : ChromeTabControl.TabPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void TestPage_Load(object sender, EventArgs e)
        {
        }

        internal override bool NewInstanceAttempted(ChromeTabControl.TabPage newInstance)
        {
            return true;
        }

    }
}
