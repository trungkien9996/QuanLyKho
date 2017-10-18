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

     
    }
}
