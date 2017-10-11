using B4.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4
{
    public partial class Formtimkiem : Form
    {
        Bai4TTNEntities db = new Bai4TTNEntities();
        public Formtimkiem()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            db.Hangs.Load();
            dataGridView1.DataSource = db.Hangs.Local;
        }

        private void Formtimkiem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public IQueryable<Hang> timtatca(string find)
        {
            return db.Hangs.Where(p => p.Ten_hh.Contains(find));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aa = textBox1.Text.Trim();

            List<Hang> aaa = timtatca(aa).ToList();

            dataGridView1.DataSource = aaa;
        }
    }
}
