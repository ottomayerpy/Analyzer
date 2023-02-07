using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Analyzer
{
    public partial class Form1_Main : Form
    {
        public Form1_Main() => InitializeComponent();

        /*private void Select(string str)
        {
            Regex reg = new Regex(str);
            MatchCollection math = null;

            switch (Program.TabSelect)
            {
                case "TabCPU":
                    math = reg.Matches(TxtCPU.Text);
                    break;
                case "TabRAM":
                    math = reg.Matches(TxtRAM.Text);
                    break;
                case "TabGPU":
                    math = reg.Matches(TxtGPU.Text);
                    break;
                case "TabInterfaces":
                    math = reg.Matches(TxtInterfaces.Text);
                    break;
                case "TabHDD":
                    math = reg.Matches(TxtHDD.Text);
                    break;
                case "TabSystem":
                    math = reg.Matches(TxtSystem.Text);
                    break;
                case "TabServices":
                    math = reg.Matches(TxtServices.Text);
                    break;
                case "TabSoft":
                    math = reg.Matches(TxtSoft.Text);
                    break;
                case "TabProcesses":
                    math = reg.Matches(TxtProcesses.Text);
                    break;
                case "TabNetwork":
                    math = reg.Matches(TxtNetwork.Text);
                    break;
                case "TabOther":
                    math = reg.Matches(TxtOther.Text);
                    break;
                default:
                    break;
            }

            MessageBox.Show("Найдено совпадений: " + math.Count);
        }*/

        public void ShowSystemInfo()
        {
            string temp = null;

            /*Информация о процессоре*******************************************************************************************************************/
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher1.Get())
            {
                TxtCPU.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtCPU.Text += "Win32_Processor instance\n";
                TxtCPU.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtCPU.Text += string.Format("Name: {0}", queryObj["Name"]) + "\n";
                TxtCPU.Text += string.Format("NumberOfCores: {0}", queryObj["NumberOfCores"]) + "\n";
                TxtCPU.Text += string.Format("ProcessorId: {0}", queryObj["ProcessorId"]) + "\n";
            }
            /*Информация о оперативной памяти***********************************************************************************************************/
            ManagementObjectSearcher searcher0 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            TxtRAM.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
            TxtRAM.Text += "Win32_PhysicalMemory instance\n";
            TxtRAM.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";

            foreach (ManagementObject queryObj in searcher0.Get())
            {
                TxtRAM.Text += string.Format("BankLabel: {0} ; Capacity: {1} Gb; Speed: {2} ", queryObj["BankLabel"],
                                  Math.Round(Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2),
                                   queryObj["Speed"]) + "\n";
            }
            /*Информация о видеокарте*******************************************************************************************************************/
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                TxtGPU.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtGPU.Text += "Win32_VideoController instance\n";
                TxtGPU.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtGPU.Text += string.Format("AdapterRAM: {0}", queryObj["AdapterRAM"]) + "\n";
                TxtGPU.Text += string.Format("Caption: {0}", queryObj["Caption"]) + "\n";
                TxtGPU.Text += string.Format("Description: {0}", queryObj["Description"]) + "\n";
                TxtGPU.Text += string.Format("VideoProcessor: {0}", queryObj["VideoProcessor"]) + "\n";
            }
            /*Список интерфейсов с основными настройками************************************************************************************************/
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject queryObj in searcher3.Get())
            {
                TxtInterfaces.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtInterfaces.Text += "Win32_NetworkAdapterConfiguration instance\n";
                TxtInterfaces.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtInterfaces.Text += string.Format("Caption: {0}", queryObj["Caption"]) + "\n";

                if (queryObj["DefaultIPGateway"] == null)
                    TxtInterfaces.Text += string.Format("DefaultIPGateway: {0}", queryObj["DefaultIPGateway"]) + "\n";
                else
                {
                    string[] arrDefaultIPGateway = (string[])queryObj["DefaultIPGateway"];
                    foreach (string arrValue in arrDefaultIPGateway)
                    {
                        TxtInterfaces.Text += string.Format("DefaultIPGateway: {0}", arrValue) + "\n";
                    }
                }

                if (queryObj["DNSServerSearchOrder"] == null)
                    TxtInterfaces.Text += string.Format("DNSServerSearchOrder: {0}", queryObj["DNSServerSearchOrder"]) + "\n";
                else
                {
                    string[] arrDNSServerSearchOrder = (string[])queryObj["DNSServerSearchOrder"];
                    foreach (string arrValue in arrDNSServerSearchOrder)
                    {
                        TxtInterfaces.Text += string.Format("DNSServerSearchOrder: {0}", arrValue) + "\n";
                    }
                }

                if (queryObj["IPAddress"] == null)
                    TxtInterfaces.Text += string.Format("IPAddress: {0}", queryObj["IPAddress"]) + "\n";
                else
                {
                    string[] arrIPAddress = (string[])queryObj["IPAddress"];
                    foreach (string arrValue in arrIPAddress)
                    {
                        TxtInterfaces.Text += string.Format("IPAddress: {0}", arrValue) + "\n";
                    }
                }

                if (queryObj["IPSubnet"] == null)
                    TxtInterfaces.Text += string.Format("IPSubnet: {0}", queryObj["IPSubnet"]) + "\n";
                else
                {
                    string[] arrIPSubnet = (string[])queryObj["IPSubnet"];
                    foreach (string arrValue in arrIPSubnet)
                    {
                        TxtInterfaces.Text += string.Format("IPSubnet: {0}", arrValue) + "\n";
                    }
                }
                TxtInterfaces.Text += string.Format("MACAddress: {0}", queryObj["MACAddress"]) + "\n";
                TxtInterfaces.Text += string.Format("ServiceName: {0}", queryObj["ServiceName"] + "\n");
            }
            /*Информация о дисках***********************************************************************************************************************/
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");

            foreach (ManagementObject queryObj in searcher4.Get())
            {
                TxtHDD.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtHDD.Text += "Win32_Volume instance\n";
                TxtHDD.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtHDD.Text += string.Format("Capacity: {0}", queryObj["Capacity"]) + "\n";
                TxtHDD.Text += string.Format("Caption: {0}", queryObj["Caption"]) + "\n";
                TxtHDD.Text += string.Format("DriveLetter: {0}", queryObj["DriveLetter"]) + "\n";
                TxtHDD.Text += string.Format("DriveType: {0}", queryObj["DriveType"]) + "\n";
                TxtHDD.Text += string.Format("FileSystem: {0}", queryObj["FileSystem"]) + "\n";
                TxtHDD.Text += string.Format("FreeSpace: {0}", queryObj["FreeSpace"]) + "\n";
            }
            /*Информация о системе**********************************************************************************************************************/
            ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher5.Get())
            {
                TxtSystem.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtSystem.Text += "Win32_OperatingSystem instance\n";
                TxtSystem.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtSystem.Text += string.Format("BuildNumber: {0}", queryObj["BuildNumber"]) + "\n";
                TxtSystem.Text += string.Format("Caption: {0}", queryObj["Caption"]) + "\n";
                TxtSystem.Text += string.Format("FreePhysicalMemory: {0}", queryObj["FreePhysicalMemory"]) + "\n";
                TxtSystem.Text += string.Format("FreeVirtualMemory: {0}", queryObj["FreeVirtualMemory"]) + "\n";
                TxtSystem.Text += string.Format("Name: {0}", queryObj["Name"]) + "\n";
                TxtSystem.Text += string.Format("OSType: {0}", queryObj["OSType"]) + "\n";
                TxtSystem.Text += string.Format("RegisteredUser: {0}", queryObj["RegisteredUser"]) + "\n";
                TxtSystem.Text += string.Format("SerialNumber: {0}", queryObj["SerialNumber"]) + "\n";
                TxtSystem.Text += string.Format("ServicePackMajorVersion: {0}", queryObj["ServicePackMajorVersion"]) + "\n";
                TxtSystem.Text += string.Format("ServicePackMinorVersion: {0}", queryObj["ServicePackMinorVersion"]) + "\n";
                TxtSystem.Text += string.Format("Status: {0}", queryObj["Status"]) + "\n";
                TxtSystem.Text += string.Format("SystemDevice: {0}", queryObj["SystemDevice"]) + "\n";
                TxtSystem.Text += string.Format("SystemDirectory: {0}", queryObj["SystemDirectory"]) + "\n";
                TxtSystem.Text += string.Format("SystemDrive: {0}", queryObj["SystemDrive"]) + "\n";
                TxtSystem.Text += string.Format("Version: {0}", queryObj["Version"]) + "\n";
                TxtSystem.Text += string.Format("WindowsDirectory: {0}", queryObj["WindowsDirectory"]) + "\n";
            }
            /*Список всех служб*************************************************************************************************************************/
            ManagementObjectSearcher searcher6 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Service");

            foreach (ManagementObject queryObj in searcher6.Get())
            {
                TxtServices.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtServices.Text += "Win32_Service instance\n";
                TxtServices.Text += "------------------------------------------------------------------------------------------------------------------------------------------------------\n";
                TxtServices.Text += string.Format("Caption: {0}", queryObj["Caption"]) + "\n";
                TxtServices.Text += string.Format("Description: {0}", queryObj["Description"]) + "\n";
                TxtServices.Text += string.Format("DisplayName: {0}", queryObj["DisplayName"]) + "\n";
                TxtServices.Text += string.Format("Name: {0}", queryObj["Name"]) + "\n";
                TxtServices.Text += string.Format("PathName: {0}", queryObj["PathName"]) + "\n";
                TxtServices.Text += string.Format("Started: {0}", queryObj["Started"]) + "\n";
            }
            /*Список установленных программ*************************************************************************************************************/
            ManagementObjectSearcher searcher7 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Product");

            foreach (ManagementObject queryObj in searcher7.Get())
            {
                TxtSoft.Text += string.Format("Caption: {0}; InstallDate: {1}", queryObj["Caption"], queryObj["InstallDate"]) + "\n";
            }
            /*Список запущенных процессов***************************************************************************************************************/
            ManagementObjectSearcher searcher8 = new ManagementObjectSearcher("root\\CIMV2", "Select Name, CommandLine From Win32_Process");

            foreach (ManagementObject instance in searcher8.Get())
            {
                TxtProcesses.Text += instance["Name"] + "\n";
            }
            /*Сеть**************************************************************************************************************************************/
            TxtNetwork.Text += GetIpConfig();
            /*Прочее************************************************************************************************************************************/
            if (Environment.Is64BitOperatingSystem) temp = "x64 (64bit)"; else temp = "x86 (32bit)";
            TxtOther.Text += "Операционная система (номер версии): " + Environment.OSVersion + "\n";
            TxtOther.Text += "Разрядность процессора: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") + "\n";
            TxtOther.Text += "Модель процессора: " + Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER") + "\n";
            TxtOther.Text += "Путь к системному каталогу: " + Environment.SystemDirectory + "\n";
            TxtOther.Text += "Число процессоров: " + Environment.ProcessorCount + "\n";
            TxtOther.Text += "Имя пользователя: " + Environment.UserName + "\n";
            TxtOther.Text += "Имя сетевого домена: " + Environment.UserDomainName + "\n";
            TxtOther.Text += "Юзает ли пользователь GUI: " + Environment.UserInteractive + "\n";
            TxtOther.Text += "Версия CLR: " + Environment.Version + "\n";
            TxtOther.Text += "Время истекшее с момента загрузки системы (min/ms): " + Environment.TickCount / 60000 + "/" + Environment.TickCount + "\n";
            TxtOther.Text += "Имя NetBIOS: " + Environment.MachineName + "\n";
            TxtOther.Text += "Разрядность системы: " + temp + "\n";
            TxtOther.Text += "Действующий мак адрес сетевой карты: " + GetMACAddress() + "\n";
            TxtOther.Text += "Имя узла: " + Dns.GetHostName() + "\n";
        }

        public string GetIpConfig()
        {
            string text = "None";

            ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", @"/C ipconfig /all")
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(866)
            };

            Process procCommand = Process.Start(psiOpt);
            StreamReader srIncoming = procCommand.StandardOutput;
            text = srIncoming.ReadToEnd();
            procCommand.WaitForExit();
            return text;
        }

        public string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = string.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == string.Empty)
                {
                    if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }
            return MACAddress;
        }

        private void ButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSystemInfo();
        }

        private void CPUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.TabSelect = TabControl.SelectedTab.Name;
        }

        private void Form1_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.F))
            {
                Form2_Search f = new Form2_Search { Owner = this };
                f.Show();
            }
        }
    }
}