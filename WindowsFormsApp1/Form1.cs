using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Deklaracja : Form
    {
        public Deklaracja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox5.Text.ToUpper();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.ToUpper();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox4.Text = maskedTextBox4.Text.ToUpper();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.ToUpper();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText("Deklaruje przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;
            maskedTextBox3.Text = null;
            maskedTextBox4.Text = null;
        }        

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void wypisz_TextChanged(object sender, EventArgs e)
        {
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText("Deklaruje przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie");
            wypisz.AppendText(Environment.NewLine);
           // wypisz.AppendText("przeprowadzanego w terminie: " + termin.SelectedItem.ToString());
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText("Dane osobowe ucznia");
            wypisz.AppendText(Environment.NewLine);
          //  wypisz.AppendText("  Nazwisko: \t\t" + nazwisko.Text.ToUpper());
            wypisz.AppendText(Environment.NewLine);
         //   wypisz.AppendText("  Imie: \t \t\t" + imie.Text.ToUpper());
            wypisz.AppendText(Environment.NewLine);
        //    wypisz.AppendText("  Data i miejsce urodzenia:\t" + data.Text + miejsce.Text.ToUpper());
            wypisz.AppendText(Environment.NewLine);
         //   wypisz.AppendText("  Numer PESEL: \t\t" + pesel.Text);
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText(Environment.NewLine);
            wypisz.AppendText("Adres korespondecyjny");
            wypisz.AppendText(Environment.NewLine);
           // wypisz.AppendText("  Miejscowość: \t\t" + miejscowosc.Text);
            wypisz.AppendText(Environment.NewLine);
           // wypisz.AppendText("  Ulica i numer domu: \t" + ulinr.Text);
            wypisz.AppendText(Environment.NewLine);
         //   wypisz.AppendText("  Kod pocztowy i poczta: \t" + kodpoczt.Text + ", " + poczta.Text);
            wypisz.AppendText(Environment.NewLine);
        //    wypisz.AppendText("  Nr telefonu z kierunkowym: \t" + nrtel.Text);
            wypisz.AppendText(Environment.NewLine);
       //     wypisz.AppendText("  Mail: \t\t\t" + mail.Text);
        }
    }

}

