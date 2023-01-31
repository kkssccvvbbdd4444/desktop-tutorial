using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportclub
{
    public partial class Registration : Form ///新規登録
    {     
        public Registration()
        {
            InitializeComponent();
        }


        private void Back(object sender, EventArgs e)
        {
            //Mainを表示
            Main Main = new Main();
            Main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        private void CreaTetable(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル作成して閉じる  
            using (var con = new SQLiteConnection("Data Source=Table.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                       "Create table t_product(Cd INTEGER  PRIMARY KEY AUTOINCREMENT, Upname TEXT,Downname TEXT,Year INTEGER,Month INTEGER,Day INTEGER,Address TEXT,Tel TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        private void SaveClick(object sender, EventArgs e)
        {
            //現在より先の時間を入力した場合にエラーを出す
            string TextValue = Year.Text;//Year.Textの値を設定
            DateTime dt = DateTime.Now;//今の年を設定
            string Yeartime = dt.ToString();//dtを文字列に変換
            //個人情報の入力が完了してないときの処理
            if (Upname.Text == "" || Downname.Text == "" || Year.Text == "" || Month.Text == "" || Day.Text == "" || Address.Text == "" || Tel.Text == "" )
            {
                MessageBox.Show("記入が完了していません。", "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                //現在の年より上の数字を打った場合エラーを出す
                switch (TextValue.CompareTo(Yeartime)) 
                {
                    case 1:
                        MessageBox.Show("設定できない数値が入力されました。", "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Year.Text = "";
                        break;
                        default:
                        //データベースを開いて保存する処理
                        using (SQLiteConnection con = new SQLiteConnection("Data Source=Table.db"))
                        {
                            con.Open();
                            using (SQLiteTransaction trans = con.BeginTransaction())
                            {
                                DialogResult result = MessageBox.Show("保存しますか？", "タイトル", MessageBoxButtons.YesNo);
                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    SQLiteCommand cmd = con.CreateCommand();
                                    //インサート
                                    cmd.CommandText = "INSERT INTO t_product (Upname,Downname,Year,Month,Day,Address,Tel) VALUES (@upname,@downname,@year,@month,@day,@address,@tel)";
                                    //パラメータセット
                                    cmd.Parameters.Add("upname", System.Data.DbType.String);
                                    cmd.Parameters.Add("downname", System.Data.DbType.String);
                                    cmd.Parameters.Add("year", System.Data.DbType.Int64);
                                    cmd.Parameters.Add("month", System.Data.DbType.String);
                                    cmd.Parameters.Add("day", System.Data.DbType.String);
                                    cmd.Parameters.Add("address", System.Data.DbType.String);
                                    cmd.Parameters.Add("tel", System.Data.DbType.String);
                                    //データ追加
                                    cmd.Parameters["upname"].Value = Upname.Text;
                                    cmd.Parameters["downname"].Value = Downname.Text;
                                    cmd.Parameters["year"].Value = int.Parse(Year.Text);
                                    cmd.Parameters["month"].Value = int.Parse((string)Month.SelectedItem);
                                    cmd.Parameters["day"].Value = int.Parse((string)Day.SelectedItem);
                                    cmd.Parameters["address"].Value = Address.Text;
                                    cmd.Parameters["tel"].Value = Tel.Text;
                                    cmd.ExecuteNonQuery();
                                    //コミット
                                    trans.Commit();
                                    MessageBox.Show("保存しました。");
                                    //DataTableを生成します。
                                    DataTable dataTable = new DataTable();
                                    //データ表示
                                    SQLiteDataAdapter adpter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                                    var dataTables = new DataTable();
                                    //データ表示
                                    var adpters = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                                    adpter.Fill(dataTable);
                                    listView.DataSource = dataTable;
                                }
                                else if (result == System.Windows.Forms.DialogResult.No)
                                {
                                    MessageBox.Show("保存されません。");
                                    Upname.Text = "";
                                    Downname.Text = "";
                                    Year.Text = "";
                                    Address.Text = "";
                                    Tel.Text = "";
                                }
                                break;
                            }
                        }
                }
            }
        }

        
        //数字のみ打てるようにする
        private void YearKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void LoadClick(object sender, EventArgs e)
        {
            //データの読み込み

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
        //数値を文字列に変換
        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = Month.SelectedItem.ToString();
        }
        //数値を文字列に変換
        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedIte2 = Day.SelectedItem.ToString();
        }

        private void Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}   