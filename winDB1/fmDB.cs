using System.Windows.Forms;
using System.Data.SqlClient; //SqlConnection cn = new SqlConnection();
using System.Data;           //ConnectionState.Closed, ConnectionState.Open
//using System.Data.OleDb;       //OleDbConnection cn = new OleDbConnection();
using System;                // Environment.NewLine;
                             // Delphi 全部程式碼.自動排版 Ctrl+D
                             // VisualStudio 全部程式碼.自動排版 Ctrl+E(或K),D
                             // VisualStudio 單行程式碼.自動排版 Ctrl+E(或K),F
                             // VisualStudio 選取區轉換大寫：Ctrl+Shift+U
                             // VisualStudio 選取區轉換小寫：Ctrl+U
namespace winDB1
{
    public partial class fmDB : Form
    {
        public fmDB()
        {
            InitializeComponent();
        }
        //
        //SQL server connection & commands
        //--------------------------------------------------------------
        string dbOK = "資料庫已連接";
        string dbXX = "資料庫已關閉";
        string connString = Properties.Settings.Default.mydbConnectionString;
        SqlConnection cn = new SqlConnection();
        //--------------------------------------------------------------
        //
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // 設定連接字串，用來連接資料庫
            cn.ConnectionString = connString;
        }

        private void ShowConnection() //顯示連線資訊
        {
            label1.Text = "連接字串：" + cn.ConnectionString + Environment.NewLine;
            label1.Text += "逾時秒數：" + cn.ConnectionTimeout + Environment.NewLine;
            label1.Text += "　資料庫：" + cn.Database + "\n";
            label1.Text += "資料來源：" + cn.DataSource + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            if (cn.State == ConnectionState.Closed)
            {   //[17-10] 判斷目前是否為資料庫關閉連接狀態
                cn.Open(); button1.Text = "關閉"; label2.Text = dbOK; ShowConnection(); //顯示連線資訊
            }
            
            else if (cn.State == ConnectionState.Open)
            {   //[17-10] 判斷目前是否為資料庫開啟連接狀態
                cn.Close(); button1.Text = "開啟"; label2.Text = dbXX;
            }
            //--------------------------------------------------------------

        }

        // Delphi 全部程式碼.自動排版 Ctrl+D
        // VisualStudio 全部程式碼.自動排版 Ctrl+E(或K),D
        // VisualStudio 單行程式碼.自動排版 Ctrl+E(或K),F
        // VisualStudio 選取區轉換大寫：Ctrl+Shift+U
        // VisualStudio 選取區轉換小寫：Ctrl+U

        private void button2_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            if (cn.State == ConnectionState.Open)
            {   //[17-10] 判斷目前是否為資料庫開啟連接狀態
                cn.Close(); button1.Text = "開啟"; label2.Text = dbXX;
            }

            //using (SqlConnection cn = new SqlConnection())
            //{   //[17-12] 採用 using (SqlConnection
            //    cn.ConnectionString = connString;
            //    cn.Open(); button1.Text = "關閉"; label2.Text = dbOK;
            //    if (cn.State == ConnectionState.Open)
            //    {   ShowConnection(); //顯示連線資訊
            //        MessageBox.Show(dbOK, "目前狀態");
            //    }
            //}

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.mydbConnectionString))
            {   //[17-15] 引用 App.config 設定
                cn.Open(); button1.Text = "關閉"; label2.Text = dbOK;
                if (cn.State == ConnectionState.Open)
                {   ShowConnection(); //顯示連線資訊
                    MessageBox.Show(dbOK, "目前狀態");
                }
            }
            //--------------------------------------------------------------

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            textBox1.Text = "";
            //[17-17]
            cn.ConnectionString = connString; cn.Open();                       //SQL connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM dept", cn); //SQL command
            SqlDataReader dr = cmd.ExecuteReader();                            //SQL ExecuteReader
            //
            textBox1.Multiline = true;
            //拆解.單一資料列.各欄位名稱
            for (int i = 0; i < dr.FieldCount; i++)//每圈讀取一欄(column)
                textBox1.Text += dr.GetName(i) + "\t";
            textBox1.Text += "\r\n" + "\r\n";
            //拆解.單一資料列.各欄位內容
            while (dr.Read()) //每圈讀取一列(row)
            {
                for (int i = 0; i < dr.FieldCount; i++)//每圈讀取一欄(column)
                    textBox1.Text += dr[i].ToString() + "\t";
                textBox1.Text += "\r\n";
            }
            cn.Close(); //執行資料庫操作之後，立即關閉連線
            //--------------------------------------------------------------
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            textBox1.Text = "";
            //[17-21]
            cn.ConnectionString = connString; cn.Open();//SQL connection
            SqlCommand cmd = new SqlCommand("SELECT dname, loc FROM dept", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            //拆解.單一資料列.各欄位名稱
            for (int i = 0; i < dr.FieldCount; i++)//每圈讀取一欄(column)
                textBox1.Text += dr.GetName(i) + "\t";
            textBox1.Text += "\r\n" + "\r\n";
            //拆解.單一資料列.各欄位
            while (dr.Read()) //每圈讀取一列(row)
            {
                // textBox1.Text += dr["dno"].ToString() + "\t";
                textBox1.Text += dr["dname"].ToString() + "\t";
                textBox1.Text += dr["loc"].ToString() + "\t";

                textBox1.Text += "\r\n";
            }
            cn.Close(); //執行資料庫操作之後，立即關閉連線
            //--------------------------------------------------------------
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            cn.ConnectionString = connString; cn.Open();//SQL connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM emp", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                textBox2.Text += dr.GetName(i) + "\t";
            }
            textBox2.Text += "\r\n" + "\r\n";
            while (dr.Read())
            {
                textBox2.Text += dr["eno"].ToString() + "\t";
                textBox2.Text += dr["ename"].ToString() + "\t";
                textBox2.Text += dr["sal"].ToString() + "\t";

                textBox2.Text += "\r\n";
            }
            cn.Close(); //執行資料庫操作之後，立即關閉連線
            //--------------------------------------------------------------
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SQL server connection & commands
            //--------------------------------------------------------------
            cn.ConnectionString = connString; cn.Open();//SQL connection
            // http://csharpcherry.blogspot.tw/2010/06/sql-server-table.html
            // textBox3.Text = "SELECT name as 檢視表 FROM sys.views"  //顯示.本資料庫.所有檢視表名稱
            // textBox3.Text = "SELECT name as 資料表 FROM sys.Tables" //顯示.本資料庫.所有資料表名稱
            // textBox3.Text = "SELECT * FROM dept"                    //顯示.本資料庫.資料表 dept.所有欄位
            //
            //SELECT name as 資料表 FROM sys.Tables
            //SELECT* FROM dept
            //INSERT INTO dept VALUES(1234, 'aa', 'bb')
            //SELECT* FROM dept
            //UPDATE dept SET dname = 'kk' WHERE dno = 1234
            //SELECT* FROM dept
            //DELETE FROM dept WHERE dno = 1234
            //SELECT* FROM dept
           //  comboBox1.Text = "SELECT * FROM dept";
           SqlCommand cmd = new SqlCommand(comboBox1.Text.Trim(), cn);
            SqlDataReader dr = cmd.ExecuteReader();
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

        private void button7_Click(object sender, EventArgs e)
        {
            //SELECT * FROM dept
            //INSERT INTO dept VALUES(1234, 'aa', 'bb')
            //SELECT * FROM dept
            //UPDATE dept SET dname = 'kk' WHERE dno = 1234
            //SELECT * FROM dept
            //DELETE FROM dept WHERE dno = 1234
            //SELECT * FROM dept
            //
            //SQL server connection & commands
            //--------------------------------------------------------------
            cn.ConnectionString = connString; cn.Open();//SQL connection
            SqlCommand cmd = new SqlCommand(comboBox2.Text.Trim(), cn);
            cmd.ExecuteNonQuery(); // MessageBox.Show("Updated");
            cn.Close(); //執行 .ExecuteNonQuery() 之後必須關閉連線才能實際寫入資料庫
            //--------------------------------------------------------------
            //SELECT * FROM dept
            cn.ConnectionString = connString; cn.Open();//Sql connection
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM dept", cn);
            SqlDataReader dr = cmd2.ExecuteReader();
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
