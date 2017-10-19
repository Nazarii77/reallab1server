using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace weblab1Forms
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();

            var selectionIndex = textBox1.SelectionStart;
            imgtextbox.Text = imgtextbox.Text.Insert(selectionIndex , "F:\\serverne web program\\IMAGES\\2.jpg");
        }
        
             
        private void button1_Click(object sender, EventArgs e)
        {//ADD
            using (booksContext db = new booksContext())
            {
                String bookname = textBox4.Text.ToString();
                int bookyear = Int32.Parse(textBox2.Text);
                String bookdescription = textBox1.Text.ToString();
                // int bookid = Int32.Parse(textBox3.Text);
                String imgstorage = "F:\\serverne web program\\IMAGES\\2.jpg";

                // byte[] bookimage = ImageToByteArray(pictureBoxCompanyLogo.Image, pictureBoxCompanyLogo);

                byte[] bookimage =  imageToByteArray(pictureBoxCompanyLogo.Image );



                ///image
                ///                  
                FileStream fs;
                BinaryReader br;
                string FileName = imgtextbox.Text;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                ///images


               // MessageBox.Show(ImageData.ToString() );
                try
                {
                    books book1 = new books { name = bookname, year = bookyear, description = bookdescription  , myimage = bookimage };
                    db.books.Add(book1);

                    db.SaveChanges();

                }
                catch (Exception e11)
                {
                   MessageBox.Show ("{0} Exception caught."+ e11.ToString() );
                }


            }
            this.booksTableAdapter.Fill(this.web_lab1db_resDataSet1.books);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mynewimage.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter3.Fill(this.mynewimage.books);
            // TODO: This line of code loads data into the 'mybooks.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter2.Fill(this.mybooks.books);
            // TODO: This line of code loads data into the 'web_lab1db_resDataSet2.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.web_lab1db_resDataSet2.books);
            // TODO: This line of code loads data into the 'web_lab1db_resDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.web_lab1db_resDataSet1.books);
            // TODO: This line of code loads data into the 'web_lab1db_resDataSet.book' table. You can move, or remove it, as needed.
            // this.bookTableAdapter.Fill(this.web_lab1db_resDataSet.books);

        }

        private void button2_Click(object sender, EventArgs e)
        {//DELETE

            using (booksContext db = new booksContext())
            {
                 

                //видалення по id
                int bookid = Int32.Parse(textBox3.Text);
                books book1 = new books { id = bookid };
                //

                db.books.Attach(book1);
                db.books.Remove(book1);

                db.SaveChanges();

            }
            this.booksTableAdapter.Fill(this.web_lab1db_resDataSet1.books);
        }

        private void button3_Click(object sender, EventArgs e)
        {//EDITякщо нема по ід то додає 
            using (booksContext db = new booksContext())
            {
                int bookid = Int32.Parse(textBox3.Text);
                String bookname = textBox4.Text.ToString();

                int bookage = Int32.Parse(textBox2.Text);

                books book1 = new books { name = bookname, year = bookage, id = bookid };


                db.books.AddOrUpdate(book1);

                db.SaveChanges();

            }

            this.booksTableAdapter.Fill(this.web_lab1db_resDataSet1.books);

        }
        public static byte[] ImageToByteArray(Image img, PictureBox pictureBoxCompanyLogo)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (pictureBoxCompanyLogo.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            }
            return ms.ToArray();
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void button4_Click(object sender, EventArgs e)
        {//image
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "F:\\serverne web program\\IMAGES";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                

                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Image img = new Bitmap(openFileDialog1.FileName);

                            pictureBoxCompanyLogo.Image = img;// resizeImage(img);
                            byte[] byteImg = ImageToByteArray(pictureBoxCompanyLogo.Image, pictureBoxCompanyLogo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
