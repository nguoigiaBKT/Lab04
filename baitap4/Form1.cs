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

namespace baitap4
{

    public partial class Form1 : Form
    {
        private string connectionString = "Server=PMT-LAPTOP;Database=QLSP;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DateTime datePast = dtpFrom.Value;
            DateTime dateFuture = dtpTo.Value;

            if (cbShowAll.Checked)
            {
                datePast = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, 1);
                dateFuture = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, DateTime.DaysInMonth(dtpTo.Value.Year, dtpTo.Value.Month));
            }

            LoadDataFromDatabase(datePast, dateFuture);
        }


        //SUM([Order].Quantity * Product.SellPrice) AS clThanhtien
        private void LoadDataFromDatabase(DateTime datePast, DateTime dateFuture)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                Invoice.InvoiceNo, 
                Invoice.OrderDate, 
                Invoice.DeliveryDate,
                
                SUM([Order].Quantity * [Order].Price) AS clThanhtien
            FROM Invoice
            JOIN [Order] ON Invoice.InvoiceNo = [Order].InvoiceNo
            JOIN Product ON [Order].ProductID = Product.ProductID
            WHERE Invoice.DeliveryDate BETWEEN @datePast AND @dateFuture
            GROUP BY Invoice.InvoiceNo, Invoice.OrderDate, Invoice.DeliveryDate";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // Add the date parameters with the correct format
                da.SelectCommand.Parameters.AddWithValue("@datePast", datePast.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@dateFuture", dateFuture.ToString("yyyy-MM-dd"));

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Log the dates being used in the query
                Console.WriteLine($"Querying invoices between {datePast} and {dateFuture}");

                // Check if the DataTable has rows
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("No data found for the given date range.");
                }
                else
                {
                    // Add clStt column to DataTable
                    dt.Columns.Add("clStt", typeof(int));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["clStt"] = i + 1;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"InvoiceNo: {row["InvoiceNo"]}, OrderDate: {row["OrderDate"]}, DeliveryDate: {row["DeliveryDate"]}, clThanhtien: {row["clThanhtien"]}, clStt: {row["clStt"]}");
                    }
                }

                // Ensure the DataGridView columns are correctly mapped
                dgvDonHang.AutoGenerateColumns = false;

                // Map existing columns to the DataTable columns
                dgvDonHang.Columns["clSohd"].DataPropertyName = "InvoiceNo";
                dgvDonHang.Columns["clNgaydat"].DataPropertyName = "OrderDate";
                dgvDonHang.Columns["clNgaygiao"].DataPropertyName = "DeliveryDate";
                dgvDonHang.Columns["clThanhtien"].DataPropertyName = "clThanhtien";
                dgvDonHang.Columns["clStt"].DataPropertyName = "clStt";

                dgvDonHang.DataSource = dt;

                // Calculate and display the total
                CalculateTotal(dt);
            }
        }

        private void CalculateTotal(DataTable dt)
        {
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (decimal.TryParse(row["clThanhtien"].ToString(), out decimal value))
                {
                    total += value;
                }
            }
            txtTong.Text = total.ToString("C");
        }

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}