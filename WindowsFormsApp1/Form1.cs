﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.02");
            comboBox2.Items.Add("INF.03");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;


            if (textBox1.Text.Length == 0)
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;


            if (textBox2.Text.Length == 0)
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;


            if (textBox5.Text.Length == 0)
            {
                textBox5.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;


            if (textBox3.Text.Length == 0)
            {
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;


            if (maskedTextBox4.Text.Length == 0)
            {
                maskedTextBox4.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;


            if (textBox4.Text.Length == 0)
            {
                textBox4.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
                label13.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";

            if (comboBox2.SelectedIndex == 1)
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz\r\nbazami danych";

            if (comboBox2.SelectedIndex == 2)
                label13.Text = "Projektowanie, programowanie i testowanie aplikacji";
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

        private void wypisz_Click(object sender, EventArgs e)
        {
            {
                pole.AppendText(Environment.NewLine);
                pole.AppendText("Deklaruje przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie");
                pole.AppendText(Environment.NewLine);
                pole.AppendText("przeprowadzanego w terminie: " + comboBox1.SelectedItem.ToString());
                pole.AppendText(Environment.NewLine);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("Dane osobowe ucznia");
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Nazwisko: \t\t" + textBox1.Text.ToUpper());
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Imie: \t \t\t" + textBox2.Text.ToUpper());
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Data i miejsce urodzenia:\t" + maskedTextBox2.Text + textBox5.Text.ToUpper());
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Numer PESEL: \t\t" + maskedTextBox1.Text);
                pole.AppendText(Environment.NewLine);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("Adres korespondecyjny");
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Miejscowość: \t\t" + textBox3.Text);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Ulica i numer domu: \t" + textBox4.Text);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Kod pocztowy i poczta: \t" + maskedTextBox3.Text + ", " + maskedTextBox3.Text);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Nr telefonu z kierunkowym: \t" + maskedTextBox5.Text);
                pole.AppendText(Environment.NewLine);
                pole.AppendText("  Mail: \t\t\t" + textBox7.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            maskedTextBox5.Text = null;
            textBox7.Text = null;
            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;
            maskedTextBox3.Text = null;
            maskedTextBox4.Text = null;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.BackColor = Color.White;


            if (maskedTextBox2.Text.Count(C => C == '_') == 0)
            {
                maskedTextBox2.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;

            if (maskedTextBox1.Text.Count(C => C == '_') == 0)
            {
                maskedTextBox1.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }

            if (!((maskedTextBox1.Text[9] - '0' % 2 == 0) && (textBox2.Text.Last() == 'A')))
            {
                maskedTextBox1.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox3.BackColor = Color.White;


            if (maskedTextBox3.Text.Count(C => C == '_') == 0)
            {
                maskedTextBox3.BackColor = Color.Red;
                MessageBox.Show("Blad");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;


            if (textBox7.Text.Length == 0)
            {
                textBox7.BackColor = Color.Red;
            }

            Regex regEmail;
            regEmail = new Regex(@"^[a-z][a-z--9_]*@[a-z0-9]*\.[a-z]{2,3}$");

            if (!regEmail.IsMatch(textBox7.Text))
            {
                textBox7.BackColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.03");
            comboBox2.Items.Add("INF.04");

        }

        private void pole_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter ="txt files (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            using (var stream = new StreamWriter(dialog.FileName))
            {
                stream.WriteLine(pole.Text);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <'A' || e.KeyChar > 'Z') && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != '/' && !char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            maskedTextBox5.BackColor = Color.White;


                if (maskedTextBox5.Text.Length == 0)
                {
                maskedTextBox5.BackColor = Color.Red;
                    MessageBox.Show("Blad");
                }
        }
    }
}

