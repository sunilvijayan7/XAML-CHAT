using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LC;

namespace LPE_Chat.User_Controlls
{
    /// <summary>
    /// Interaction logic for _login.xaml
    /// </summary>
    public partial class _login : UserControl
    {
        public _login()
        {
            InitializeComponent();
        }

        private void _Btn_login_Click(object sender, RoutedEventArgs e)
        {
            Login._chklogin(_Txt_username.Text.ToString(), Encrypter._0036(_Txt_password.Password.ToString()));
            if (Login._chkStatus == 1)
            {
                MessageBox.Show("sueccess");
            }
            if (Login._chkStatus == 2)
            {
                MessageBox.Show("password not match");
            }
            if (Login._chkStatus == 3)
            {
                MessageBox.Show("no record");
            }
            if (Login._chkStatus == 4)
            {
                MessageBox.Show("Enter Username and Password");
            }
        }

        private void _Btn_createaccount_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _Registration _reg = new _Registration();
            _ChatWindow _chat = new _ChatWindow();
            _chat.Show();
            
        }
    }
}
