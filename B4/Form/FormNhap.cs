﻿using B4.Entity;
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
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
