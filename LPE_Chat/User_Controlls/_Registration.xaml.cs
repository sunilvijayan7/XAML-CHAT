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
using System.Text.RegularExpressions;
using LC;

namespace LPE_Chat.User_Controlls
{
    /// <summary>
    /// Interaction logic for _Registration.xaml
    /// </summary>
    public partial class _Registration : UserControl
    {
        public _Registration()
        {
            InitializeComponent();

            #region
            List<string> _cmbItems = new List<string>();
            _cmbItems.Add("What is you father name?");
            _cmbItems.Add("What is yor pet name?");
            _cmbItems.Add("What is your phone number?");
            _cmbItems.Add("What is your girlfriend's name?");
            _cmbItems.Add("What is your name?");


            foreach (string list in _cmbItems)
            {
                _CmbSecureQues.Items.Add(list);
            }
            #endregion
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            _CirprogrssBar.Visibility = Visibility.Hidden;
        }

        private void _txtFstName_GotFocus(object sender, RoutedEventArgs e)
        {
            _txtFstName.Text = "";
        }

        private void Grid_GotFocus_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void _txtLstName_GotFocus(object sender, RoutedEventArgs e)
        {
            _txtLstName.Text = "";
        }

        private void _txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            _txtEmail.Text = "";
        }

        private void _txtUsrName_GotFocus(object sender, RoutedEventArgs e)
        {
            _txtUsrName.Text = ""; 
        }

        private void _Pwd_Password_GotFocus(object sender, RoutedEventArgs e)
        {
            _Pwd_Password.Password = "";
        }

        private void _PwdRePasswd_GotFocus(object sender, RoutedEventArgs e)
        {
            _PwdRePasswd.Password = "";
        }

        private void _txtAnswer_GotFocus(object sender, RoutedEventArgs e)
        {
            _txtAnswer.Text = "";
        }

        private void _btnRegSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (_CirprogrssBar.Visibility == Visibility.Hidden)
            {
                _CirprogrssBar.Visibility = Visibility.Visible;

                if ((_Pwd_Password.Password != "") && (_PwdRePasswd.Password != ""))
                {
                    if (Encrypter._0036(_Pwd_Password.Password) == (Encrypter._0036(_PwdRePasswd.Password)))
                    {
                        string _fstName = _txtFstName.Text;
                        string _lstName = _txtLstName.Text;
                        string _email = _txtEmail.Text;
                        string _newPassed = _Pwd_Password.Password.ToString();
                        string _confPasswd = _PwdRePasswd.Password.ToString();
                        string _secureQues = _CmbSecureQues.SelectedItem.ToString();
                        string _secureAns = _txtAnswer.Text;

                        if ((_fstName == "") || (_lstName == "") || (_email == "") || (_newPassed == "") || (_confPasswd == "") || (_secureQues == "") || (_secureAns == ""))
                        {
                            if (_fstName == "")
                            {
                                MessageBox.Show("Fast Name Can't be Empty");
                                _txtFstName.Text = "";
                                _txtFstName.Focus();
                                return;
                            }
                            if (_lstName == "")
                            {
                                MessageBox.Show("Please Enter Last Name");
                                _txtLstName.Text = "";
                                _txtLstName.Focus();
                                return;
                            }
                            if (_email == "")
                            {
                                MessageBox.Show("Please Enter the E-Mail");
                                _txtEmail.Text = "";
                                _txtEmail.Focus();
                                return;
                            }
                            if (_secureQues == "")
                            {
                                MessageBox.Show("Please Seclect the Security Question");
                                _CmbSecureQues.Focus();
                                return;
                            }
                            if (_secureAns == "")
                            {
                                MessageBox.Show("Plese Entet the Answer");
                                _txtAnswer.Text = "";
                                _txtAnswer.Focus();
                                return;
                            }
                        }
                        if ((_fstName != "") || (_lstName != "") || (_email != "") || (_secureQues != "") || (_secureAns != ""))
                        {
                            var regex1 = new Regex("[^a-zA-Z]");                 // Regex For Fastname and Lastname.
                            var regex2 = new Regex(@"[^[a-z0-9][a-z0-9_\.-]{0,}[a-z0-9]@[a-z0-9][a-z0-9_\.-]{0,}[a-z0-9][\.][a-z0-9]{2,4}$]");     // Regex for E-Mail Address.
                            var regex3 = new Regex("[^a-zA-Z0-9._]");
                            var regex4 = new Regex("[^a-zA-Z0-9]");      //Regex for security Answer.

                            if (regex1.IsMatch(_fstName))
                            {
                                MessageBox.Show("Only Charecters are allowed");
                                _txtFstName.Text = "";
                                _txtFstName.Focus();
                                return;
                            }
                            if (regex1.IsMatch(_lstName))
                            {
                                MessageBox.Show("Only Charecters are allowed");
                                _txtLstName.Text = "";
                                _txtLstName.Focus();
                                return;
                            }
                            if (regex2.IsMatch(_email))
                            {
                                MessageBox.Show("Not a Valid email ID");
                                _txtEmail.Text = "";
                                _txtEmail.Focus();
                                return;
                            }
                            if (regex4.IsMatch(_secureAns))
                            {
                                MessageBox.Show("Only charecters and Numerics are allowed");
                                _txtAnswer.Text = "";
                                _txtAnswer.Focus();
                                return;
                            }
                            try
                            {
                                Executers.Insert("_tblUsersInfo", RandomGen.GetUniqueKey(), _txtFstName.Text, _txtLstName.Text, _txtEmail.Text, Encrypter._0036(_Pwd_Password.Password), _CmbSecureQues.SelectedItem.ToString(), _txtAnswer.Text, DateTime.Now.ToString(), SystemInfo.GetMACID(), SystemInfo.GetIP(), SystemInfo.GetOSFriendlyName(), SystemInfo.SysName());
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Fields Can't be blanlk");
                        _Pwd_Password.Password = "";
                        _PwdRePasswd.Password = "";
                        return;
                    }
                }
                //_CirprogrssBar.Visibility = Visibility.Hidden;
            }
        }

        private void _btnRegCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
