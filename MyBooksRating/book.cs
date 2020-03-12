using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooksRating
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public char amIreading { get; set; }
        public string Review { get; set; }

        //Conexion Database
        private static SqlConnection connection;
        private string connetionString = "Data Source=INSTRUCTORIT;Initial Catalog=MyBookRating;User ID=ProfileUser;Password=ProfileUser2019";

        //Constructor
        public Book() { }

        //public Load a book's Grid
        public DataTable LoadGridBooks()
        {
            //Create a dataTable and the columns
            DataTable dataTableBook = new DataTable();
            dataTableBook.Columns.Add("ID");
            dataTableBook.Columns.Add("Name");
            dataTableBook.Columns.Add("RateNumber");
            dataTableBook.Columns.Add("When I Read");

            //New connection
            connection = new SqlConnection(connetionString);
            SqlDataReader dataReader;
            SqlCommand command;
            string SQL = "select ID, Name, Rate, date from book order by ID";
            string colunmTwo, colunmThree;
            try
            {
                //Open conexion
                connection.Open();
                command = new SqlCommand(SQL, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //Change number to image
                    colunmTwo = dataReader.GetValue(2).ToString();
                    if (colunmTwo == "0")
                    {
                        colunmTwo = "No rate";
                    }

                    //Format Date
                    colunmThree = dataReader.GetValue(3).ToString();
                    if (colunmThree == "0001-01-01 12:00:00 AM")
                    {
                        colunmThree = "I'm reading!";
                    }
                    else
                    {
                        colunmThree = colunmThree.Substring(0, 10);
                    }

                    //Add the rows
                    dataTableBook.Rows
                    .Add(
                        dataReader.GetValue(0).ToString(),
                        dataReader.GetValue(1).ToString(),
                        colunmTwo, colunmThree
                        );
                }
            }
            catch(Exception ex)
            {
               ex.ToString();
            }
            finally
            {
                connection.Close();
            }
            return dataTableBook;
        }

        public DataTable LoadGridBooksSearch(string search)
        {
            //Create a dataTable and the columns
            DataTable dataTableBook = new DataTable();
            dataTableBook.Columns.Add("ID");
            dataTableBook.Columns.Add("Name");
            dataTableBook.Columns.Add("RateNumber");
            dataTableBook.Columns.Add("When I Read");

            //New connection
            connection = new SqlConnection(connetionString);
            SqlDataReader dataReader;
            SqlCommand command;
            string SQL = "select ID, Name, Rate, date from book where Name like '%"+ search + "%' order by ID";
            try
            {
                //Open conexion
                connection.Open();
                command = new SqlCommand(SQL, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //Add the rows
                    dataTableBook.Rows
                    .Add(
                        dataReader.GetValue(0).ToString(),
                        dataReader.GetValue(1).ToString(),
                        dataReader.GetValue(2).ToString(),
                        dataReader.GetValue(3).ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }
            return dataTableBook;
        }

        public bool InsertBook(Book book)
        {
            try
            {
                connection = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                string SQL = "insert into book(Name,URL,Rate,date,amIreading,review)values" +
                    "('" + book.Name + "','" + book.Url + "'," + book.Rate + ",'" + book.Date.ToString("yyyy-MM-dd") + "', " + book.amIreading + "," +
                    "'" + book.Review + "')";
                connection.Open();
                adapter.InsertCommand = new SqlCommand(SQL, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public void DeleteBook(int ID)
        {
            try
            {
                connection = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                string SQL = "delete from book where id = " + ID + "";
                connection.Open();
                adapter.DeleteCommand = new SqlCommand(SQL, connection);
                adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }

        public void UpdateBook(Book book)
        {
            try
            {
                connection = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                string SQL = "update book set" +
                    " name =  '" + book.Name + "'" +
                    " ,url =  '" + book.Url + "'" +
                    " ,rate =  " + book.Rate +
                    " ,date =  '" + book.Date.ToString("yyyy-MM-dd") + "'" +
                    " ,amIreading =  '" + book.amIreading + "'" +
                    " ,review =  '" + book.Review + "'" +
                    " where id = " + book.Id + "";
                connection.Open();
                adapter.UpdateCommand = new SqlCommand(SQL, connection);
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }

        public Book FilledText(int ID)
        {
            Book book = new Book();
            connection = new SqlConnection(connetionString);
            SqlCommand command;
            string SQL = "select Name, URL, Rate, date, amIreading, review from book where id = " + ID + "";
            try
            {
                connection.Open();
                command = new SqlCommand(SQL, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlAdap = new SqlDataAdapter(command);
                sqlAdap.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    book.Name = dt.Rows[0]["Name"].ToString();
                    book.Url = dt.Rows[0]["URL"].ToString();
                    book.Rate = Convert.ToInt32(dt.Rows[0]["Rate"].ToString());
                    book.Date = Convert.ToDateTime(dt.Rows[0]["date"].ToString());
                    book.amIreading = Convert.ToChar(dt.Rows[0]["amIreading"].ToString());
                    book.Review = dt.Rows[0]["review"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }
            return book;
        }
    }
}
