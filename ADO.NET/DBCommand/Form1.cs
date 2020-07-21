using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open(); SqlDataReader reader = sqlCommand1.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                sqlCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers;" + "SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products;";
                try
                {
                    sqlConnection1.Open(); 
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    bool MoreResults = false;
                    do
                    {

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                results.Append(reader[i].ToString() + "\t");
                            }
                            results.Append(Environment.NewLine);
                        }
                        MoreResults = reader.NextResult();
                    } while (MoreResults);
                    ResultsTextBox.Text = results.ToString();
                }
                
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder(); using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open(); SqlDataReader reader = sqlCommand2.ExecuteReader();
                    while (reader.Read()) 
                    { 
                        for (int i = 0; i < reader.FieldCount; i++) 
                        {
                            results.Append(reader[i].ToString() + "\t");
                        } 
                        results.Append(Environment.NewLine); 
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}