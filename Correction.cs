using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportclub
{
    public partial class Correction : Form
    {
        public Correction()
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
        private void CorrectionsClick(object sender, EventArgs e)
        {
            //修正する情報が未入力のときの処理
            if (Cd.Text == "" || Upname.Text == "" || Downname.Text == "" || Address.Text == "" || Tel.Text == "")
            {
                MessageBox.Show("記入が完了していません。", "エラー",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {

                using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))

                {
                    DialogResult result = MessageBox.Show("修正しますか？" + Environment.NewLine + "※データは元に戻せません", "タイトル", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            SQLiteCommand cmd = con.CreateCommand();
                            //インサート　
                            cmd.CommandText = "UPDATE t_product set Upname = @upname, Downname = @downname, Address = @address, Tel = @tel WHERE Cd = @Cd";
                            //パラメータセット
                            cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                            cmd.Parameters.Add("upname", System.Data.DbType.String);
                            cmd.Parameters.Add("downname", System.Data.DbType.String);
                            cmd.Parameters.Add("address", System.Data.DbType.String);
                            cmd.Parameters.Add("tel", System.Data.DbType.String);
                            //データ追加
                            cmd.Parameters["Cd"].Value = int.Parse(Cd.Text);
                            cmd.Parameters["upname"].Value = Upname.Text;
                            cmd.Parameters["downname"].Value = Downname.Text;
                            cmd.Parameters["address"].Value = Address.Text;
                            cmd.Parameters["tel"].Value = Tel.Text;
                            cmd.ExecuteNonQuery();
                            //コミット
                            trans.Commit();
                            MessageBox.Show("修正しました。");
                            //DataTableを生成
                            DataTable dataTables = new DataTable();
                            //SQLの実行、データの表示
                            SQLiteDataAdapter adpters = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                            adpters.Fill(dataTables);
                            listView.DataSource = dataTables;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("修正しません。");
                    }
                }
            }
        }

        private void LoadClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))
            {
                //DataTableを生成。
                DataTable dataTable = new DataTable();
                //SQLの実行、データの表示
                SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adpter.Fill(dataTable);
                listView.DataSource = dataTable;
            }
        }
    }
}
