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

namespace NewStudPass
{
    public partial class Form3 : Form
    {
        private DataContext ctx;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ctx = new DataContext();

            /*
             using (ctx = new DataContext())
             
            {
                var p = new Person() { FirstName = "FName" };

                ctx.Persons.Add(p);
                ctx.SaveChanges();
            }
            */

            ctx.Persons.Load();
            personBindingSource.DataSource = ctx.Persons.Local;
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            (ctx ?? (ctx = new DataContext())).SaveChanges();
        }
    }
}
