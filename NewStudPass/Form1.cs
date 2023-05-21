using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStudPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataContext ctx;

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ctx = new DataContext())
            {
                var p = new Person() { FirstName = "FName" };

                ctx.Persons.Add(p);
                ctx.SaveChanges();
            }

            using (ctx = new DataContext())
            {

            }
        }
    }
}
