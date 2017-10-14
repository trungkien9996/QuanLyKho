using B4.Entity;
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
    public partial class FormPhieuXuat : Form
    {
        Bai4TTNEntities db = new Bai4TTNEntities();
        public FormPhieuXuat()
        {
            InitializeComponent();
            loadcb();
        }

        public void loadcb()
        {
            comboBox1.DataSource = db.Khoes.ToList();
            comboBox1.DisplayMember = "Ten_kho";
            comboBox1.ValueMember = "Ma_kho";
        }

        void add()
        {
            if (tb_maPX.Text == "") MessageBox.Show("Mã pn không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    PhieuNhap kho = new PhieuNhap() { Ma_PN = tb_maPX.Text, Ma_kho = comboBox1.SelectedValue.ToString(), Ngay_nhap = Convert.ToDateTime(dateTimePicker1.Text) };
                    db.PhieuNhaps.Add(kho);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công", "Message");
                    tb_maPX.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }

            }
        }
        //void edit()
        //{
        //    if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
        //    else
        //    {
        //        try
        //        {
        //            string id = tb_mahh.Text;
        //            Hang sv = db.Hangs.Find(id);
        //            sv.Ten_hh = tb_tenhh.Text;
        //            sv.Don_vi = tb_donvi.Text;
        //            db.SaveChanges();
        //            MessageBox.Show("Sửa thành công", "Message");
        //            tb_mahh.Text = "";
        //            tb_tenhh.Text = "";
        //            tb_donvi.Text = "";
        //        }
        //        catch (Exception exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "ERROR");
        //        }
        //    }

        //}
        void del()
        {
            if (tb_maPX.Text == "") MessageBox.Show("Mã PN không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    string id = tb_maPX.Text;
                    PhieuNhap sv = db.PhieuNhaps.Where(p => p.Ma_PN == id && p.Ma_kho == comboBox1.SelectedValue.ToString() && p.Ngay_nhap == Convert.ToDateTime(dateTimePicker1.Text)).SingleOrDefault();
                    db.PhieuNhaps.Remove(sv);
                    db.SaveChanges();
                    tb_maPX.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }
            }
        }

        private void bt_lapphieu_Click(object sender, EventArgs e)
        {
            add();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            del();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {

        }
    }
}
