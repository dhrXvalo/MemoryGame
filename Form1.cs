using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeheugenSpel
{
    public partial class Form1 : Form
    {
        Button[] lijstKaarten;
        int clicked = 0;
        Color blue = Color.Blue;
        Color red = Color.Red;
        public Form1()
        {
            InitializeComponent();
            lijstKaarten = new Button[] { btnKaart1, btnKaart2, btnKaart3, btnKaart4};
        }

        private void btnOpnieuw_Click(object sender, EventArgs e)
        { 
            clicked = 0;

            btnKaart1.BackColor = SystemColors.Control;
            btnKaart2.BackColor = SystemColors.Control;
            btnKaart3.BackColor = SystemColors.Control;
            btnKaart4.BackColor = SystemColors.Control;

            btnKaart1.Visible = true;
            btnKaart2.Visible = true;
            btnKaart3.Visible = true;
            btnKaart4.Visible = true;
        }

        void checkPaar()
        {
            if (clicked % 2 == 0)
            {
                if (btnKaart1.BackColor == btnKaart2.BackColor)
                {
                    btnKaart1.Visible = false;
                    btnKaart2.Visible = false;
                }
                else if (btnKaart3.BackColor == btnKaart4.BackColor)
                {
                    btnKaart3.Visible = false;
                    btnKaart4.Visible = false;
                }
            }
        }

        private void flipCard(object sender, EventArgs e)
        {
            Button kaart = sender as Button;
            int indexKaart = Array.IndexOf(lijstKaarten, kaart);

            clicked++;

            switch (indexKaart)
            {
                case 0:
                    btnKaart1.BackColor = blue;
                    break;
                case 1:
                    btnKaart2.BackColor = blue;
                    break;
                case 2:
                    btnKaart3.BackColor = red;
                    break;
                case 3:
                    btnKaart4.BackColor = red;
                    break;
            }
            checkPaar();
            //kaart.BackColor = blue;
            //kaart.Text = clicked.ToString();
        }
    }
}
