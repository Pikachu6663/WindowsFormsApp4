﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.DBCon;

namespace WindowsFormsApp4
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

      

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (int i in MainForm.JuriList)
            {
                User user = DBConst.model.User.Find(i);
                UserControJuri usercontr = new UserControJuri();
                usercontr.Fill(user, number);
                flowLayoutPanel1.Controls.Add (usercontr);
                number++;
            }    
        }
    }
}