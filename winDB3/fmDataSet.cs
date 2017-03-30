
using System;
using System.Windows.Forms;
//Access OleDb - step1
//--------------------------------------------------------------
using System.Data.OleDb;       //OleDbConnection cn = new OleDbConnection();
using System.Data;             //DataSet ds = new DataSet(); 
using System.Drawing;          //Color.Beige
//--------------------------------------------------------------
// using System.Data.SqlClient; //SqlConnection cn = new SqlConnection();
// using System.Data;           //ConnectionState.Closed, ConnectionState.Open

namespace winDB3
{
    public partial class fmDataSet : Form
    {
        //Access OleDb - step2
        //--------------------------------------------------------------
        //錯誤 string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\library.mdb";
        //錯誤 string connectionString = Properties.Settings.libraryConnectionString;
        string connectionString = Properties.Settings.Default.libraryConnectionString;
        OleDbConnection cn = new OleDbConnection();
        DataSet ds = new DataSet();
        //--------------------------------------------------------------
        public fmDataSet()
        {
            InitializeComponent();
        }

        private void fmDataSet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Access OleDb - step4
            //--------------------------------------------------------------
            dataGridView1.DataSource = ds.Tables[comboBox1.Text];
            //--------------------------------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Access OleDb - step3
            //--------------------------------------------------------------
            cn.ConnectionString = connectionString;
            // 建立三個DataAdapter物件，用來取得dept, emp overtime類別資料表
            // 再將三個資料表放入ds(DataSet)物件中
            OleDbDataAdapter daDept = new OleDbDataAdapter("SELECT * FROM book", cn);
            daDept.Fill(ds, "book");
            //
            OleDbDataAdapter daEmp = new OleDbDataAdapter("SELECT * FROM borrow", cn);
            daEmp.Fill(ds, "borrow");
            //
            OleDbDataAdapter daOvertime = new OleDbDataAdapter("SELECT * FROM student", cn);
            daOvertime.Fill(ds, "student");
            // 將ds物件內三個DataTable名稱放入cboTable下拉式清單內
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[i].TableName);
            }
            // cboTable下拉式清單顯示 "book"
            comboBox1.Text = ds.Tables["book"].TableName;
            // dataGridView1顯示dept資料表所有記錄
            dataGridView1.DataSource = ds.Tables["book"];
            //--------------------------------------------------------------
            this.dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // dataGridView1.DefaultCellStyle.ForeColor = Color.Beige; //米色
            // dataGridView1.DefaultCellStyle.ForeColor = Color.Lime;  //青檸
            dataGridView1.DefaultCellStyle.ForeColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Rows[1].Cells[2].Style.BackColor = Color.Gray;
            //--------------------------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Access OleDb - step4
            //--------------------------------------------------------------
            cn.ConnectionString = connectionString;
            // 建立 2 個DataAdapter物件，用來取得dept, emp overtime類別資料表
            // 再將 2 個資料表放入ds(DataSet)物件中
            OleDbDataAdapter daDept = new OleDbDataAdapter("SELECT * FROM book", cn);
            daDept.Fill(ds, "book");
            //
            OleDbDataAdapter daEmp = new OleDbDataAdapter("SELECT * FROM borrow", cn);
            daEmp.Fill(ds, "borrow");
            // 建立三個DataTable物件，用來取得dept, emp overtime ds資料表

            DataTable dtBook, dtBorrow; //dt is an object
            dtBook = ds.Tables["book"]; // ["book"] is a datatable in ds
            dtBorrow = ds.Tables["borrow"];
            dataGridView1.DataSource = dtBook;
            dataGridView2.DataSource = dtBorrow;

            MessageBox.Show("Totally " +  ds.Tables.Count.ToString() + " tables in ds dataset.");
            label1.Text = ds.Tables[0].TableName;
            label2.Text = ds.Tables[1].TableName;
            //--------------------------------------------------------------
            this.dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //--------------------------------------------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Access OleDb - step5
            //--------------------------------------------------------------
            DataTable dtStudent = new DataTable();
            dtStudent.Columns.Add(new DataColumn("sno"));
            dtStudent.Columns.Add(new DataColumn("sname"));

            DataRow drRow1 = dtStudent.NewRow();
            drRow1["sno"] = "1001"; drRow1["sname"] = "JOHN";
            dtStudent.Rows.Add(drRow1);

            DataRow drRow2 = dtStudent.NewRow();
            drRow2["sno"] = "1002"; drRow2["sname"] = "MARY";
            dtStudent.Rows.Add(drRow2);

            DataRow drRow3 = dtStudent.NewRow();
            drRow3["sno"] = "1003"; drRow3["sname"] = "TOM";
            dtStudent.Rows.Add(drRow3);

            dataGridView1.DataSource = dtStudent;
            label1.Text = "dtStudent";
            //--------------------------------------------------------------
            DataTable dtGrade = new DataTable();
            dtGrade.Columns.Add(new DataColumn("gid"));
            dtGrade.Columns.Add(new DataColumn("sno"));
            dtGrade.Columns.Add(new DataColumn("course"));
            dtGrade.Columns.Add(new DataColumn("score"));

            DataRow drGradeRow1 = dtGrade.NewRow();
            drGradeRow1["gid"] = "1"; drGradeRow1["sno"] = "1001"; drGradeRow1["course"] = "chi"; drGradeRow1["score"] = "70";
            dtGrade.Rows.Add(drGradeRow1);

            DataRow drGradeRow2 = dtGrade.NewRow();
            drGradeRow2["gid"] = "2"; drGradeRow2["sno"] = "1002"; drGradeRow2["course"] = "eng"; drGradeRow2["score"] = "80";
            dtGrade.Rows.Add(drGradeRow2);

            DataRow drGradeRow3 = dtGrade.NewRow();
            drGradeRow3["gid"] = "3"; drGradeRow3["sno"] = "1002"; drGradeRow3["course"] = "math"; drGradeRow3["score"] = "90";
            dtGrade.Rows.Add(drGradeRow3);

            dataGridView2.DataSource = dtGrade;
            label2.Text = "dtGrade";
            //--------------------------------------------------------------
        }
    }
}
