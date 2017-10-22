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
    public partial class FormNhap : Form
    {
        Bai4TTNEntities db = new Bai4TTNEntities();
        public FormNhap()
        {
            InitializeComponent();
            loadcb();
        }

        public void loadcb()
        {


            comboBox3.DataSource = db.Khoes.ToList();
            comboBox3.DisplayMember = "Ten_kho";
            comboBox3.ValueMember = "Ma_kho";

            comboBox1.DataSource = db.PhieuNhaps.ToList();
            comboBox1.DisplayMember = "Ma_PN";
            comboBox1.ValueMember = "Ma_PN";

        }

        void add()
        {
            if (tb_mahang.Text == "" || tb_soluong.Text == "") MessageBox.Show("Mã hh và số lượng không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    Detail_PN kho = new Detail_PN() { Ma_PN = comboBox1.SelectedValue.ToString(), Ma_kho = comboBox1.SelectedValue.ToString(), Ma_hh = tb_mahang.Text };
                    db.Detail_PN.Add(kho);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công", "Message");
                    tb_mahang.Text = "";
                    tb_soluong.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }

            }
        }
        //void edit()
        //{
        //    if (tb_mahang.Text == "" || tb_soluong.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
        //    else
        //    {
        //        try
        //        {
        //            string id = tb_mahang.Text;
        //            PhieuNhap sv = db.PhieuNhaps.Find(id);
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
        //void del()
        //{
        //    if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
        //    else
        //    {
        //        try
        //        {
        //            string id = tb_mahh.Text;
        //            Hang sv = db.Hangs.Where(p => p.Ma_hh == id && p.Ten_hh == tb_tenhh.Text && p.Don_vi == tb_donvi.Text).SingleOrDefault();
        //            db.Hangs.Remove(sv);
        //            db.SaveChanges();
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

        private void bt_nhập_Click(object sender, EventArgs e)
        {
            add();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
