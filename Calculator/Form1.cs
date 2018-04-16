using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;  //获取或设置一个值，该值指示在将键事件传递到具有焦点的控件前，窗体是否将接收此键事件。
            this.txtSum.Text = "0";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DelText();
        }
        public void DelText()
        {
            if (this.txtSum.Text.Trim().Length >= 1 && IsEnd == false)
            {
                if (this.txtSum.Text.Trim().Length == 1)
                {
                    this.txtSum.Text = "0";
                    return;
                }
                this.txtSum.Text = this.txtSum.Text.Substring(0, this.txtSum.Text.Length - 1);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DelText();
            }
            if (IsClear == true || IsEnd == true)
            {
                this.txtSum.Clear();
            }
            if (this.txtSum.Text == "0" && e.KeyCode != Keys.Decimal)
            {
                this.txtSum.Clear();
            }
            if (this.txtSum.Text.Contains(".") && e.KeyCode == Keys.Decimal)
            {
                return;
            }
            if (this.txtSum.Text.Length == 0 && e.KeyCode == Keys.Decimal)
            {
                return;
            }
            if (e.KeyCode == Keys.D1)
            {
                this.txtSum.Text += "1";
                this.txtShow.Text += "1";
            }
            if (e.KeyCode == Keys.D2)
            {
                this.txtSum.Text += "2";
                this.txtShow.Text += "2";
            }
            if (e.KeyCode == Keys.D3)
            {
                this.txtSum.Text += "3";
                this.txtShow.Text += "3";
            }
            if (e.KeyCode == Keys.D4)
            {
                this.txtSum.Text += "4";
                this.txtShow.Text += "4";
            }
            if (e.KeyCode == Keys.D5)
            {
                this.txtSum.Text += "5";
                this.txtShow.Text += "5";
            }
            if (e.KeyCode == Keys.D6)
            {
                this.txtSum.Text += "6";
                this.txtShow.Text += "6";
            }
            if (e.KeyCode == Keys.D7)
            {
                this.txtSum.Text += "7";
                this.txtShow.Text += "7";
            }
            if (e.KeyCode == Keys.D8)
            {
                this.txtSum.Text += "8";
                this.txtShow.Text += "8";
            }
            if (e.KeyCode == Keys.D9)
            {
                this.txtSum.Text += "9";
                this.txtShow.Text += "9";
            }
            if (e.KeyCode == Keys.D0)
            {
                this.txtSum.Text += "0";
                this.txtShow.Text += "0";
            }
            IsClear = false;
            IsEnd = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (IsClear == true || IsEnd == true)
            {
                this.txtSum.Clear();
            }
            Button button = (Button)sender;
            if (this.txtSum.Text == "0" && button != this.btnDian)
            {
                this.txtSum.Clear();
            }
            if (this.txtSum.Text.Contains(".") && button == this.btnDian)
            {
                return;
            }
            if (this.txtSum.Text.Length == 0 && button == this.btnDian)
            {
                this.txtSum.Text = "0";
                return;
            }
            GetTag(button);
            IsClear = false;
            IsEnd = false;
        }
        public void GetTag(Button b)
        {
            string s = b.Tag.ToString();
            this.txtSum.Text += s;
            if (this.txtShow.Text == "+" || this.txtShow.Text == "-" || this.txtShow.Text== "×" || this.txtShow.Text == "÷")
            {
                this.txtShow.Text = string.Empty;
            }
            this.txtShow.Text += s;
        }
        public bool IsClear = false;
        public bool IsEnd = false;
        public static double A = 0;
        public static double B = 0;
        public double C = 0;
        public int Count = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            Maths();
            this.txtShow.Clear();
            A = 0;
            B = 0;
            C = 0;
            Count = 0;
        }
        public void Maths()
        {
            if (this.txtSum.Text.Trim().Length == 0)
            {
                return;
            }
            B = double.Parse(this.txtSum.Text);
            S.A = A;
            S.B = B;
            C= S.Math();
            A = C;
            this.txtSum.Text = C.ToString();
            IsEnd = true;
        }
        public Sum S = new Sum (A,B);
        public void Suan(string a)
        {
            if (this.txtSum.Text.Trim().Length == 0)
            {
                return;
            }
            Count++;
            IsClear = true;
            if (Count<=1)
            {
                A = double.Parse(this.txtSum.Text);
            }
            if (this.txtShow.Text.Trim().Length != 0)
            {
                int index = this.txtShow.Text.Length-1 ;
                if (this.txtShow.Text.Substring(index) == "+" || this.txtShow.Text.Substring(index) == "-" || this.txtShow.Text.Substring(index) == "×" || this.txtShow.Text.Substring(index) == "÷")
                {
                    this.txtShow.Text = this.txtShow.Text.Substring(0,index);
                }
            }
            this.txtShow.Text += a;
            if (Count > 1)
            {
                Maths();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Add a = new Add(A, B);
            string b = "+";
            S = a;
            Suan(b);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Del a = new Del(A, B);
            string b = "-";
            S = a;
            Suan(b);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cheng a = new Cheng(A, B);
            string b = "×";
            S = a;
            Suan(b);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Chu a = new Chu(A, B);
            string b = "÷";
            S = a;
            Suan(b);
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.PowderBlue;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Azure;
        }
    }
}
