using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] katanya;
        private void btn_play_Click(object sender, EventArgs e)
        {
            katanya = new string[5];
            katanya[0] = tb_kata1.Text;
            katanya[1] = tb_kata2.Text;
            katanya[2] = tb_kata3.Text;
            katanya[3] = tb_kata4.Text;
            katanya[4] = tb_kata5.Text;


            bool angka = false;
            foreach (string k in katanya) 
            {
                foreach(char a in k)
                {
                    if(!char.IsLetter(a))
                    {
                        angka = true;
                    }
                }
            }

            Random tebakkata = new Random();
            for (int i = katanya.Length - 1; i>0; i--)
            {
                int j = tebakkata.Next(0, i + 1);
                string temp = katanya[i];
                katanya[i] = katanya[j];
                katanya[j] = temp;
            }
         
            if (tb_kata1.Text.Length != 5 || tb_kata2.Text.Length != 5 || tb_kata3.Text.Length != 5 || tb_kata4.Text.Length != 5 || tb_kata5.Text.Length != 5)
            {
                MessageBox.Show("There's still an error");
            }
            else if (tb_kata1.Text == tb_kata5.Text || tb_kata1.Text == tb_kata4.Text || tb_kata1.Text == tb_kata3.Text || tb_kata1.Text == tb_kata2.Text || tb_kata2.Text == tb_kata5.Text || tb_kata2.Text == tb_kata4.Text || tb_kata2.Text == tb_kata3.Text || tb_kata3.Text == tb_kata4.Text || tb_kata3.Text == tb_kata5.Text || tb_kata4.Text == tb_kata5.Text)
            {
                MessageBox.Show("There's still an error");
            }
            else
            {
                MessageBox.Show("Let's play");
                Form2 muncul = new Form2();
                muncul.Show();
                this.Hide();
            }

        }

       
    }
}
