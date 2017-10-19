using B4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Message", MessageBoxButtons.OKCancel) == DialogResult.Cancel) e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            var dao = new UserDao();
            var result = dao.Login(user, pass);
            if (result == 1)
            {
                this.Hide();
                Formmain frmmain = new Formmain();
                frmmain.ShowDialog();
                this.Show();
            }
            else if (result == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else if (result == -2)
            {
                MessageBox.Show("", "Tài khoản không đúng");
            }
            else
            {
                MessageBox.Show("", "Đăng nhập không đúng");
            }
        }
    }
}
