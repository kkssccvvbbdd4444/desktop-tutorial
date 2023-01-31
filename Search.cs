using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportclub
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, EventArgs e)
        {
            //Mainを表示
            Main Main = new Main();
            Main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        private void SearchbuttonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    if (CdcheckBox.Checked == true)
                    {
                        //未入力の時はエラーをだす
                        if (Cd.Text == "")

                        {
                            MessageBox.Show("記入が完了していません。", "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //DataTableを生成します。
                            DataTable dataTable = new DataTable();
                            SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE Cd =" + Cd.Text, con);
                            adpter.Fill(dataTable);
                            //データベースの表示
                            listView.DataSource = dataTable;
                        }
                    }
                    //苗字検索
                    if (UpcheckBox.Checked == true)
                    {
                        //未入力の時はエラーをだす
                        if (UptextBox.Text == "")

                        {
                            MessageBox.Show("記入が完了していません。", "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //DataTableを生成します。
                            DataTable dataTable = new DataTable();
                            SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.upname" + " LIKE '" + UptextBox.Text + "'", con);
                            adpter.Fill(dataTable);
                            //データベースの表示
                            listView.DataSource = dataTable;
                        }
                    }
                    //名前検索
                    if (DowncheckBox.Checked == true)
                    {
                        //未入力の時はエラーをだす
                        if (DowntextBox.Text == "")
                        {
                            MessageBox.Show("記入が完了していません。", "エラー",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        }
                        else
                        {
                            DataTable dataTable = new DataTable();
                            SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.downname" + " LIKE '" + DowntextBox.Text + "'", con);
                            adpter.Fill(dataTable);
                            //データベースの表示
                            listView.DataSource = dataTable;
                        }
                    }
                    if (AddrescheckBox.Checked == true)
                    {
                        //未入力の時はエラーをだす
                        if (AddresstextBox.Text == "")
                        {
                            MessageBox.Show("記入が完了していません。", "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else 
                        {
                            DataTable dataTable = new DataTable();
                            SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.address" + " LIKE '" + AddresstextBox.Text + "'",con);
                            adpter.Fill(dataTable);
                            //データベースの表示
                            listView.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        private void CdcheckBoxCheckedChanged(object sender, EventArgs e)
        {

            //checkBox1がtrueなら他をfalseにする
            if (CdcheckBox.Checked == true)
            {
                UpcheckBox.Checked = false;
                DowncheckBox.Checked = false;
                AddrescheckBox.Checked = false;
            }
        }

        private void UpcheckBoxCheckedChanged(object sender, EventArgs e)
        {
            //checkBox2がtrueなら他をfalseにする
            if (UpcheckBox.Checked == true)
            {
                CdcheckBox.Checked = false;
                DowncheckBox.Checked = false;
                AddrescheckBox.Checked = false;
            }
        }

        private void DowncheckBoxCheckedChanged(object sender, EventArgs e)
        {
            //checkBox3がtrueなら他をfalseにする
            if (DowncheckBox.Checked == true)
            {
                CdcheckBox.Checked = false;
                UpcheckBox.Checked = false;
                AddrescheckBox.Checked = false;
            }
        }
    

        private void AddrescheckBoxCheckedChanged(object sender, EventArgs e)
        {
            //checkBox4がtrueなら他をfalseにする
            if (AddrescheckBox.Checked == true)
            {
                CdcheckBox.Checked = false;
                UpcheckBox.Checked = false;
                DowncheckBox.Checked = false;
            }
        }

        private void Cd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
