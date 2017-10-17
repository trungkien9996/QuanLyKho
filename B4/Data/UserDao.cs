using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B4.Entity;

namespace B4.Data
{
    public class UserDao
    {
        Bai4TTNEntities db = null;
        public UserDao()
        {
            db = new Bai4TTNEntities();
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

        public User GetById(String userName)
        {
            return db.Users.SingleOrDefault(x => x.Name == userName);
        }
        public int Login(string userName, string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.Name == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Pass == passWord)
                    return 1;
                else
                    return -2;
            }
        }
    }
}
