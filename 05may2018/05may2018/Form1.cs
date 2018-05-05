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

namespace _05may2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillComputers();
        }
        private void FillComputers()
        {
            SqlConnection con = new SqlConnection(@"Server=CACR10\SERVER2018; Database=P402;Integrated Security=SSPI;");

            DgvComputers.Rows.Clear();
            CmbComputersId.Items.Clear();
            con.Open();
            string query = "SELECT * FROM Computers";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DgvComputers.Rows.Add(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3));
                CmbComputersId.Items.Add(reader.GetInt32(0));
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddComputer_Click(object sender, EventArgs e)
        {
            LblError.Text = "";
            string Marka = TxtMarka.Text;
            string RAM = TxtRam.Text;
            string Display = TxtDisplay.Text;
            if (Marka == string.Empty || RAM == string.Empty || Display == string.Empty)
            {
                LblError.Text = "Bütün məlumatları daxil edin";
                return;
            }
            SqlConnection con = new SqlConnection(@"Server=CACR10\SERVER2018; Database=P402;Integrated Security=SSPI;");
            con.Open();
            string query = "INSERT INTO Computers([Marka],[RAM],[Display]) VALUES('"+Marka+"','"+RAM+"','"+Display+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            int affRow = cmd.ExecuteNonQuery();
            con.Close();
            FillComputers();
            TxtDisplay.Text = string.Empty;
            TxtMarka.Text = string.Empty;
            TxtRam.Text = string.Empty;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(@"Server=CACR10\SERVER2018; Database=P402;Integrated Security=SSPI;");
            con.Open();
            int Deleted = Convert.ToInt32(CmbComputersId.Text);
            string query = "DELETE FROM Computers WHERE [Id]='"+Deleted+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            int affRow = cmd.ExecuteNonQuery();
            con.Close();
            FillComputers();
        }
    }
}
