
namespace Sportclub
{
    partial class Search
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
            this.Back = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.CdcheckBox = new System.Windows.Forms.CheckBox();
            this.Cd = new System.Windows.Forms.TextBox();
            this.UpcheckBox = new System.Windows.Forms.CheckBox();
            this.UptextBox = new System.Windows.Forms.TextBox();
            this.DowncheckBox = new System.Windows.Forms.CheckBox();
            this.AddrescheckBox = new System.Windows.Forms.CheckBox();
            this.DowntextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(193, 76);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.RowTemplate.Height = 24;
            this.listView.Size = new System.Drawing.Size(610, 120);
            this.listView.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 360);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(142, 78);
            this.Back.TabIndex = 1;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(818, 360);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(142, 78);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "検索";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.SearchbuttonClick);
            // 
            // CdcheckBox
            // 
            this.CdcheckBox.Location = new System.Drawing.Point(108, 236);
            this.CdcheckBox.Name = "CdcheckBox";
            this.CdcheckBox.Size = new System.Drawing.Size(84, 19);
            this.CdcheckBox.TabIndex = 3;
            this.CdcheckBox.Text = "Cd検索";
            this.CdcheckBox.UseVisualStyleBackColor = true;
            this.CdcheckBox.CheckedChanged += new System.EventHandler(this.CdcheckBoxCheckedChanged);
            // 
            // Cd
            // 
            this.Cd.Location = new System.Drawing.Point(194, 233);
            this.Cd.Name = "Cd";
            this.Cd.Size = new System.Drawing.Size(263, 22);
            this.Cd.TabIndex = 4;
            this.Cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cd_KeyPress);
            // 
            // UpcheckBox
            // 
            this.UpcheckBox.AutoSize = true;
            this.UpcheckBox.Location = new System.Drawing.Point(103, 314);
            this.UpcheckBox.Name = "UpcheckBox";
            this.UpcheckBox.Size = new System.Drawing.Size(89, 19);
            this.UpcheckBox.TabIndex = 5;
            this.UpcheckBox.Text = "苗字検索";
            this.UpcheckBox.UseVisualStyleBackColor = true;
            this.UpcheckBox.CheckedChanged += new System.EventHandler(this.UpcheckBoxCheckedChanged);
            // 
            // UptextBox
            // 
            this.UptextBox.Location = new System.Drawing.Point(194, 311);
            this.UptextBox.Name = "UptextBox";
            this.UptextBox.Size = new System.Drawing.Size(263, 22);
            this.UptextBox.TabIndex = 6;
            // 
            // DowncheckBox
            // 
            this.DowncheckBox.AutoSize = true;
            this.DowncheckBox.Location = new System.Drawing.Point(495, 236);
            this.DowncheckBox.Name = "DowncheckBox";
            this.DowncheckBox.Size = new System.Drawing.Size(89, 19);
            this.DowncheckBox.TabIndex = 7;
            this.DowncheckBox.Text = "名前検索";
            this.DowncheckBox.UseVisualStyleBackColor = true;
            this.DowncheckBox.CheckedChanged += new System.EventHandler(this.DowncheckBoxCheckedChanged);
            // 
            // AddrescheckBox
            // 
            this.AddrescheckBox.AutoSize = true;
            this.AddrescheckBox.Location = new System.Drawing.Point(495, 314);
            this.AddrescheckBox.Name = "AddrescheckBox";
            this.AddrescheckBox.Size = new System.Drawing.Size(89, 19);
            this.AddrescheckBox.TabIndex = 8;
            this.AddrescheckBox.Text = "住所検索";
            this.AddrescheckBox.UseVisualStyleBackColor = true;
            this.AddrescheckBox.CheckedChanged += new System.EventHandler(this.AddrescheckBoxCheckedChanged);
            // 
            // DowntextBox
            // 
            this.DowntextBox.Location = new System.Drawing.Point(586, 233);
            this.DowntextBox.Name = "DowntextBox";
            this.DowntextBox.Size = new System.Drawing.Size(263, 22);
            this.DowntextBox.TabIndex = 6;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(586, 311);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(263, 22);
            this.AddresstextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "検索";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.DowntextBox);
            this.Controls.Add(this.AddrescheckBox);
            this.Controls.Add(this.DowncheckBox);
            this.Controls.Add(this.UptextBox);
            this.Controls.Add(this.UpcheckBox);
            this.Controls.Add(this.Cd);
            this.Controls.Add(this.CdcheckBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.listView);
            this.Name = "Search";
            this.Text = "検索";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.CheckBox CdcheckBox;
        private System.Windows.Forms.TextBox Cd;
        private System.Windows.Forms.CheckBox UpcheckBox;
        private System.Windows.Forms.TextBox UptextBox;
        private System.Windows.Forms.CheckBox DowncheckBox;
        private System.Windows.Forms.CheckBox AddrescheckBox;
        private System.Windows.Forms.TextBox DowntextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label1;
    }
}