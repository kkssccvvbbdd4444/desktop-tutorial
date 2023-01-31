using System;
using System.Windows.Forms;


namespace Sportclub
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //登録画面に遷移
        private void RegistClick(object sender, EventArgs e)
        {
            this.Visible = false;

            Registration Re = new Registration();
            Re.Show();

        }

        private void DeletClick(object sender, EventArgs e)
        {
            this.Visible = false;

            Deletiondata Dd = new Deletiondata();
            Dd.Show();
        }

        private void CorrectClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            Correction Co = new Correction();
            Co.Show();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            this.Visible = false;

            Search Se = new Search();
            Se.Show();
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}