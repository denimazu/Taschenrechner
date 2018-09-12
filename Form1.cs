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

        private bool buttonPlus_clicked = false;
        private bool buttonMinus_clicked = false;
        private bool buttonMal_clicked = false;
        private bool buttonTeilen_clicked = false;

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
            }
            
        }

        private void buttonTeilen_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" / ");

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
            }
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" x ");

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
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" - ");

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
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.AppendText(" + ");

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
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Clear();
            labelZwischenspeicher.Text = String.Empty;
        }
    }
}