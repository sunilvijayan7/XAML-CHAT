namespace ls
{
    public class RememberMe
    {
        public static void _0041(string _0032, string _0033)
        {
            Properties.Settings.Default._0037 = Encrypter._0034(_0032).ToString();
            Properties.Settings.Default._0038 = Encrypter._0034(_0033).ToString();
            Properties.Settings.Default._0039 = true;
            Properties.Settings.Default.Save();
        }

        public string _0042 = Encrypter._0035(Properties.Settings.Default._0037);
        public string _0043 = Encrypter._0035(Properties.Settings.Default._0038);
        public bool _0044 = Properties.Settings.Default._0039;

        public string Username
        {
            get { return _0042; }
            set { _0042 = value; }
        }

        public string Password
        {
            get { return _0043; }
            set { _0043 = value; }
        }

        public bool Rememberd
        {
            get { return _0044; }
            set { _0044 = value; }
        }
    }
}