
namespace Sportclub
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.DataGridView();
            this.Upname = new System.Windows.Forms.TextBox();
            this.Downname = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.CreaTetableClick = new System.Windows.Forms.Button();
            this.BackClick = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(178, 54);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.RowTemplate.Height = 24;
            this.listView.Size = new System.Drawing.Size(859, 121);
            this.listView.TabIndex = 0;
            // 
            // Upname
            // 
            this.Upname.Location = new System.Drawing.Point(456, 244);
            this.Upname.MaxLength = 10;
            this.Upname.Name = "Upname";
            this.Upname.Size = new System.Drawing.Size(125, 22);
            this.Upname.TabIndex = 1;
            // 
            // Downname
            // 
            this.Downname.Location = new System.Drawing.Point(629, 244);
            this.Downname.MaxLength = 20;
            this.Downname.Name = "Downname";
            this.Downname.Size = new System.Drawing.Size(142, 22);
            this.Downname.TabIndex = 2;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(358, 288);
            this.Year.MaxLength = 4;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(92, 22);
            this.Year.TabIndex = 3;
            this.Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearKeyPress);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(129, 333);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(340, 22);
            this.Address.TabIndex = 6;
            // 
            // CreaTetableClick
            // 
            this.CreaTetableClick.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreaTetableClick.Location = new System.Drawing.Point(504, 384);
            this.CreaTetableClick.Name = "CreaTetableClick";
            this.CreaTetableClick.Size = new System.Drawing.Size(137, 52);
            this.CreaTetableClick.TabIndex = 8;
            this.CreaTetableClick.Text = "テーブル作成";
            this.CreaTetableClick.UseVisualStyleBackColor = true;
            this.CreaTetableClick.Click += new System.EventHandler(this.CreaTetable);
            // 
            // BackClick
            // 
            this.BackClick.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackClick.Location = new System.Drawing.Point(21, 384);
            this.BackClick.Name = "BackClick";
            this.BackClick.Size = new System.Drawing.Size(134, 52);
            this.BackClick.TabIndex = 9;
            this.BackClick.Text = "戻る";
            this.BackClick.UseVisualStyleBackColor = true;
            this.BackClick.Click += new System.EventHandler(this.Back);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Save.Location = new System.Drawing.Point(1012, 384);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 52);
            this.Save.TabIndex = 10;
            this.Save.Text = "登録";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "生年月日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "住所";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "電話番号（ハイフンなし）";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(532, 184);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(134, 45);
            this.Load.TabIndex = 20;
            this.Load.Text = "読み込み";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // Month
            // 
            this.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Month.Location = new System.Drawing.Point(532, 287);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(85, 23);
            this.Month.TabIndex = 21;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Day.Location = new System.Drawing.Point(686, 289);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(85, 23);
            this.Day.TabIndex = 22;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "月";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "日";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(558, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 33);
            this.label9.TabIndex = 26;
            this.label9.Text = "登録";
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(686, 333);
            this.Tel.MaxLength = 11;
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(351, 22);
            this.Tel.TabIndex = 27;
            this.Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tel_KeyPress);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BackClick);
            this.Controls.Add(this.CreaTetableClick);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Downname);
            this.Controls.Add(this.Upname);
            this.Controls.Add(this.listView);
            this.Name = "Registration";
            this.Text = "登録";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.TextBox Upname;
        private System.Windows.Forms.TextBox Downname;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button CreaTetableClick;
        private System.Windows.Forms.Button BackClick;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Tele;
        private System.Windows.Forms.TextBox Tel;
    }
}