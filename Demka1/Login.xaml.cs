using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Demka1.DBSetTableAdapters;

namespace Demka1
{
    public partial class Login : Window
    {
        DBSet dbSet = new DBSet();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        public Login()
        {
            InitializeComponent();
        }
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text != "" && Password.Password != "")
            {
                int? id_user = usersTableAdapter.Login(Username.Text, Password.Password);
                if(id_user == null)
                {
                    ExeptionBlock.Text = "Пользователь не найден";
                }
                else if(id_user != null)
                {
                    ExeptionBlock.Text = "Пользователь найден!";
                }
            }
            else
                ExeptionBlock.Text = "Поле логина или пароля пусто!";
        }
        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
