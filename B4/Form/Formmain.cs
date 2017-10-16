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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
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
        //void del()
        //{
        //    if (tb_maPN.Text == "") MessageBox.Show("Mã PN không đc để trống", "Cảnh báo");
        //    else
        //    {
        //        try
        //        {
        //            string id = tb_maPN.Text;
        //            PhieuNhap sv = db.PhieuNhaps.Where(p => p.Ma_PN == id && p.Ma_kho == comboBox1.SelectedValue.ToString() && p.Ngay_nhap == Convert.ToDateTime(dateTimePicker1.Text)).SingleOrDefault();
        //            db.PhieuNhaps.Remove(sv);
        //            db.SaveChanges();
        //            tb_maPN.Text = "";
        //        }
        //        catch (Exception exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "ERROR");
        //        }
        //    }
        //}
        private void xuấtKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhieuNhap from = new FormPhieuNhap();
            from.ShowDialog();
            this.Show();
        }

        private void nhậpKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhap from = new FormNhap();
            from.ShowDialog();
            this.Show();
        }

        private void lậpPhiếuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhieuXuat from = new FormPhieuXuat();
            from.ShowDialog();
            this.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXuat from = new FormXuat();
            from.ShowDialog();
            this.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKho from = new FormKho();
            from.ShowDialog();
            this.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhanghoa from = new Formhanghoa();
            from.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formtimkiem from = new Formtimkiem();
            from.ShowDialog();
            this.Show();
        }

        private void hướngDẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
