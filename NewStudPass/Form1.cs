using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var p = (Person)personBindingSource.Current;
            p.InternetSources.Add(new InternetSource(){NameOf = "VK id"});
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var p = (Person)personBindingSource.Current;
            p.InternetSources.Add(new InternetSource() { NameOf = "OK id" });
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var p = (Person)personBindingSource.Current;
            p.InternetSources.Add(new InternetSource() { NameOf = "VK id" });
            p.InternetSources.Add(new InternetSource() { NameOf = "OK id" });
            p.InternetSources.Add(new InternetSource() { NameOf = "Tik Toc" });
            p.InternetSources.Add(new InternetSource() { NameOf = "Instagramm" });
            p.InternetSources.Add(new InternetSource() { NameOf = "Facebook" });
            p.InternetSources.Add(new InternetSource() { NameOf = "Moodle" });

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var p = (Person)personBindingSource.Current;
            Address a = new Address()
            {
                Apartment = "00",
                State = "Russia",
                Region = "Nord-West",
                Province = "Pskov obl",
                City = "Pskov",
                Street = "Lenina",
                Home = "8 / 2",
                PostalCode = "180000",
                Comment = "Main / Second"
            };
            p.Addresss.Add(a);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.ShowDialog();
        }
    }
}
