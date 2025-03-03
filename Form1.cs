using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Word
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtShow.Text = "113153106"; //你可以直接複製貼過去
            txtShow1.Text = "黃郁堯";
            txtShow3.Text = "應啦!";
            txtShow2.Text = "資硬";
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
