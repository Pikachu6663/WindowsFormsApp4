using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.DBCon;

namespace WindowsFormsApp4
{
    public partial class UserControJuri : UserControl
    {
        public UserControJuri()
        {
            InitializeComponent();
        }
            
        private void UserControJuri_Load(object sender, EventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Fill(User user, int number)
        {

            labelName.Text = "Жюри - " + number.ToString();
            userBindingSource.DataSource = user;
        }
    }
}
