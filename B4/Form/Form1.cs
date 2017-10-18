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


        //public void loadcb()
        //{
        //    comboBox1.DataSource = db.Khoes.ToList();
        //    comboBox1.DisplayMember = "Ten_kho";
        //    comboBox1.ValueMember = "Ma_kho";
        //}

        //void add()
        //{
        //    if (tb_maPN.Text == "") MessageBox.Show("Mã pn không đc để trống", "Cảnh báo");
        //    else
        //    {
        //        try
        //        {
        //            PhieuNhap kho = new PhieuNhap() { Ma_PN = tb_maPN.Text, Ma_kho = comboBox1.SelectedValue.ToString(), Ngay_nhap = Convert.ToDateTime(dateTimePicker1.Text) };
        //            db.PhieuNhaps.Add(kho);
        //            db.SaveChanges();
        //            MessageBox.Show("Thêm mới thành công", "Message");
        //            tb_maPN.Text = "";
        //        }
        //        catch (Exception exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "ERROR");
        //        }

        //    }
        //}
        ////void edit()
        ////{
        ////    if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
        ////    else
        ////    {
        ////        try
        ////        {
        ////            string id = tb_mahh.Text;
        ////            Hang sv = db.Hangs.Find(id);
        ////            sv.Ten_hh = tb_tenhh.Text;
        ////            sv.Don_vi = tb_donvi.Text;
        ////            db.SaveChanges();
        ////            MessageBox.Show("Sửa thành công", "Message");
        ////            tb_mahh.Text = "";
        ////            tb_tenhh.Text = "";
        ////            tb_donvi.Text = "";
        ////        }
        ////        catch (Exception exp)
        ////        {
        ////            MessageBox.Show(exp.ToString(), "ERROR");
        ////        }
        ////    }

        ////}
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
