using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooksRating
{
    public partial class DetailForm : Form
    {
        MainForm myForm;
        int ID;

        public DetailForm()
        {
            InitializeComponent();
        }
        //New contructor that it could recive a Form as parentises
        public DetailForm(Form parentForm)
        {
            //Doing a cast to MainForm
            myForm = (MainForm)parentForm;
            InitializeComponent();
        }

        public DetailForm(int id)
        {
            //Doing a cast to MainForm
            ID = id;
            InitializeComponent();
        }

        public DetailForm(int id, Form parentForm)
        {
            //Doing a cast to MainForm
            ID = id;
            myForm = (MainForm)parentForm;
            InitializeComponent();
        }

        private void BtnSalve_Click(object sender, EventArgs e)
        {
            //IF ID is ZERO it means a new book to insert
            if (ID == 0)
            {
                //Verify if the name is filled, because just Name is required
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please, fill a name!", "Alert");
                    txtName.Focus();
                }
                else
                {
                    Book newBook = new Book();
                    newBook.Name = txtName.Text;
                    newBook.Url = txtUrl.Text;
                    //Convert Rate String to Int to assign a obj book
                    if (cbxRate.Text.ToUpper() == "NO RATE")
                    {
                        newBook.Rate = 0;
                    }
                    else
                    {
                        newBook.Rate = Convert.ToInt32(cbxRate.Text.Substring(0, 1));
                    }
                    //If I'm reading yet the date will be null
                    if (cbxReading.Checked == true)
                    {
                        newBook.Date = new DateTime(0001, 1, 01);
                        newBook.amIreading = '1';
                    }
                    else
                    {
                        newBook.Date = Convert.ToDateTime(dtpDateRead.Text);
                        newBook.amIreading = '0';
                    }
                    newBook.Review = txtMyReview.Text;
                    //Insert a new book
                    if (newBook.InsertBook(newBook))
                    {
                        MessageBox.Show("Book saved!", "Alert");

                        //Call the method to reload a grid
                        myForm.MainForm_Load();

                        //Close this Details Form
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Somethigs was wrog, try again!");
                    }
                }
            }
            else
            {
                Book updateBook = new Book();
                updateBook.Id = ID;
                updateBook.Name = txtName.Text;
                updateBook.Url = txtUrl.Text;
                if (cbxRate.Text.ToUpper() == "NO RATE")
                {
                    updateBook.Rate = 0;
                }
                else
                {
                    updateBook.Rate = Convert.ToInt32(cbxRate.Text.Substring(0, 1));
                }
                //If I'm reading yet the date will be null
                if (cbxReading.Checked == true)
                {
                    updateBook.Date = new DateTime(0001, 1, 01);
                    updateBook.amIreading = '1';
                }
                else
                {
                    updateBook.Date = Convert.ToDateTime(dtpDateRead.Text);
                    updateBook.amIreading = '0';
                }
                updateBook.Review = txtMyReview.Text;
                new Book().UpdateBook(updateBook);

                //MessageBox.Show("Book was updated!", "Alert");

                //Call the method to reload a grid
                myForm.MainForm_Load();

                //Close this Details Form
                Close();

            }
        }

        private void CbxReading_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxReading.Checked == true)
            {
                dtpDateRead.Enabled = false;
            }
            else
            {
                dtpDateRead.Enabled = true;
            }
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                this.Text = "Edit or Delete - ID: " + ID.ToString();
                //Book book = new Book();
                Book fillTextBook = new Book();
                fillTextBook = new Book().FilledText(ID);
                txtName.Text = fillTextBook.Name.TrimEnd();
                txtUrl.Text = fillTextBook.Url.TrimEnd();
                if (fillTextBook.Rate == 0)
                {
                    cbxRate.Text = "No rate";
                }
                else
                {
                    cbxRate.Text = fillTextBook.Rate.ToString() + " heart";
                }
                
                if (fillTextBook.Date.ToString() == "0001-01-01 12:00:00 AM")
                {
                    cbxReading.Checked = true;
                }
                else
                {
                    cbxReading.Checked = false;
                }
                txtMyReview.Text = fillTextBook.Review.TrimEnd();
                btnDelete.Enabled = true;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete this book?","Deleting a book",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                new Book().DeleteBook(ID);
                MessageBox.Show("Book was deleted!","Alert");

                //Call the method to reload a grid
                myForm.MainForm_Load();

                //Close this Details Form
                Close();
            }

        }
    }
}
