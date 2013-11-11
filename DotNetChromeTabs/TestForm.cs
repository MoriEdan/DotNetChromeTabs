/*
    ChromeTabControl is a .Net control that mimics Google Chrome's tab bar.
    Copyright (C) 2013  Brandon Francis

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

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
