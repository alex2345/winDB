namespace winDB2
{
    partial class fmLibrary
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new winDB2.libraryDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.libraryDataSet;
            this.bindingSource1.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.ForeColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SELECT * FROM book",
            "SELECT * FROM borrow",
            "SELECT * FROM student"});
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1021, 38);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "SELECT * FROM book";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(1039, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "&SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("新細明體", 14F);
            this.button2.Location = new System.Drawing.Point(1039, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "&NonQuery";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(12, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1185, 225);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Black;
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.ForeColor = System.Drawing.Color.Lime;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "INSERT INTO book VALUES (2007, \'油畫\', 2007, \'蔡導\', \'幼獅\', \'2017-03-30\', \'v1\', NULL)",
            "UPDATE book SET bname = \'中文\' WHERE bno = \'2001\'",
            "DELETE FROM book WHERE bno = \'2006\'"});
            this.comboBox2.Location = new System.Drawing.Point(12, 321);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1021, 38);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "INSERT INTO book VALUES (2007, \'油畫\', 2007, \'蔡導\', \'幼獅\', \'2017-03-30\', \'v1\', NULL)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(12, 365);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1185, 225);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // fmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 600);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "fmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLibrary";
            this.Load += new System.EventHandler(this.fmLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

