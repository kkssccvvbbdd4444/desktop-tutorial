using System;
using System.Windows.Forms;

namespace Sportclub
{
    public partial class Login : Form
    {
        Main Main = null;
        public Login()
        {
            InitializeComponent();
        }



        private void LoginPassword(object sender, EventArgs e)//パスワードの入力
        {
            if (Password.Text == "00000000")　//ここでパスワードをチェック
            {
                //パスワードが一致なら次の画面を表示
                if (Main == null || Main.IsDisposed)
                {
                    //現画面を非表示
                    this.Visible = false;
                    //次画面を表示
                    Main = new Main();
                    Main.Show();
                }
            }
            //パスワードが一致しないならエラーを表示
            else
            {
                MessageBox.Show("パスワードが一致しませんでした。", "お知らせ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Password.Text = "";
            }
        }
        //入力したパスワードの表示・非表示
        private void Shownumbers(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !Password.UseSystemPasswordChar;
        }
        //数字以外を打てなくする
        private void NumericKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}