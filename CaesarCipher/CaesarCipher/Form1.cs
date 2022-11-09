using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public static string alhapet = "abcdefghijklmnopqrstuvwxyz";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //comboBox1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = textBox1.Text.ToLower();


            string result = "Result : ";
            int key;

            try
            {
                key = int.Parse(textBox2.Text);
                if (key == 0 || plainText == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter key and plainText ");
                return;
            }


            for (int i = 0; i < plainText.Length; i++)
            {
                int index = alhapet.IndexOf(plainText[i]);
                var newletter = (index + key ) % 26;
                result += alhapet[newletter];
            }
            label2.Text = result;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]")
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                    e.Handled = true ;
            }else
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string plainText = textBox1.Text.ToLower();


            string result = "Result : ";
            int key;

            try
            {
                key = int.Parse(textBox2.Text);
                if (key == 0 || plainText == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter key and plainText ");
                return;
            }


            for (int i = 0; i < plainText.Length; i++)
            {
                int index = alhapet.IndexOf(plainText[i]);
                //sdasdds
                //sadassda
                #region sectioncode 
                var newletter = Math.Abs(index - key) % 26;//step 1 
                if (key > index)
                    newletter = 26 - newletter;
                #endregion
                //bool greater = index < key;sds

                #region myCode 
                //var newletter = (index - key);
                //while (newletter < 0 )
                //{
                //    newletter += 26;
                //}
                //newletter = newletter % 26;
                #endregion


                result += alhapet[newletter];
            }
            label2.Text = result;
        }
    }
}
