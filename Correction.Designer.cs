
namespace Sportclub
{
    partial class Correction
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
            this.Back = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.DataGridView();
            this.Load = new System.Windows.Forms.Button();
            this.Corrections = new System.Windows.Forms.Button();
            this.Cd = new System.Windows.Forms.TextBox();
            this.Upname = new System.Windows.Forms.TextBox();
            this.Downname = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 354);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 84);
            this.Back.TabIndex = 0;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(144, 63);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.RowTemplate.Height = 24;
            this.listView.Size = new System.Drawing.Size(743, 133);
            this.listView.TabIndex = 2;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(427, 202);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(128, 46);
            this.Load.TabIndex = 3;
            this.Load.Text = "読み込み";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // Corrections
            // 
            this.Corrections.Location = new System.Drawing.Point(901, 354);
            this.Corrections.Name = "Corrections";
            this.Corrections.Size = new System.Drawing.Size(138, 84);
            this.Corrections.TabIndex = 4;
            this.Corrections.Text = "修正";
            this.Corrections.UseVisualStyleBackColor = true;
            this.Corrections.Click += new System.EventHandler(this.CorrectionsClick);
            // 
            // Cd
            // 
            this.Cd.Location = new System.Drawing.Point(561, 272);
            this.Cd.Multiline = true;
            this.Cd.Name = "Cd";
            this.Cd.Size = new System.Drawing.Size(36, 28);
            this.Cd.TabIndex = 5;
            // 
            // Upname
            // 
            this.Upname.Location = new System.Drawing.Point(352, 335);
            this.Upname.MaxLength = 10;
            this.Upname.Name = "Upname";
            this.Upname.Size = new System.Drawing.Size(100, 22);
            this.Upname.TabIndex = 6;
            // 
            // Downname
            // 
            this.Downname.Location = new System.Drawing.Point(561, 335);
            this.Downname.MaxLength = 10;
            this.Downname.Name = "Downname";
            this.Downname.Size = new System.Drawing.Size(100, 22);
            this.Downname.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(276, 386);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(202, 22);
            this.Address.TabIndex = 8;
            // 
            // Tel
            // 
            this.Tel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tel.Location = new System.Drawing.Point(589, 389);
            this.Tel.MaxLength = 11;
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(202, 24);
            this.Tel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(325, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "修正するCdを入力してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "苗字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "名前";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "住所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "電話番号";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(470, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "修正";
            // 
            // Correction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Downname);
            this.Controls.Add(this.Upname);
            this.Controls.Add(this.Cd);
            this.Controls.Add(this.Corrections);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.Back);
            this.Name = "Correction";
            this.Text = "修正";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Corrections;
        private System.Windows.Forms.TextBox Cd;
        private System.Windows.Forms.TextBox Upname;
        private System.Windows.Forms.TextBox Downname;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}