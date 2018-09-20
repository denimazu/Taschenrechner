using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private bool buttonPlus_clicked = false;
        private bool buttonMinus_clicked = false;
        private bool buttonMal_clicked = false;
        private bool buttonTeilen_clicked = false;
        */

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxAusgabe.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText("0");
        }

        private void buttonKomma_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(",");
        }



        private void buttonSumme_Click(object sender, EventArgs e)
        {
            /*
            if (buttonPlus_clicked)
            {
                //1. Zahl aus dem Label, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string lblZahl2 = labelZwischenspeicher.Text.Replace(" + ", "");
                double sumDouble2 = double.Parse(lblZahl2);

                //2. Zahl aus dem Textbox, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string sumZahl1 = textBoxAusgabe.Text.Replace(" + ", "");
                double sumDouble1 = double.Parse(sumZahl1);
                double sumErgebnis = sumDouble2 + sumDouble1;

                buttonPlus_clicked = false;
                textBoxAusgabe.Clear();
                labelZwischenspeicher.Text = sumDouble2.ToString() + " + " + sumDouble1.ToString();
                textBoxAusgabe.Text = sumErgebnis.ToString();
                return;
            }
            else if (buttonMinus_clicked)
            {
                //1. Zahl aus dem Label, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string lblZahl2 = labelZwischenspeicher.Text.Replace(" - ", "");
                double sumDouble2 = double.Parse(lblZahl2);

                //2. Zahl aus dem Textbox, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string sumZahl1 = textBoxAusgabe.Text.Replace(" - ", "");
                double sumDouble1 = double.Parse(sumZahl1);
                double sumErgebnis = sumDouble2 - sumDouble1;

                buttonMinus_clicked = false;
                textBoxAusgabe.Clear();
                labelZwischenspeicher.Text = sumDouble2.ToString() + " - " + sumDouble1.ToString();
                textBoxAusgabe.Text = sumErgebnis.ToString();
                return;
            }
            else if (buttonMal_clicked)
            {
                //1. Zahl aus dem Label, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string lblZahl2 = labelZwischenspeicher.Text.Replace(" x ", "");
                double sumDouble2 = double.Parse(lblZahl2);

                //2. Zahl aus dem Textbox, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string sumZahl1 = textBoxAusgabe.Text.Replace(" x ", "");
                double sumDouble1 = double.Parse(sumZahl1);
                double sumErgebnis = sumDouble2 * sumDouble1;

                buttonMal_clicked = false;
                textBoxAusgabe.Clear();
                labelZwischenspeicher.Text = sumDouble2.ToString() + " x " + sumDouble1.ToString();
                textBoxAusgabe.Text = sumErgebnis.ToString();
                return;
            }
            else if (buttonTeilen_clicked)
            {
                //1. Zahl aus dem Label, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string lblZahl2 = labelZwischenspeicher.Text.Replace(" / ", "");
                double sumDouble2 = double.Parse(lblZahl2);

                //2. Zahl aus dem Textbox, Sonderzeichen werden ersetzt und anschließend in eine Variable gepackt
                string sumZahl1 = textBoxAusgabe.Text.Replace(" / ", "");
                double sumDouble1 = double.Parse(sumZahl1);
                double sumErgebnis = sumDouble2 / sumDouble1;

                buttonTeilen_clicked = false;
                textBoxAusgabe.Clear();
                labelZwischenspeicher.Text = sumDouble2.ToString() + " / " + sumDouble1.ToString();
                textBoxAusgabe.Text = sumErgebnis.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie erst eine Rechenoperation!");
                return;
            } */
        }


        private void buttonTeilen_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" / ");

            /*
            buttonTeilen_clicked = true;

            string strZahl1 = textBoxAusgabe.Text.Replace(" / ", "");
            double var1 = double.Parse(strZahl1);

            if (!string.IsNullOrEmpty(strZahl1))
            {
                double varToString = var1;
                string var2 = " / ";
                string lbltext = labelZwischenspeicher.Text;

                if (!string.IsNullOrEmpty(lbltext))
                {
                    labelZwischenspeicher.Text += varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
                else
                {
                    labelZwischenspeicher.Text = varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
            } */
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" x ");

            /*
            buttonMal_clicked = true;

            string strZahl1 = textBoxAusgabe.Text.Replace(" x ", "");
            double var1 = double.Parse(strZahl1);

            if (!string.IsNullOrEmpty(strZahl1))
            {
                double varToString = var1;
                string var2 = " x ";
                string lbltext = labelZwischenspeicher.Text;

                if (!string.IsNullOrEmpty(lbltext))
                {
                    labelZwischenspeicher.Text += varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
                else
                {
                    labelZwischenspeicher.Text = varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
            }
            */
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" - ");

            /*
            buttonMinus_clicked = true;

            string strZahl1 = textBoxAusgabe.Text.Replace(" - ", "");
            double var1 = double.Parse(strZahl1);

            if (!string.IsNullOrEmpty(strZahl1))
            {
                double varToString = var1;
                string var2 = " - ";
                string lbltext = labelZwischenspeicher.Text;

                if (!string.IsNullOrEmpty(lbltext))
                {
                    labelZwischenspeicher.Text += varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
                else
                {
                    labelZwischenspeicher.Text = varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
            }
            */
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" + ");

            /*
            buttonPlus_clicked = true;

            string strZahl1 = textBoxAusgabe.Text.Replace(" + ", "");
            double var1 = double.Parse(strZahl1);

            if (!string.IsNullOrEmpty(strZahl1))
            {
                double varToString = var1;
                string var2 = " + ";
                string lbltext = labelZwischenspeicher.Text;

                if (!string.IsNullOrEmpty(lbltext))
                {
                    labelZwischenspeicher.Text += varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
                else
                {
                    labelZwischenspeicher.Text = varToString.ToString() + var2.ToString();
                    textBoxAusgabe.Clear();
                }
            }
            */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string str = textBoxAusgabe.ToString();
            str = str.Replace("System.Windows.Forms.TextBox, Text: ", "");
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - 1);
                textBoxAusgabe.Text = str;
            }
            else
            {

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Clear();
            labelZwischenspeicher.Text = String.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //Zahl 0
                case (char)96:
                case (char)48:
                    e.Handled = true;
                    button0.PerformClick();
                    button0.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl1
                case (char)97:
                case (char)49:
                    e.Handled = true;
                    button1.PerformClick();
                    button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl2
                case (char)98:
                case (char)50:
                    e.Handled = true;
                    button2.PerformClick();
                    button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl3
                case (char)99:
                case (char)51:
                    e.Handled = true;
                    button3.PerformClick();
                    button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl4
                case (char)100:
                case (char)52:
                    e.Handled = true;
                    button4.PerformClick();
                    button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl5
                case (char)101:
                case (char)53:
                    e.Handled = true;
                    button5.PerformClick();
                    button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl6
                case (char)102:
                case (char)54:
                    e.Handled = true;
                    button6.PerformClick();
                    button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl7
                case (char)103:
                case (char)55:
                    e.Handled = true;
                    button7.PerformClick();
                    button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl8
                case (char)104:
                case (char)56:
                    e.Handled = true;
                    button8.PerformClick();
                    button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl9
                case (char)105:
                case (char)57:
                    e.Handled = true;
                    button9.PerformClick();
                    button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Additionstaste
                case (char)43:
                    e.Handled = true;
                    buttonPlus.PerformClick();
                    buttonPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Subtraktionstaste
                case (char)45:
                    e.Handled = true;
                    buttonMinus.PerformClick();
                    buttonMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Multiplikationstaste
                case (char)42:
                    e.Handled = true;
                    buttonMal.PerformClick();
                    buttonMal.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Divisionstaste
                case (char)47:
                    e.Handled = true;
                    buttonTeilen.PerformClick();
                    buttonTeilen.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Löschtaste
                case (char)8:
                    e.Handled = true;
                    buttonDelete.PerformClick();
                    buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Zahl 0
                case Keys.NumPad0:
                case Keys.D0:
                    e.Handled = true;
                    button0.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl1
                case Keys.NumPad1:
                case Keys.D1:
                    e.Handled = true;
                    button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl2
                case Keys.NumPad2:
                case Keys.D2:
                    e.Handled = true;
                    button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl3
                case Keys.NumPad3:
                case (char)51:
                    e.Handled = true;
                    button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl4
                case Keys.NumPad4:
                case (char)52:
                    e.Handled = true;
                    button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl5
                case Keys.NumPad5:
                case (char)53:
                    e.Handled = true;
                    button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl6
                case Keys.NumPad6:
                case (char)54:
                    e.Handled = true;
                    button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl7
                case Keys.NumPad7:
                case (char)55:
                    e.Handled = true;
                    button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl8
                case Keys.NumPad8:
                case (char)56:
                    e.Handled = true;
                    button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Zahl9
                case Keys.NumPad9:
                case (char)57:
                    e.Handled = true;
                    button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Additionstaste
                case Keys.Add:
                    e.Handled = true;
                    buttonPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Subtraktionstaste
                case (char)45:
                    e.Handled = true;
                    buttonMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Multiplikationstaste
                case (char)42:
                    e.Handled = true;
                    buttonMal.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Divisionstaste
                case (char)47:
                    e.Handled = true;
                    buttonTeilen.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
                //Löschtaste
                case (char)8:
                    e.Handled = true;
                    buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    break;
            }


            /* 
               switch (e.KeyCode)
               {
                   case Keys.NumPad9:
                       e.Handled = true;
                       button9.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad8:
                       e.Handled = true;
                       button8.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad7:
                       e.Handled = true;
                       button7.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad6:
                       e.Handled = true;
                       button6.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad5:
                       e.Handled = true;
                       button5.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad4:
                       e.Handled = true;
                       button4.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad3:
                       e.Handled = true;
                       button3.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad2:
                       e.Handled = true;
                       button2.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad1:
                       e.Handled = true;
                       button1.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
                   case Keys.NumPad0:
                       e.Handled = true;
                       button0.BackColor = System.Drawing.Color.LightSteelBlue;
                       break;
               }
           } 
           */
        }
    }
}