using System;
//Sql to OleDb - step2
//--------------------------------------------------------------
using System.Data.OleDb;       //OleDbConnection cn = new OleDbConnection();
//--------------------------------------------------------------
// using System.Data.SqlClient; //SqlConnection cn = new SqlConnection();
// using System.Data;           //ConnectionState.Closed, ConnectionState.Open
using System.Windows.Forms;

namespace winDB2
{
    public partial class fmLibrary : Form
    {
        public fmLibrary()
        {
            InitializeComponent();
        }

        //Sql to OleDb - step1
        //--------------------------------------------------------------
        string dbOK = "資料庫已連接"; string dbXX = "資料庫已關閉";
        string connString = Properties.Settings.Default.libraryConnectionString;
        OleDbConnection cn = new OleDbConnection();
        //--------------------------------------------------------------
        //
        private void fmLibrary_Load(object sender, EventArgs e)
        {
            //育幼院圖書系統  書籍資料(BOOK) 的查詢  新增  更正  刪除
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sql to OleDb - step3
            //--------------------------------------------------------------
            cn.ConnectionString = connString; cn.Open();//SQL connection
            //SELECT* FROM book
            //SELECT* FROM borrow
            //SELECT* FROM student
            //
            OleDbCommand cmd = new OleDbCommand(comboBox1.Text.Trim(), cn);
            OleDbDataReader dr = cmd.ExecuteReader();
            //
            richTextBox1.Clear();
            for (int i = 0; i < dr.FieldCount; i++)
                richTextBox1.Text += dr.GetName(i) + "\t";
            richTextBox1.Text += "\r\n" + "\r\n";
            //
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                    richTextBox1.Text += dr[i].ToString() + "\t";
                richTextBox1.Text += "\r\n";
            }
            cn.Close(); //執行資料庫操作之後，立即關閉連線
            //--------------------------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sql to OleDb - step4
            //--------------------------------------------------------------
            //INSERT INTO book VALUES(2007, '油畫', 2007, '蔡導', '幼獅', 2017 - 03 - 30, 'v1', NULL)
            //UPDATE book SET bname = '中文' WHERE bno = '2001'
            //DELETE FROM book WHERE bno = '2006'
            //
            cn.ConnectionString = connString; cn.Open();//OleDb connection
            OleDbCommand cmd1 = new OleDbCommand( comboBox2.Text.Trim(), cn);
            cmd1.ExecuteNonQuery(); // MessageBox.Show("Updated");
            cn.Close(); //執行 .ExecuteNonQuery() 之後必須關閉連線才能實際寫入資料庫
            //
            //Sql to OleDb - step5
            //--------------------------------------------------------------
            //SELECT* FROM book
            cn.ConnectionString = connString; cn.Open();//OleDb connection
            OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM book", cn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            //
            richTextBox2.Clear();
            for (int i = 0; i < dr.FieldCount; i++)
                richTextBox2.Text += dr.GetName(i) + "\t";
            richTextBox2.Text += "\r\n" + "\r\n";
            //
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                    richTextBox2.Text += dr[i].ToString() + "\t";
                richTextBox2.Text += "\r\n";
            }
            cn.Close(); //執行資料庫操作之後，立即關閉連線
            //--------------------------------------------------------------
        }
    }
}
