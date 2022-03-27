using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAZI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            s = 0;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your score is = " + s.ToString());
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int old = lablel1.Left;
            lablel1.Left += lablel1.Width + 6;

            if (lablel1.Bounds.IntersectsWith(irani1.Bounds) || lablel1.Bounds.IntersectsWith(irani2.Bounds) || lablel1.Bounds.IntersectsWith(irani3.Bounds) || lablel1.Bounds.IntersectsWith(irani4.Bounds))
            {
                MessageBox.Show("few score added ");
                s = +5;
            }
            if (lablel1.Bounds.IntersectsWith(kh1.Bounds) || lablel1.Bounds.IntersectsWith(kh2.Bounds) || lablel1.Bounds.IntersectsWith(kh3.Bounds) || lablel1.Bounds.IntersectsWith(kh4.Bounds) || lablel1.Bounds.IntersectsWith(khar1.Bounds) || lablel1.Bounds.IntersectsWith(khar2.Bounds))
            {
                MessageBox.Show(" you lost score ");
                s--;
            }
            if (lablel1.Bounds.IntersectsWith(divar1.Bounds) || lablel1.Bounds.IntersectsWith(divar2.Bounds) || lablel1.Bounds.IntersectsWith(divar3.Bounds) || lablel1.Bounds.IntersectsWith(divar4.Bounds) || lablel1.Bounds.IntersectsWith(divar5.Bounds) || lablel1.Bounds.IntersectsWith(divar6.Bounds) || lablel1.Bounds.IntersectsWith(divar7.Bounds) || lablel1.Bounds.IntersectsWith(divar8.Bounds) || lablel1.Bounds.IntersectsWith(divar9.Bounds) || lablel1.Bounds.IntersectsWith(divar10.Bounds) || lablel1.Bounds.IntersectsWith(divar11.Bounds) || lablel1.Bounds.IntersectsWith(divar12.Bounds) || lablel1.Bounds.IntersectsWith(divar13.Bounds) || lablel1.Bounds.IntersectsWith(divar14.Bounds) || lablel1.Bounds.IntersectsWith(divar15.Bounds))
                lablel1.Left = old;

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int old = lablel1.Left;
            lablel1.Left -= lablel1.Width + 6;
            if (lablel1.Bounds.IntersectsWith(irani1.Bounds) || lablel1.Bounds.IntersectsWith(irani2.Bounds) || lablel1.Bounds.IntersectsWith(irani3.Bounds) || lablel1.Bounds.IntersectsWith(irani4.Bounds))
            {
                MessageBox.Show("few score added ");
                s = +5;
            }
            if (lablel1.Bounds.IntersectsWith(kh1.Bounds) || lablel1.Bounds.IntersectsWith(kh2.Bounds) || lablel1.Bounds.IntersectsWith(kh3.Bounds) || lablel1.Bounds.IntersectsWith(kh4.Bounds) || lablel1.Bounds.IntersectsWith(khar1.Bounds) || lablel1.Bounds.IntersectsWith(khar2.Bounds))
            {
                MessageBox.Show(" you lost score ");
                s--;
            }
            if (lablel1.Bounds.IntersectsWith(divar1.Bounds) || lablel1.Bounds.IntersectsWith(divar2.Bounds) || lablel1.Bounds.IntersectsWith(divar3.Bounds) || lablel1.Bounds.IntersectsWith(divar4.Bounds) || lablel1.Bounds.IntersectsWith(divar5.Bounds) || lablel1.Bounds.IntersectsWith(divar6.Bounds) || lablel1.Bounds.IntersectsWith(divar7.Bounds) || lablel1.Bounds.IntersectsWith(divar8.Bounds) || lablel1.Bounds.IntersectsWith(divar9.Bounds) || lablel1.Bounds.IntersectsWith(divar10.Bounds) || lablel1.Bounds.IntersectsWith(divar11.Bounds) || lablel1.Bounds.IntersectsWith(divar12.Bounds) || lablel1.Bounds.IntersectsWith(divar13.Bounds) || lablel1.Bounds.IntersectsWith(divar14.Bounds) || lablel1.Bounds.IntersectsWith(divar15.Bounds))

                lablel1.Left = old;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int old = lablel1.Top;
            lablel1.Top -= lablel1.Height + 2;
            if (lablel1.Bounds.IntersectsWith(irani1.Bounds) || lablel1.Bounds.IntersectsWith(irani2.Bounds) || lablel1.Bounds.IntersectsWith(irani3.Bounds) || lablel1.Bounds.IntersectsWith(irani4.Bounds))
            {
                MessageBox.Show("few score added ");
                s = +5;
            }
            if (lablel1.Bounds.IntersectsWith(kh1.Bounds) || lablel1.Bounds.IntersectsWith(kh2.Bounds) || lablel1.Bounds.IntersectsWith(kh3.Bounds) || lablel1.Bounds.IntersectsWith(kh4.Bounds) || lablel1.Bounds.IntersectsWith(khar1.Bounds) || lablel1.Bounds.IntersectsWith(khar2.Bounds))
            {
                MessageBox.Show(" you lost score ");
                s--;
            }
            if (lablel1.Bounds.IntersectsWith(divar1.Bounds) || lablel1.Bounds.IntersectsWith(divar2.Bounds) || lablel1.Bounds.IntersectsWith(divar3.Bounds) || lablel1.Bounds.IntersectsWith(divar4.Bounds) || lablel1.Bounds.IntersectsWith(divar5.Bounds) || lablel1.Bounds.IntersectsWith(divar6.Bounds) || lablel1.Bounds.IntersectsWith(divar7.Bounds) || lablel1.Bounds.IntersectsWith(divar8.Bounds) || lablel1.Bounds.IntersectsWith(divar9.Bounds) || lablel1.Bounds.IntersectsWith(divar10.Bounds) || lablel1.Bounds.IntersectsWith(divar11.Bounds) || lablel1.Bounds.IntersectsWith(divar12.Bounds) || lablel1.Bounds.IntersectsWith(divar13.Bounds) || lablel1.Bounds.IntersectsWith(divar14.Bounds) || lablel1.Bounds.IntersectsWith(divar15.Bounds))

                lablel1.Top = old;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int old = lablel1.Top;
            lablel1.Top += lablel1.Height + 2;
            if (lablel1.Bounds.IntersectsWith(irani1.Bounds) || lablel1.Bounds.IntersectsWith(irani2.Bounds) || lablel1.Bounds.IntersectsWith(irani3.Bounds) || lablel1.Bounds.IntersectsWith(irani4.Bounds))
            {
                MessageBox.Show("few score added ");
                s = +5;
            }
            if (lablel1.Bounds.IntersectsWith(kh1.Bounds) || lablel1.Bounds.IntersectsWith(kh2.Bounds) || lablel1.Bounds.IntersectsWith(kh3.Bounds) || lablel1.Bounds.IntersectsWith(kh4.Bounds) || lablel1.Bounds.IntersectsWith(khar1.Bounds) || lablel1.Bounds.IntersectsWith(khar2.Bounds))
            {
                MessageBox.Show(" you lost score ");
                s--;
            }
            if (lablel1.Bounds.IntersectsWith(divar1.Bounds) || lablel1.Bounds.IntersectsWith(divar2.Bounds) || lablel1.Bounds.IntersectsWith(divar3.Bounds) || lablel1.Bounds.IntersectsWith(divar4.Bounds) || lablel1.Bounds.IntersectsWith(divar5.Bounds) || lablel1.Bounds.IntersectsWith(divar6.Bounds) || lablel1.Bounds.IntersectsWith(divar7.Bounds) || lablel1.Bounds.IntersectsWith(divar8.Bounds) || lablel1.Bounds.IntersectsWith(divar9.Bounds) || lablel1.Bounds.IntersectsWith(divar10.Bounds) || lablel1.Bounds.IntersectsWith(divar11.Bounds) || lablel1.Bounds.IntersectsWith(divar12.Bounds) || lablel1.Bounds.IntersectsWith(divar13.Bounds) || lablel1.Bounds.IntersectsWith(divar14.Bounds) || lablel1.Bounds.IntersectsWith(divar15.Bounds))

                lablel1.Top = old;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
