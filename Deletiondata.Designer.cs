
namespace Sportclub
{
    partial class Deletiondata
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
            this.Erase = new System.Windows.Forms.Button();
            this.Cd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(126, 70);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.RowTemplate.Height = 24;
            this.listView.Size = new System.Drawing.Size(783, 159);
            this.listView.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(27, 358);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(132, 70);
            this.Back.TabIndex = 1;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(832, 358);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(132, 70);
            this.Erase.TabIndex = 2;
            this.Erase.Text = "削除";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.EraseClick);
            // 
            // Cd
            // 
            this.Cd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cd.Location = new System.Drawing.Point(425, 360);
            this.Cd.Name = "Cd";
            this.Cd.Size = new System.Drawing.Size(171, 30);
            this.Cd.TabIndex = 3;
            this.Cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CdKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(404, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cdを入力してください。";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(447, 251);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(135, 49);
            this.Load.TabIndex = 5;
            this.Load.Text = "読み込み";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(472, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "削除";
            // 
            // Deletiondata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cd);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.listView);
            this.Name = "Deletiondata";
            this.Text = "削除";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.TextBox Cd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label2;
    }
}