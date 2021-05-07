namespace LC
{
    using System.Management;
    using System.Net;
    using System.Text.RegularExpressions;

    public class SystemInfo
    {
        public static string GetMACID()
        {
            string systemName = System.Environment.MachineName;
            try
            {
                ManagementScope theScope = new ManagementScope("\\\\" + systemName + "\\root\\cimv2");
                ObjectQuery theQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
                ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);
                ManagementObjectCollection theCollectionOfResults = theSearcher.Get();
                foreach (ManagementObject theCurrentObject in theCollectionOfResults)
                {
                    if (theCurrentObject["MACAddress"] != null)
                    {
                        string macAdd = theCurrentObject["MACAddress"].ToString();
                        return macAdd.Replace(':', '-');
                    }
                }
            }
            catch (ManagementException)
            {
            }
            catch (System.UnauthorizedAccessException)
            {
            }
            return string.Empty;
        }

        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

        public static string GetIP()
        {
            string externalIP = "";
            externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                         .Matches(externalIP)[0].ToString();
            return externalIP;

        }

        public static string SysName()
        {
            string sysname = "";
            sysname = System.Environment.MachineName;
            return sysname;
        }
    }
}