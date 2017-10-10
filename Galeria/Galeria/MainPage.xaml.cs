using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Galeria
{
    public partial class MainPage : CarouselPage
    {
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0, total1 = 0;
        int dc1 = 0, dc2 = 0, dc3 = 0, dc4 = 0, dc5 = 0, dc6 = 0, dc7 = 0, dc8 = 0, dc9 = 0, dc10 = 0, dtotal1, dtotal2;

        private void btn1_Clicked_1(object sender, EventArgs e)
        {
            dtotal1 = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10;
            dtotal2 = dc1 + dc2 + dc3 + dc4 + dc5 + dc6 + dc7 + dc8 + dc9 + dc10;
            lbl1.Text = "Likes Obtenidos:" + dtotal1;
            lbl2.Text = "DisLikes Obtenidos:" + dtotal2;
        }

        private void btn10_Clicked(object sender, EventArgs e)
        {
            c10++;
            btn10.Text = c10 + "";

        }

        private void dbtn1_Clicked(object sender, EventArgs e)
        {
            dc1++;
            dbtn1.Text = dc1 + "";
        }

        private void dbtn1_Clicked_1(object sender, EventArgs e)
        {
            dc2++;
            dbtn2.Text = dc2 + "";
        }

        private void dbtn1_Clicked_2(object sender, EventArgs e)
        {
            dc3++;
            dbtn3.Text = dc3 + "";
        }

        private void dbtn1_Clicked_3(object sender, EventArgs e)
        {
            dc4++;
            dbtn4.Text = dc4 + "";

        }

        private void dbtn1_Clicked_4(object sender, EventArgs e)
        {
            dc5++;
            dbtn5.Text = dc5 + "";
        }

        private void dbtn1_Clicked_5(object sender, EventArgs e)
        {
            dc6++;
            dbtn6.Text = dc6 + "";
        }

        private void dbtn1_Clicked_6(object sender, EventArgs e)
        {
            dc7++;
            dbtn7.Text = dc7 + "";
        }

        private void dbtn1_Clicked_7(object sender, EventArgs e)
        {
            dc8++;
            dbtn8.Text = dc8 + "";
        }

        private void dbtn1_Clicked_8(object sender, EventArgs e)
        {
            dc9++;
            dbtn9.Text = dc9 + "";
        }

        private void dbtn1_Clicked_9(object sender, EventArgs e)
        {
            dc10++;
            dbtn10.Text = dc10 + "";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            c9++;
            btn9.Text = c9 + "";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            c8++;
            btn8.Text = c8 + "";

        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            c7++;
            btn7.Text = c7 + "";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            c6++;
            btn6.Text = c6 + "";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            c5++;
            btn5.Text = c5 + "";

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            c4++;
            btn4.Text = c4 + "";

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            c3++;
            btn3.Text = c3 + "";

        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            c2++;
            btn2.Text = c2 + "";
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            c1++;
            btn1.Text = c1 + "";

        }
    }
}