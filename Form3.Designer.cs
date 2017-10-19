namespace weblab1Forms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.web_lab1db_resDataSet = new weblab1Forms.web_lab1db_resDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookTableAdapter = new weblab1Forms.web_lab1db_resDataSetTableAdapters.bookTableAdapter();
            this.weblab1dbresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mynewimage = new weblab1Forms.mynewimage();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mybooks = new weblab1Forms.mybooks();
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.web_lab1db_resDataSet1 = new weblab1Forms.web_lab1db_resDataSet1();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new weblab1Forms.web_lab1db_resDataSet1TableAdapters.booksTableAdapter();
            this.web_lab1db_resDataSet2 = new weblab1Forms.web_lab1db_resDataSet2();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new weblab1Forms.web_lab1db_resDataSet2TableAdapters.booksTableAdapter();
            this.booksTableAdapter2 = new weblab1Forms.mybooksTableAdapters.booksTableAdapter();
            this.booksTableAdapter3 = new weblab1Forms.mynewimageTableAdapters.booksTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imgtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet.books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weblab1dbresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mynewimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.web_lab1db_resDataSet;
            // 
            // web_lab1db_resDataSet
            // 
            // 
            // 
            // 
            this.web_lab1db_resDataSet.books.TableName = "book";
            this.web_lab1db_resDataSet.DataSetName = "web_lab1db_resDataSet";
            this.web_lab1db_resDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "description";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(326, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "   id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "  Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 20;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // weblab1dbresDataSetBindingSource
            // 
            this.weblab1dbresDataSetBindingSource.DataSource = this.web_lab1db_resDataSet;
            this.weblab1dbresDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.bookimage});
            this.dataGridView1.DataSource = this.booksBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // bookimage
            // 
            this.bookimage.DataPropertyName = "myimage";
            this.bookimage.HeaderText = "bookimage";
            this.bookimage.Name = "bookimage";
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "books";
            this.booksBindingSource3.DataSource = this.mynewimage;
            // 
            // mynewimage
            // 
            this.mynewimage.DataSetName = "mynewimage";
            this.mynewimage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "books";
            this.booksBindingSource2.DataSource = this.mybooks;
            // 
            // mybooks
            // 
            this.mybooks.DataSetName = "mybooks";
            this.mybooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "book";
            this.bookBindingSource2.DataSource = this.weblab1dbresDataSetBindingSource;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.web_lab1db_resDataSet1;
            // 
            // web_lab1db_resDataSet1
            // 
            this.web_lab1db_resDataSet1.DataSetName = "web_lab1db_resDataSet1";
            this.web_lab1db_resDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "book";
            this.bookBindingSource1.DataSource = this.weblab1dbresDataSetBindingSource;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // web_lab1db_resDataSet2
            // 
            this.web_lab1db_resDataSet2.DataSetName = "web_lab1db_resDataSet2";
            this.web_lab1db_resDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "books";
            this.booksBindingSource1.DataSource = this.web_lab1db_resDataSet2;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter2
            // 
            this.booksTableAdapter2.ClearBeforeFill = true;
            // 
            // booksTableAdapter3
            // 
            this.booksTableAdapter3.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxCompanyLogo
            // 
            this.pictureBoxCompanyLogo.ImageLocation = "F:\\\\serverne web program\\\\IMAGES\\\\1.png";
            this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(523, 32);
            this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxCompanyLogo.TabIndex = 33;
            this.pictureBoxCompanyLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "image";
            // 
            // imgtextbox
            // 
            this.imgtextbox.Location = new System.Drawing.Point(175, 114);
            this.imgtextbox.Name = "imgtextbox";
            this.imgtextbox.Size = new System.Drawing.Size(333, 20);
            this.imgtextbox.TabIndex = 35;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 354);
            this.Controls.Add(this.imgtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxCompanyLogo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet.books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weblab1dbresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mynewimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_lab1db_resDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private web_lab1db_resDataSet web_lab1db_resDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private web_lab1db_resDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource weblab1dbresDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private web_lab1db_resDataSet1 web_lab1db_resDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private web_lab1db_resDataSet1TableAdapters.booksTableAdapter booksTableAdapter;
        private web_lab1db_resDataSet2 web_lab1db_resDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private web_lab1db_resDataSet2TableAdapters.booksTableAdapter booksTableAdapter1;
        private mybooks mybooks;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private mybooksTableAdapters.booksTableAdapter booksTableAdapter2;
        private mynewimage mynewimage;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private mynewimageTableAdapters.booksTableAdapter booksTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bookimage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imgtextbox;
    }
}