using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InertiaUI
{
    public partial class Square : UserControl
    {
        public Square()
        {
            InitializeComponent();
        }

        internal void AlterColor()
        {
            BackColor = Color.LightGray;
        }

        public void SetSymbol(string symbol)
        {
            label.Text = symbol;
        }
    }
}
