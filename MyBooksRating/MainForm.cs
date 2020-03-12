using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyBooksRating
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //I'm passing the Mainform (itself) as a parentises
            DetailForm detailForm = new DetailForm(this);
            detailForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Load();
        }

        //Create a method public that it can be possible to use in a child form
        public void MainForm_Load()
        {
            Book loadGridBook = new Book();
            dataGridViewBook.DataSource = loadGridBook.LoadGridBooks();

            //Adjust Grid
            dataGridViewBook.Columns["ID"].Width = 50;
            dataGridViewBook.Columns["Name"].Width = 250;
            dataGridViewBook.Columns["When I Read"].Width = 150;
            //Hide de column with number
            dataGridViewBook.Columns["RateNumber"].Visible = false;

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            if(dataGridViewBook.Columns.Contains("Rate"))
            {
                dataGridViewBook.Columns.Remove("Rate");
            }
            column.Name = "Rate";
            column.HeaderText = "Rate";
            dataGridViewBook.Columns.Add(column);
            dataGridViewBook.Refresh();


            foreach (DataGridViewRow row1 in dataGridViewBook.Rows)
            {
                string rate = row1.Cells["RateNumber"].Value.ToString();
                if (rate != "No rate")
                {
                    string imgPath = Environment.CurrentDirectory.Substring(0, 45) + @"image\" + row1.Cells["RateNumber"].Value + "heart.png";
                    Image imageFile = Image.FromFile(imgPath);
                    row1.Cells["Rate"].Value = imageFile;
                }
                else
                {
                    string imgPath = Environment.CurrentDirectory.Substring(0, 45) + @"image\NoRate.png";
                    row1.Cells["Rate"].Value = Image.FromFile(imgPath);
                }
            }

        }

        public void MainForm_Load(string search)
        {
            Book loadGridBook = new Book();
            dataGridViewBook.DataSource = loadGridBook.LoadGridBooksSearch(search);

            //Adjust Grid
            dataGridViewBook.Columns["ID"].Width = 50;
            dataGridViewBook.Columns["Name"].Width = 250;
            dataGridViewBook.Columns["When I Read"].Width = 150;
            //Hide de column with number
            dataGridViewBook.Columns["RateNumber"].Visible = false;

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            if (dataGridViewBook.Columns.Contains("Rate"))
            {
                dataGridViewBook.Columns.Remove("Rate");
            }
            column.Name = "Rate";
            column.HeaderText = "Rate";
            dataGridViewBook.Columns.Add(column);
            dataGridViewBook.Refresh();


            foreach (DataGridViewRow row1 in dataGridViewBook.Rows)
            {
                string rate = row1.Cells["RateNumber"].Value.ToString();
                if (rate != "No rate")
                {
                    string imgPath = Environment.CurrentDirectory.Substring(0, 45) + @"image\" + row1.Cells["RateNumber"].Value + "heart.png";
                    Image imageFile = Image.FromFile(imgPath);
                    row1.Cells["Rate"].Value = imageFile;
                }
                else
                {
                    string imgPath = Environment.CurrentDirectory.Substring(0, 45) + @"image\NoRate.png";
                    row1.Cells["Rate"].Value = Image.FromFile(imgPath);
                }
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MainForm_Load(txtSearch.Text);
        }

        private void DataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pass a parameters the book's ID and this form
            DetailForm detailForm = new DetailForm(Convert.ToInt32(this.dataGridViewBook.CurrentRow.Cells[0].Value.ToString()),this);
            detailForm.ShowDialog();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            MainForm_Load(txtSearch.Text);
        }
    }
}
