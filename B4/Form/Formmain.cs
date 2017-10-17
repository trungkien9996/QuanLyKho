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
