using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool sw = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "테스트폼";
            button1.Text = "누르시오";
        }

        private void Event(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button seledBtn = sender as Button;
                if (!sw)
                {
                    MessageBox.Show("버튼이구만~!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    seledBtn.Text = "누르면터짐";
                    sw = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    sw = false;
                    this.Text = "뻥~! X.X";
                    MessageBox.Show("엌!!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }

            }
            else if(sender is CheckBox)
            {
                CheckBox selectedCB = sender as CheckBox;
                if (selectedCB.Name == "checkBox1")
                {
                    if (selectedCB.Checked)
                        textBox1.PasswordChar = '\0';
                    else
                        textBox1.PasswordChar = '★';                    
                }
            }
            else if (sender is TextBox)
            {
                TextBox SeledTB = sender as TextBox;
                if (SeledTB.TextLength == 0)
                {
                    MessageBox.Show(SeledTB.Name.ToString() + "입력안됨요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                string type = sender.GetType().ToString();
                MessageBox.Show("버튼말고 다른거구먼 " + type , "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
