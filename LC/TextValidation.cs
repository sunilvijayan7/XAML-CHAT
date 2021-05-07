using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LC
{
    public class TextValidation
    {
        public static int result = 0;

        public static bool Check(string fastname, string lastname, string email, string newpass, string securityques, string securityansw)
        {
            if ((fastname == "") || (lastname == "") || (email == "") ||  (newpass == "") || (securityques == "") || (securityansw == ""))
            {
                if (fastname == "")
                {

                    DialogResult _0014 = MessageBox.Show(Properties.Resources._sms001, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0014 == DialogResult.OK)
                    {
                        result = 1;
                    }
                    return false;
                }   
                if (lastname == "")
                {
                    DialogResult _0016 = MessageBox.Show(Properties.Resources._sms002, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0016 == DialogResult.OK)
                    {
                        result = 2;
                    }
                    return false;
                }
                if (email == "")
                {
                    DialogResult _0017 = MessageBox.Show(Properties.Resources._sms003, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0017 == DialogResult.OK)
                    {
                        result = 3;
                    }
                    return false;
                }
                if (newpass == "")
                {
                    DialogResult _0019 = MessageBox.Show(Properties.Resources._sms005, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0019 == DialogResult.OK)
                    {
                        result = 5;
                    }
                    return false;
                }
                if (securityques == "")
                {
                    DialogResult _0021 = MessageBox.Show(Properties.Resources._sms007, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0021 == DialogResult.OK)
                    {
                        result = 7;
                    }
                    return false;
                }
                if (securityansw == "")
                {
                    DialogResult _0022 = MessageBox.Show(Properties.Resources._sms008, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_0022 == DialogResult.OK)
                    {
                        result = 8;
                    }
                    return false;
                }
            }
            if ((fastname != "") || (lastname != "") || (email != "") || (newpass != "") || (securityques != "") || (securityansw != ""))
            {
                if (fastname != "")
                {
                    var _0009 = new Regex("[^a-zA-Z]");
                    var _0010 = new Regex(@"[^[a-z0-9][a-z0-9_\.-]{0,}[a-z0-9]@[a-z0-9][a-z0-9_\.-]{0,}[a-z0-9][\.][a-z0-9]{2,4}$]");
                    var _0011 = new Regex("[^a-zA-Z0-9._]");
                    var _0012 = new Regex("[^a-zA-Z0-9]");

                    if (_0009.IsMatch(fastname))
                    {
                        DialogResult _0023 = MessageBox.Show(Properties.Resources._sms009, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (_0023 == DialogResult.OK)
                        {
                            result = 1;
                        }
                        return false;
                    }
                    if (_0009.IsMatch(lastname))
                    {
                        DialogResult _0024 = MessageBox.Show(Properties.Resources._sms009, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (_0024 == DialogResult.OK)
                        {
                            result = 2;
                        }
                        return false;
                    }
                    if (_0010.IsMatch(email))
                    {
                        DialogResult _0025 = MessageBox.Show(Properties.Resources._sms010, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (_0025 == DialogResult.OK)
                        {
                            result = 3;
                        }
                        return false;
                    }
                    if (_0012.IsMatch(securityansw))
                    {
                        DialogResult _0027 = MessageBox.Show(Properties.Resources._sms012, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (_0027 == DialogResult.OK)
                        {
                            result = 8;
                        }
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
