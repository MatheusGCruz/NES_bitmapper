using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NES_bitmapper
{
    public partial class Form1 : Form
    {
        public Color palette0_color = Color.White;
        public Color palette1_color = Color.White;
        public Color palette2_color = Color.White;
        public Color palette3_color = Color.White;

        public int bit00_value = 0;
        public int bit01_value = 0;
        public int bit02_value = 0;
        public int bit03_value = 0;
        public int bit04_value = 0;
        public int bit05_value = 0;            
        public int bit06_value = 0;
        public int bit07_value = 0;

        public int bit10_value = 0;
        public int bit11_value = 0;            
        public int bit12_value = 0;
        public int bit13_value = 0;
        public int bit14_value = 0;            
        public int bit15_value = 0;
        public int bit16_value = 0;
        public int bit17_value = 0;

        public int bit20_value = 0;
        public int bit21_value = 0;            
        public int bit22_value = 0;
        public int bit23_value = 0;
        public int bit24_value = 0;
        public int bit25_value = 0;
        public int bit26_value = 0;
        public int bit27_value = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
        }
        // Execute Palette Changes
        private void palette_btn0_Click(object sender, EventArgs e)
        {
            ColorDialog palette0 = new ColorDialog();
            palette0.ShowDialog();
            palette0_color = palette0.Color;
            setColors();
        }
        private void palette_btn1_Click(object sender, EventArgs e)
        {
            ColorDialog palette1 = new ColorDialog();
            palette1.ShowDialog();
            palette1_color = palette1.Color;
            setColors();
        }
        private void palette_btn2_Click(object sender, EventArgs e)
        {
            ColorDialog palette2 = new ColorDialog();
            palette2.ShowDialog();
            palette2_color = palette2.Color;
            setColors();
        }
        private void palette_btn3_Click(object sender, EventArgs e)
        {
            ColorDialog palette3 = new ColorDialog();
            palette3.ShowDialog();
            palette3_color = palette3.Color;
            setColors();
        }





        private int btnClickExecute(int currentBit)
        {
            currentBit = currentBit + 1;
            if (currentBit >= 4)
            {
                currentBit = 0;
            }

            return currentBit;
            return currentBit;
            return currentBit;
            return currentBit;
            return currentBit;        }

        //Set all colors
        private void setColors()
        {
            palette_btn0.BackColor = palette0_color;
            palette_btn1.BackColor = palette1_color;
            palette_btn2.BackColor = palette2_color;
            palette_btn3.BackColor = palette3_color;

            setBitColor(bit00_value, bit00);
        }

        private void setBitColor(int currentBitValue, Button currentBit)
        {
            switch (currentBitValue)
            {
                case 0:
                    currentBit.BackColor = palette0_color;
                    break;
                case 1:
                    currentBit.BackColor = palette1_color;
                    break;

                case 2:
                    currentBit.BackColor = palette2_color;
                    break;

                case 3:
                    currentBit.BackColor = palette3_color;
                    break;

            }
        }

        // Generate HEX value
        private string hexFirstValue(
            int bit3,
            int bit2, 
            int bit1, 
            int bit0
            )
        {
            string returnString = "0";
            int intValue = 0;

            intValue += 8 * isFirstBitSetted(bit3);
            intValue += 4 * isFirstBitSetted(bit2);
            intValue += 2 * isFirstBitSetted(bit1);
            intValue += 1 * isFirstBitSetted(bit0);


            switch (intValue)
            {
                case 10: returnString = "A";break;
                case 11: returnString = "B"; break;
                case 12: returnString = "C"; break;
                case 13: returnString = "D"; break;
                case 14: returnString = "E"; break;
                case 15: returnString = "F"; break;
                default:
                    returnString = intValue.ToString();
                    break;
            }

            return returnString;
        }

        private int isFirstBitSetted(int value)
        {
            int returnValue = 0;
            if(value == 3 ||  value == 2)
            {
                returnValue = 1;
            }
            return returnValue;
        }

        private int isSecondBitSetted(int value)
        {
            int returnValue = 0;
            if (value == 3 || value == 1)
            {
                returnValue = 1;
            }
            return returnValue;
        }





        private void getFirstByte()
        {
            firstByteTextbox.Text = hexFirstValue(0, 1, 2, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bit00_Click(object sender, EventArgs e)
        {
            bit00_value = btnClickExecute(bit00_value);
            setBitColor(bit00_value, bit00);
            getFirstByte();
        }

        private void bit01_Click(object sender, EventArgs e)
        {
            bit01_value = btnClickExecute(bit01_value);
            setBitColor(bit00_value, bit00);
            getFirstByte();
        }


    }
}
