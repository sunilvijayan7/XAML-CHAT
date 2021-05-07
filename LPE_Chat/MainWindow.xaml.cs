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
using System.Data.SqlClient;
using System.Data;
using LC;

namespace LPE_Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //RememberMe tr = new RememberMe();

            //_Chk_remember.IsChecked = true;
            //Txt_username.Focus();
            //if (tr.Rememberd == true)
            //{
            //    Txt_username.Text = tr.Username;
            //    Txt_password.Password = tr.Password;
            //    Chk_remember.IsChecked = true;
            //}
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            //string _username = Txt_username.Text;
            //string _passwd = Txt_password.Password;
            //if ((_username == "") || (_passwd == ""))
            //{
            //    if (_username == "")
            //    {
            //        MessageBox.Show("Please Enter the Username");
            //        Txt_username.Text = "";
            //        Txt_password.Password = "";
            //        Txt_username.Focus();
            //        return;
            //    }

            //    if (_passwd == "")
            //    {
            //        MessageBox.Show("Please Enter the Password");
            //        Txt_password.Password = "";
            //        Txt_password.Focus();
            //        return;
            //    }
            //}
            //if ((_username != "") && (_passwd != ""))
            //{
            //    string _encrpasswd = Encrypter._0036(_passwd);
            //    DataTable dt = (DataTable)QueryExecute.Execute("select * from _tblUsersInfo where _UserEmail='" + _username + "'");
            //    if (_encrpasswd == dt.Rows[0]["_UserPassword"].ToString())
            //    {
            //        this.Visibility = Visibility.Collapsed;
            //        _ChatWindow chat = new _ChatWindow();
            //        chat.Show();
            //    }
            //}
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            _regis.Visibility = Visibility.Hidden;
            _Login.Visibility = Visibility.Visible;
        }

        private void Btn_createaccount_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _regis.Visibility = Visibility.Visible;
        }

        private void _main_LostStylusCapture_1(object sender, StylusEventArgs e)
        {

        }

        private void _lblCreatAcnt_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _lblCreatAcnt.Visibility = Visibility.Hidden;
            _Login.Visibility = Visibility.Hidden;
            _regis.Visibility = Visibility.Visible;
        }
    }
}
