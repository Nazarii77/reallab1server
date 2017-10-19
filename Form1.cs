using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weblab1Forms.weblab1;

namespace weblab1Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void reload() {
            this.usersTableAdapter.Fill(this.dataSet11.Users);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet11.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {//ADD
            using (UserContext db = new UserContext())
            {
                String username = textBox1.Text.ToString();
                int userage =Int32.Parse(textBox2.Text) ;

                User user1 = new User { Name = username, Age = userage };
               

                db.Users.Add(user1);
                
                db.SaveChanges();
               
            }
            reload();

        }

        private void button2_Click(object sender, EventArgs e)
        {//DELETE


            using (UserContext db = new UserContext())
            {
                // за іменем видалення
                //String username = textBox1.Text.ToString();
               // User user1 = new User { Name = username };

                //видалення по id
                int userid = Int32.Parse(textBox3.Text);
                User user1 = new User { Id= userid };
                //

                db.Users.Attach(user1);
                db.Users.Remove(user1);

                db.SaveChanges();

            }
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {//EDIT якщо нема по ід то додає 
            using (UserContext db = new UserContext())
            {
                int userid = Int32.Parse(textBox3.Text);
                String username = textBox1.Text.ToString();
                int userage = Int32.Parse(textBox2.Text);

                User user1 = new User { Name = username, Age = userage ,Id = userid };


                db.Users.AddOrUpdate(user1);

                db.SaveChanges();

            }
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show(); // Shows Form2

            reload();
        }
    }
}
