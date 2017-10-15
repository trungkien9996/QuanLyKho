using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B4.Entity;

namespace B4
{
    public partial class FormKho : Form
    {
        Bai4TTNEntities db = new Bai4TTNEntities();
        public FormKho()
        {
            InitializeComponent();
        }

        void add()
        {
            if (tb_makho.Text == "" || tb_tenkho.Text == "") MessageBox.Show("Mã kho và tên kho không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    Kho kho = new Kho() { Ma_kho = tb_makho.Text, Ten_kho = tb_tenkho.Text };
                    db.Khoes.Add(kho);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công", "Message");
                    tb_makho.Text = "";
                    tb_tenkho.Text = "";
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }

            }
        }
        void edit()
        {
            if (tb_makho.Text == "" || tb_tenkho.Text == "") MessageBox.Show("Mã kho và tên kho không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    string id = tb_makho.Text;
                    Kho sv = db.Khoes.Find(id);
                    sv.Ten_kho = tb_makho.Text;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Message");
                    tb_makho.Text = "";
                    tb_tenkho.Text = "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }
            }

        }
        void del()
        {
            if (tb_makho.Text == "" || tb_tenkho.Text == "") MessageBox.Show("Mã kho và tên kho không đc để trống", "Cảnh báo");
            else
            {
                try
                {
                    string id = tb_makho.Text;
                    Kho sv = db.Khoes.Where(p => p.Ma_kho == id && p.Ten_kho == tb_tenkho.Text).SingleOrDefault();
                    db.Khoes.Remove(sv);
                    db.SaveChanges();
                    tb_makho.Text = "";
                    tb_tenkho.Text = "";
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

        private void tb_makho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
