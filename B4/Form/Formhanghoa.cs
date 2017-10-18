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
    public partial class Formhanghoa : Form
    {
        Bai4TTNEntities db = new Bai4TTNEntities();
        public Formhanghoa()
        {
            InitializeComponent();
        }

        void add()
        {
            if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    Hang kho = new Hang() { Ma_hh = tb_mahh.Text, Ten_hh = tb_tenhh.Text, Don_vi = tb_donvi.Text };
                    db.Hangs.Add(kho);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công", "Message");
                    tb_mahh.Text = "";
                    tb_tenhh.Text = "";
                    tb_donvi.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }

            }
        }
        void edit()
        {
            if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    string id = tb_mahh.Text;
                    Hang sv = db.Hangs.Find(id);
                    sv.Ten_hh = tb_tenhh.Text;
                    sv.Don_vi = tb_donvi.Text;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Message");
                    tb_mahh.Text = "";
                    tb_tenhh.Text = "";
                    tb_donvi.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }
            }

        }
        void del()
        {
            if (tb_mahh.Text == "" || tb_tenhh.Text == "") MessageBox.Show("Mã hh và tên hh không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    string id = tb_mahh.Text;
                    Hang sv = db.Hangs.Where(p => p.Ma_hh == id && p.Ten_hh == tb_tenhh.Text && p.Don_vi == tb_donvi.Text).SingleOrDefault();
                    db.Hangs.Remove(sv);
                    db.SaveChanges();
                    tb_mahh.Text = "";
                    tb_tenhh.Text = "";
                    tb_donvi.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            del();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
