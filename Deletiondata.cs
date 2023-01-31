using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportclub
{
    public partial class Deletiondata : Form
    {
        public Deletiondata()
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

        private void EraseClick(object sender, EventArgs e)
        {
            // Cdが未入力の時はエラーをだす

            //未入力の時はエラーをだす

            if (Cd.Text == "")
            {
                MessageBox.Show("記入が完了していません。", "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))
                {
                    DialogResult result = MessageBox.Show("削除しますか？" + Environment.NewLine + "※データは元に戻せません", "タイトル", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            SQLiteCommand cmd = con.CreateCommand();
                            //インサート
                            cmd.CommandText = "DELETE FROM t_product WHERE Cd = @cd;";
                            //パラメータセット
                            cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                            //データ削除
                            cmd.Parameters["Cd"].Value = int.Parse(Cd.Text);
                            cmd.ExecuteNonQuery();
                            //コミット
                            trans.Commit();
                            MessageBox.Show("削除しました。");
                            //DataTableを生成します。

                            DataTable dataTable = new DataTable();
                            //SQLの実行
                            SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                            adpter.Fill(dataTable);
                            listView.DataSource = dataTable;

                            var dataTables = new DataTable();
                        }
                    }
                    else if (result == System.Windows.Forms.DialogResult.No)
                    {
                        MessageBox.Show("削除しません。");
                        Cd.Text = "";
                    }
                }

            }
        }

        private void LoadClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))
            {
                //DataTableを生成
                DataTable dataTable = new DataTable();
                //SQLの実行、データの表示
                SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adpter.Fill(dataTable);
                listView.DataSource = dataTable;
            }
        }

       //数字のみ打てるようにする
        private void CdKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
