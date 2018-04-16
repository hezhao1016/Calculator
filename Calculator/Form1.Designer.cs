namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDian = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnDian);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.txtShow);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 261);
            this.panel1.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Azure;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(12, 222);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 27);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "←";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btnDel.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Azure;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(115, 222);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 27);
            this.button16.TabIndex = 2;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button16.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.button16.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Azure;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(12, 183);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 27);
            this.btn0.TabIndex = 2;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            this.btn0.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn0.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btnDian
            // 
            this.btnDian.BackColor = System.Drawing.Color.Azure;
            this.btnDian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDian.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDian.Location = new System.Drawing.Point(104, 183);
            this.btnDian.Name = "btnDian";
            this.btnDian.Size = new System.Drawing.Size(40, 27);
            this.btnDian.TabIndex = 2;
            this.btnDian.Tag = ".";
            this.btnDian.Text = ".";
            this.btnDian.UseVisualStyleBackColor = false;
            this.btnDian.Click += new System.EventHandler(this.btn1_Click);
            this.btnDian.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btnDian.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Azure;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(150, 183);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 27);
            this.button13.TabIndex = 2;
            this.button13.Tag = "÷";
            this.button13.Text = "÷";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button13.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.button13.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Azure;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(150, 150);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 27);
            this.button12.TabIndex = 2;
            this.button12.Tag = "×";
            this.button12.Text = "×";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button12.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.button12.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Azure;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(150, 117);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 27);
            this.button11.TabIndex = 2;
            this.button11.Tag = "-";
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button11.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.button11.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Azure;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.Location = new System.Drawing.Point(104, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 27);
            this.btn9.TabIndex = 2;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            this.btn9.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn9.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Azure;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.Location = new System.Drawing.Point(104, 117);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 27);
            this.btn6.TabIndex = 2;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            this.btn6.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn6.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Azure;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.Location = new System.Drawing.Point(58, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 27);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            this.btn8.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn8.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Azure;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(150, 84);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 27);
            this.button10.TabIndex = 2;
            this.button10.Tag = "+";
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.button10.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Azure;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.Location = new System.Drawing.Point(58, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 27);
            this.btn5.TabIndex = 2;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            this.btn5.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn5.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Azure;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(104, 84);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 27);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            this.btn3.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Azure;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 27);
            this.btn7.TabIndex = 2;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            this.btn7.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn7.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Azure;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(58, 84);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 27);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            this.btn2.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Azure;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(12, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 27);
            this.btn4.TabIndex = 2;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            this.btn4.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn4.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Azure;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(12, 84);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 27);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // txtShow
            // 
            this.txtShow.BackColor = System.Drawing.Color.AliceBlue;
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtShow.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShow.Location = new System.Drawing.Point(12, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(185, 22);
            this.txtShow.TabIndex = 1;
            this.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSum.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSum.Location = new System.Drawing.Point(12, 34);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(185, 35);
            this.txtSum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDian;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtShow;
    }
}

