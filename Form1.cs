using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CanChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string can = "";
            switch (Convert.ToInt32(txtnam.Text) % 10)
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                        break;
                case 3:
                    can = "Qúy";
                    break;
                case 4:
                    can = "Giap";
                    break;
                case 5:
                    can = "ất";
                        break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                        break;
                case 9:
                    can = "Kỷ";
                        break;






            }
            string chi = "";
            switch (Convert.ToInt32(txtnam.Text) % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    can = "Dậu";
                    break;
                case 2:
                    can = "Tuất";
                        break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    can = "tý";
                    break;
                case 5:
                    can = "sửu";
                        break;
                case 6:
                    chi = "dần";
                    break;
                case 7:
                    can = "mão ";
                    break;
                case 8:
                    can = "Thình";
                        break;
                case 9:
                    chi = "Tỵ";
                    break;
                case 10:
                    can = "Ngọ ";
                    break;
                case 11:
                    can = "Mùi";
                        break;
            }
            txtkq.Text = can + " " + chi;
        }
    }
}
