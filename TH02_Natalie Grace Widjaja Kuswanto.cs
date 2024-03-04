using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02
{
    public partial class Form2 : Form
    {
        public List<string> kata;
        private Random rnd = new Random();
        List<char> word = new List<char>();
        List<char> show = new List<char>();
        string katarhs;
        public Form2()
        {
            InitializeComponent();
            this.kata = kata;
           
            int randomindex = rnd.Next(Form1.katanya.Length);
            lb_katadipilih.Text = Form1.katanya[randomindex];
            katarhs = lb_katadipilih.Text;
            foreach(char k in katarhs)
            {
                word.Add(k);
            }
        }

        private void lb_katadipilih_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            lb_katadipilih.Text = katarhs;
            show.Add('_');
            show.Add('_');
            show.Add('_');
            show.Add('_');
            show.Add('_');
        }

        private void Tebak(char huruf)
        {
   
            for (int i=0; i <5; i++)
            {
                    if (word[i] == huruf)
                    {
                        show[i] = huruf;
                    }
            }
            
            lb_huruf1.Text = show[0].ToString();
            lb_huruf2.Text = show[1].ToString();
            lb_huruf3.Text = show[2].ToString();
            lb_huruf4.Text = show[3].ToString();
            lb_huruf5.Text = show[4].ToString();

            if(lb_huruf1.Text != "_" && lb_huruf2.Text != "_" && lb_huruf3.Text != "_" && lb_huruf4.Text != "_" && lb_huruf5.Text != "_")
            {
                MessageBox.Show("You win!");
            }
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            char huruf = 'a';
            Tebak(huruf);
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            char huruf = 'b';
            Tebak(huruf);
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            char huruf = 'c';
            Tebak(huruf);
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            char huruf = 'd';
            Tebak(huruf);
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            char huruf = 'e';
            Tebak(huruf);
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            char huruf = 'f';
            Tebak(huruf);
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            char huruf = 'g';
            Tebak(huruf);
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            char huruf = 'h';
            Tebak(huruf);
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            char huruf = 'i';
            Tebak(huruf);
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            char huruf = 'j';
            Tebak(huruf);
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            char huruf = 'k';
            Tebak(huruf);
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            char huruf = 'l';
            Tebak(huruf);
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            char huruf = 'm';
            Tebak(huruf);
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            char huruf = 'n';
            Tebak(huruf);
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            char huruf = 'o';
            Tebak(huruf);
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            char huruf = 'p';
            Tebak(huruf);
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            char huruf = 'q';
            Tebak(huruf);
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            char huruf = 'r';
            Tebak(huruf);
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            char huruf = 's';
            Tebak(huruf);
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            char huruf = 't';
            Tebak(huruf);
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            char huruf = 'u';
            Tebak(huruf);
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            char huruf = 'v';
            Tebak(huruf);
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            char huruf = 'w';
            Tebak(huruf);
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            char huruf = 'x';
            Tebak(huruf);
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            char huruf = 'y';
            Tebak(huruf);
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            char huruf = 'z';
            Tebak(huruf);
        }
    }
}

