using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbow
{
    public partial class rainbow : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        int bright = 100;
        String which = "Mono";

        public rainbow()
        {
            InitializeComponent();
        }


        private void updateBackGround()
        {
            int bRed = bright * red / 100;
            int bGreen = bright * green / 100;
            int bBlue = bright * blue / 100;
            this.BackColor = Color.FromArgb(255, bRed, bGreen, bBlue);
            switch(which)
            {
                case "Mono":
                    calcMono(this.BackColor);
                    break;
                case "Complementary":
                    calcComplementary(this.BackColor);
                    break;
                case "Analogous":
                    calcAnalogous(this.BackColor);
                    break;
                case "Triadic":
                    calcTriadic(this.BackColor);
                    break;
            }
        }

        private String makeRGBString(Color c)
        {
            return c.R + "-" + c.G + "-" + c.B;
        }

        private String makeHexString(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
         
        private void TbRed_Scroll(object sender, EventArgs e)
        {
            textRed.Text = tbRed.Value.ToString();
            red = tbRed.Value;
            updateBackGround();
        }

        private void TbGreen_Scroll(object sender, EventArgs e)
        {
            textGreen.Text = tbGreen.Value.ToString();
            green = tbGreen.Value;
            updateBackGround();
        }

        private void TbBlue_Scroll(object sender, EventArgs e)
        {
            textBlue.Text = tbBlue.Value.ToString();
            blue = tbBlue.Value;
            updateBackGround();
        }

        private void TbBright_Scroll(object sender, EventArgs e)
        {
            textBright.Text = tbBright.Value.ToString();
            bright = tbBright.Value;
            updateBackGround();
        }

        private bool checkText(String txt, int max)
        {
            if (txt.Equals("")) return false;
            try
            {
                int a = Convert.ToInt16(txt);
                if (a < 0 || a > max)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkText(textRed.Text, 255))
            {
                // change slider
                red = Convert.ToInt16(textRed.Text);
                tbRed.Value = red;
            }
            else
            {
                textRed.Text = "0";
                tbRed.Value = 0;
                red = 0;
            }

            if (checkText(textGreen.Text, 255))
            {
                // change slider
                green = Convert.ToInt16(textGreen.Text);
                tbGreen.Value = green;
            }
            else
            {
                textGreen.Text = "0";
                tbGreen.Value = 0;
                green = 0;
            }

            if (checkText(textBlue.Text, 255))
            {
                // change slider
                blue = Convert.ToInt16(textBlue.Text);
                tbBlue.Value = blue;
            }
            else
            {
                textBlue.Text = "0";
                tbBlue.Value = 0;
                blue = 0;
            }

            if (checkText(textBright.Text, 100))
            {
                // change slider
                bright = Convert.ToInt16(textBright.Text);
                tbBright.Value = bright;
            }
            else
            {
                textBright.Text = "100";
                tbBright.Value = 100;
                bright = 100;
            }

            // update background
            updateBackGround();
        }

        private void calcComplementary(Color c)
        {
            Color[] panelColors = new Color[4];
            int tempRed = bright * red / 100;
            int tempGreen = bright * green / 100;
            int tempBlue = bright * blue / 100;

            int compRed = 255 - tempRed;
            int compGreen = 255 - tempGreen;
            int compBlue = 255 - tempBlue;

            panelColors[0] = Color.FromArgb(255, compRed * 2 / 3, compGreen * 2 / 3, compBlue * 2 / 3);
            panelColors[1] = Color.FromArgb(255, compRed + (255 - compRed) * 3 / 4, compGreen + (255 - compGreen) * 3 / 4, compBlue + (255 - compBlue) * 3 / 4);
            panelColors[2] = Color.FromArgb(255, tempRed * 2 / 3, tempGreen * 2 / 3, tempBlue * 2 / 3);
            panelColors[3] = Color.FromArgb(255, tempRed + (255 - tempRed) * 3 / 4, tempGreen + (255 - tempGreen) * 3 / 4, tempBlue + (255 - tempBlue) * 3 / 4);

            // panel2
            /** tlHex
             * tlRgb
             */
            panel1.BackColor = panelColors[0];
            tlRgb.Text = makeRGBString(panelColors[0]);
            tlHex.Text = makeHexString(panelColors[0]);

            // panel1
            /** trHex
             * trRgb
             */
            panel2.BackColor = panelColors[1];
            trRgb.Text = makeRGBString(panelColors[1]);
            trHex.Text = makeHexString(panelColors[1]);

            // panel4
            /** blHex
             * blRgb
             */
            panel3.BackColor = panelColors[2];
            blRgb.Text = makeRGBString(panelColors[2]);
            blHex.Text = makeHexString(panelColors[2]);

            // panel3
            /** brHex
             * brRgb
             */
            panel4.BackColor = panelColors[3];
            brRgb.Text = makeRGBString(panelColors[3]);
            brHex.Text = makeHexString(panelColors[3]);

        }

        private void calcAnalogous(Color c)
        {
            Color[] panelColors = new Color[4];
            int tempRed = bright * red / 100;
            int tempGreen = bright * green / 100;
            int tempBlue = bright * blue / 100;

            int tempRedA = (tempRed * 3 + tempGreen * 2) / 5;
            int tempGreenA = (tempBlue * 2 + tempGreen * 3) / 5;
            int tempBlueA = (tempRed * 2 + tempBlue * 3) / 5;

            int tempRedB = (tempRed * 3 + tempBlue * 2) / 5;
            int tempGreenB = (tempRed * 2 + tempGreen * 3) / 5;
            int tempBlueB = (tempGreen * 2 + tempBlue * 3) / 5;

            panelColors[0] = Color.FromArgb(255, tempRedA * 2 / 3, tempGreenA * 2 / 3, tempBlueA * 2 / 3);
            panelColors[1] = Color.FromArgb(255, tempRedA + (255 - tempRedA) * 5 / 6, tempGreenA + (255 - tempGreenA) * 5 / 6, tempBlueA + (255 - tempBlueA) * 5 / 6);
            panelColors[2] = Color.FromArgb(255, tempRedB * 8 / 9, tempGreenB * 8 / 9, tempBlueB * 8 / 9);
            panelColors[3] = Color.FromArgb(255, tempRedB + (255 - tempRedB) * 1 / 2, tempGreenB + (255 - tempGreenB) * 1 / 2, tempBlueB + (255 - tempBlueB) * 1 / 2);

            // panel2
            /** tlHex
             * tlRgb
             */
            panel1.BackColor = panelColors[0];
            tlRgb.Text = makeRGBString(panelColors[0]);
            tlHex.Text = makeHexString(panelColors[0]);

            // panel1
            /** trHex
             * trRgb
             */
            panel2.BackColor = panelColors[1];
            trRgb.Text = makeRGBString(panelColors[1]);
            trHex.Text = makeHexString(panelColors[1]);

            // panel4
            /** blHex
             * blRgb
             */
            panel3.BackColor = panelColors[2];
            blRgb.Text = makeRGBString(panelColors[2]);
            blHex.Text = makeHexString(panelColors[2]);

            // panel3
            /** brHex
             * brRgb
             */
            panel4.BackColor = panelColors[3];
            brRgb.Text = makeRGBString(panelColors[3]);
            brHex.Text = makeHexString(panelColors[3]);

        }

        private void calcMono(Color c)
        {

            Color[] panelColors = new Color[4];
            int tempRed = bright * red / 100;
            int tempGreen = bright * green / 100;
            int tempBlue = bright * blue / 100;
            
            panelColors[0] = Color.FromArgb(255, tempRed * 1 / 3, tempGreen * 1 / 3, tempBlue * 1 / 3);
            panelColors[1] = Color.FromArgb(255, tempRed * 2 / 3, tempGreen * 2 / 3, tempBlue * 2 / 3);
            panelColors[2] = Color.FromArgb(255, tempRed + (255 - tempRed) * 1 / 2, tempGreen + (255 - tempGreen) * 1 / 2, tempBlue + (255 - tempBlue) * 1 / 2);
            panelColors[3] = Color.FromArgb(255, tempRed + (255 - tempRed) * 4 / 5, tempGreen + (255 - tempGreen) * 4 / 5, tempBlue + (255 - tempBlue) * 4 / 5);

            // panel2
            /** tlHex
             * tlRgb
             */
            panel1.BackColor = panelColors[0];
            tlRgb.Text = makeRGBString(panelColors[0]);
            tlHex.Text = makeHexString(panelColors[0]);

            // panel1
            /** trHex
             * trRgb
             */
            panel2.BackColor = panelColors[1];
            trRgb.Text = makeRGBString(panelColors[1]);
            trHex.Text = makeHexString(panelColors[1]);

            // panel4
            /** blHex
             * blRgb
             */
            panel3.BackColor = panelColors[2];
            blRgb.Text = makeRGBString(panelColors[2]);
            blHex.Text = makeHexString(panelColors[2]);

            // panel3
            /** brHex
             * brRgb
             */
            panel4.BackColor = panelColors[3];
            brRgb.Text = makeRGBString(panelColors[3]);
            brHex.Text = makeHexString(panelColors[3]);
        }

        private void calcTriadic(Color c)
        {

            Color[] panelColors = new Color[4];
            int tempRed = bright * red / 100;
            int tempGreen = bright * green / 100;
            int tempBlue = bright * blue / 100;

            panelColors[0] = Color.FromArgb(255, tempGreen * 2 / 3, tempBlue * 2 / 3, tempRed * 2 / 3);
            panelColors[1] = Color.FromArgb(255, tempGreen + (255 - tempGreen) * 3 / 5, tempBlue + (255 - tempBlue) * 3 / 5, tempRed + (255 - tempRed) * 3 / 5);
            panelColors[2] = Color.FromArgb(255, tempBlue * 2 / 3, tempRed * 2 / 3, tempGreen * 2 / 3);
            panelColors[3] = Color.FromArgb(255, tempBlue + (255 - tempBlue) * 3 / 5, tempRed + (255 - tempRed) * 3 / 5, tempGreen + (255 - tempGreen) * 3 / 5);

            // panel2
            /** tlHex
             * tlRgb
             */
            panel1.BackColor = panelColors[0];
            tlRgb.Text = makeRGBString(panelColors[0]);
            tlHex.Text = makeHexString(panelColors[0]);

            // panel1
            /** trHex
             * trRgb
             */
            panel2.BackColor = panelColors[1];
            trRgb.Text = makeRGBString(panelColors[1]);
            trHex.Text = makeHexString(panelColors[1]);

            // panel4
            /** blHex
             * blRgb
             */
            panel3.BackColor = panelColors[2];
            blRgb.Text = makeRGBString(panelColors[2]);
            blHex.Text = makeHexString(panelColors[2]);

            // panel3
            /** brHex
             * brRgb
             */
            panel4.BackColor = panelColors[3];
            brRgb.Text = makeRGBString(panelColors[3]);
            brHex.Text = makeHexString(panelColors[3]);
        }

        private void BtnMono_Click(object sender, EventArgs e)
        {
            int bRed = bright * red / 100;
            int bGreen = bright * green / 100;
            int bBlue = bright * blue / 100;
            which = "Mono";
            calcMono(Color.FromArgb(bRed, bGreen, bBlue));
        }

        private void BtnComplementary_Click(object sender, EventArgs e)
        {
            int bRed = bright * red / 100;
            int bGreen = bright * green / 100;
            int bBlue = bright * blue / 100;
            which = "Complementary";
            calcComplementary(Color.FromArgb(bRed, bGreen, bBlue));
        }

        private void BtnAnalogous_Click(object sender, EventArgs e)
        {
            int bRed = bright * red / 100;
            int bGreen = bright * green / 100;
            int bBlue = bright * blue / 100;
            which = "Analogous";
            calcAnalogous(Color.FromArgb(bRed, bGreen, bBlue));
        }

        private void BtnTriadic_Click(object sender, EventArgs e)
        {
            int bRed = bright * red / 100;
            int bGreen = bright * green / 100;
            int bBlue = bright * blue / 100;
            which = "Triadic";
            calcTriadic(Color.FromArgb(bRed, bGreen, bBlue));
        }
    }
}