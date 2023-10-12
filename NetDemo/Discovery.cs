using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NETSDKHelper;
using System.IO;
using Newtonsoft.Json;
using static NetDemo.NetDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetDemo
{
    public partial class Discovery : Form
    {
        NetDemo m_oNetDemo = null;
        private List<NETDEV_DISCOVERY_DEVINFO_S> oDeviceInfoList = new List<NETDEV_DISCOVERY_DEVINFO_S>();
        private List<string> oDeviceIPList = new List<string>();
        private List<Int16> oDevicePortList = new List<short>();
        private List<string> oDeviceTypeList = new List<string>();

        public Discovery(NetDemo oNetDemo)
        {
            this.m_oNetDemo = oNetDemo;
            InitializeComponent();
        }

        //auto search
        private void AutoSearchBtn_Click(object sender, EventArgs e)
        {
            discovery("0.0.0.0", "0.0.0.0");
        }
        public class CameraClass
        {
            public int cameraNo { get; set; }
            public string Ip { get; set; }
            public string Port { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string CameraType { get; set; }
        }
        //segment search
        private void segmentSearchBtn_Click(object sender, EventArgs e)
        {
            string strStartIP = this.startIPext.Text;
            string strEndIP = this.endIPText.Text;
            discovery(strStartIP, strEndIP);
        }

        //add device
        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            NetDemo netdemo = new NetDemo();

            String strUserName = this.userNameText.Text;
            String strPassword = this.passwordText.Text;
            if (strUserName == "" || strPassword == "")
            {
                return;
            }


            #region Kayıtlı kamera kontrolü
            string dosyaAdi = "kayitlar.json";
            string klasorYolu = Path.Combine(Application.LocalUserAppDataPath);
            string dosyaYolu = Path.Combine(klasorYolu, dosyaAdi);

            // Dosya var mı diye kontrol et
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Hiç kamera ayarları kayıt edilmemiş");
            }
            else
            {
                // Dosyayı oku
                string json = File.ReadAllText(dosyaYolu);

                // JSON verisini Kayit nesnelerine dönüştür
                KameraSettings kayitlar = JsonConvert.DeserializeObject<KameraSettings>(json);
                netdemo.txt_cam1_ip_adress.Text = kayitlar.cam1_ipadress;
                netdemo.txt_cam1_password.Text = kayitlar.cam1_password;
                netdemo.txt_cam1_port.Text = kayitlar.cam1_port;
                netdemo.txt_cam1_username.Text = kayitlar.cam1_username;
                netdemo.txt_cam2_ip_adress.Text = kayitlar.cam2_ipadress;
                netdemo.txt_cam2_password.Text = kayitlar.cam2_password;
                netdemo.txt_cam2_port.Text = kayitlar.cam2_port;
                netdemo.txt_cam2_username.Text = kayitlar.cam2_username;
                netdemo.txt_cam3_ip_adress.Text = kayitlar.cam3_ipadress;
                netdemo.txt_cam3_port.Text = kayitlar.cam3_port;
                netdemo.txt_cam3_username.Text = kayitlar.cam3_username;
                netdemo.txt_cam3_password.Text = kayitlar.cam3_password;
                netdemo.txt_cam4_ip_adress.Text = kayitlar.cam4_ipadress;
                netdemo.txt_cam4_port.Text = kayitlar.cam4_port;
                netdemo.txt_cam4_username.Text = kayitlar.cam4_username;
                netdemo.txt_cam4_password.Text = kayitlar.cam4_password;

            }
            #endregion

            for (int i = 0; i < DeviceInfoListView.Items.Count; i++)
            {

                if (oDeviceIPList[i] == netdemo.txt_cam2_ip_adress.Text || oDeviceIPList[i] == netdemo.txt_cam1_ip_adress.Text || oDeviceIPList[i] == netdemo.txt_cam3_ip_adress.Text || oDeviceIPList[i] == netdemo.txt_cam4_ip_adress.Text)
                {
                    MessageBox.Show(oDeviceIPList[i] + " Ip adresli kamera kayıtlı");
                }


                if (netdemo.txt_cam1_ip_adress.Text == "")
                {
                    netdemo.txt_cam1_ip_adress.Text = oDeviceIPList[i];
                    netdemo.txt_cam1_port.Text = oDevicePortList[i].ToString();
                    netdemo.txt_cam1_username.Text = strUserName;
                    netdemo.txt_cam1_password.Text = strPassword;


                }
                else if (netdemo.txt_cam2_ip_adress.Text == "")
                {
                    netdemo.txt_cam2_ip_adress.Text = oDeviceIPList[i];
                    netdemo.txt_cam2_port.Text = oDevicePortList[i].ToString();
                    netdemo.txt_cam2_username.Text = strUserName;
                    netdemo.txt_cam2_password.Text = strPassword;
                }
                else if (netdemo.txt_cam3_ip_adress.Text == "")
                {
                    netdemo.txt_cam3_ip_adress.Text = oDeviceIPList[i];
                    netdemo.txt_cam3_port.Text = oDevicePortList[i].ToString();
                    netdemo.txt_cam3_username.Text = strUserName;
                    netdemo.txt_cam3_password.Text = strPassword;
                }
                else if (netdemo.txt_cam4_ip_adress.Text == "")
                {
                    netdemo.txt_cam4_ip_adress.Text = oDeviceIPList[i];
                    netdemo.txt_cam4_port.Text = oDevicePortList[i].ToString();
                    netdemo.txt_cam4_username.Text = strUserName;
                    netdemo.txt_cam4_password.Text = strPassword;
                }
                else
                {
                    MessageBox.Show("Kayıtlı kamera alanınız dolu");
                }
                var kayitlar = new KameraSettings
                {
                    cam1_ipadress = netdemo.txt_cam1_ip_adress.Text,
                    cam1_port = netdemo.txt_cam1_port.Text,
                    cam1_username = netdemo.txt_cam1_username.Text,
                    cam1_password = netdemo.txt_cam1_password.Text,
                    cam2_ipadress = netdemo.txt_cam2_ip_adress.Text,
                    cam2_port = netdemo.txt_cam2_port.Text,
                    cam2_username = netdemo.txt_cam2_username.Text,
                    cam2_password = netdemo.txt_cam2_password.Text,
                    cam3_ipadress = netdemo.txt_cam3_ip_adress.Text,
                    cam3_port = netdemo.txt_cam3_port.Text,
                    cam3_username = netdemo.txt_cam3_username.Text,
                    cam3_password = netdemo.txt_cam3_password.Text,
                    cam4_ipadress = netdemo.txt_cam4_ip_adress.Text,
                    cam4_port = netdemo.txt_cam4_port.Text,
                    cam4_username = netdemo.txt_cam4_username.Text,
                    cam4_password = netdemo.txt_cam4_password.Text,
                };
                dosyaAdi = "kayitlar.json";
                klasorYolu = Path.Combine(Application.LocalUserAppDataPath);
                dosyaYolu = Path.Combine(klasorYolu, dosyaAdi);

                // Nesneyi JSON formatına dönüştür
                string json = JsonConvert.SerializeObject(kayitlar, Newtonsoft.Json.Formatting.Indented);

                // JSON verisini dosyaya yaz
                File.WriteAllText(dosyaYolu, json);
                netdemo.txt_cam1_ip_adress.Text = kayitlar.cam1_ipadress;
                netdemo.txt_cam1_password.Text = kayitlar.cam1_password;
                netdemo.txt_cam1_port.Text = kayitlar.cam1_port;
                netdemo.txt_cam1_username.Text = kayitlar.cam1_username;
                netdemo.txt_cam2_ip_adress.Text = kayitlar.cam2_ipadress;
                netdemo.txt_cam2_password.Text = kayitlar.cam2_password;
                netdemo.txt_cam2_port.Text = kayitlar.cam2_port;
                netdemo.txt_cam2_username.Text = kayitlar.cam2_username;
                netdemo.txt_cam3_ip_adress.Text = kayitlar.cam3_ipadress;
                netdemo.txt_cam3_port.Text = kayitlar.cam3_port;
                netdemo.txt_cam3_username.Text = kayitlar.cam3_username;
                netdemo.txt_cam3_password.Text = kayitlar.cam3_password;
                netdemo.txt_cam4_ip_adress.Text = kayitlar.cam4_ipadress;
                netdemo.txt_cam4_port.Text = kayitlar.cam4_port;
                netdemo.txt_cam4_username.Text = kayitlar.cam4_username;
                netdemo.txt_cam4_password.Text = kayitlar.cam4_password;

                GeneralDef.NETDEMO.NETDEMO_DEVICE_TYPE_E eDeviceType = GeneralDef.NETDEMO.NETDEMO_DEVICE_TYPE_E.NETDEMO_DEVICE_IPC_OR_NVR;
                //if ("VMS" == oDeviceTypeList[i])
                //{
                //    eDeviceType = GeneralDef.NETDEMO.NETDEMO_DEVICE_TYPE_E.NETDEMO_DEVICE_VMS;
                //}

                m_oNetDemo.AddLocalDevice(oDeviceIPList[i], oDevicePortList[i], strUserName, strPassword, eDeviceType);
            }
            netdemo.textboxveridoldur();
            this.Close();
        }

        private void DeviceInfoListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.DeviceInfoListView.SelectedItems == null || this.DeviceInfoListView.SelectedItems.Count <= 0)
            {
                return;
            }

            String strIPAddr = null;
            String strDeviceType = null;
            Int16 udwPort = 0;

            oDeviceIPList.Clear();
            oDevicePortList.Clear();
            oDeviceTypeList.Clear();

            var selectedItems = this.DeviceInfoListView.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                var item = (ListViewItem)selectedItem;
                strIPAddr = item.SubItems[1].Text;
                strDeviceType = item.SubItems[0].Text;
                try
                {
                    udwPort = Convert.ToInt16(item.SubItems[2].Text);
                    oDeviceIPList.Add(strIPAddr);
                    oDevicePortList.Add(udwPort);
                    oDeviceTypeList.Add(strDeviceType);
                }
                catch (FormatException)
                {
                    continue;
                }
                catch (OverflowException)
                {
                    continue;
                }
            }
        }

        private void discovery(String strStartIP, String strEndIP)
        {
            if (strStartIP == "" || strEndIP == "")
            {
                return;
            }

            oDeviceInfoList.Clear();
            DeviceInfoListView.Items.Clear();

            m_oNetDemo.discoveryCB = new NETDEVSDK.NETDEV_DISCOVERY_CALLBACK_PF(discoveryCallBack);
            Int32 iRet = NETDEVSDK.NETDEV_SetDiscoveryCallBack(m_oNetDemo.discoveryCB, IntPtr.Zero);
            if (NETDEVSDK.FALSE == iRet)
            {
                MessageBox.Show("set discovery callBack failed,the error is [" + NETDEVSDK.NETDEV_GetLastError().ToString() + "]");
                return;
            }

            iRet = NETDEVSDK.NETDEV_Discovery(strStartIP, strEndIP);
            if (NETDEVSDK.FALSE == iRet)
            {
                MessageBox.Show("discovery failed,the error is [" + NETDEVSDK.NETDEV_GetLastError().ToString() + "]");
                return;
            }
        }

        //discovery callback
        private void discoveryCallBack(IntPtr pstDevInfo, IntPtr lpUserData)
        {
            NETDEV_DISCOVERY_DEVINFO_S stDevInfo = (NETDEV_DISCOVERY_DEVINFO_S)Marshal.PtrToStructure(pstDevInfo, typeof(NETDEV_DISCOVERY_DEVINFO_S));
            for (int i = 0; i < oDeviceInfoList.Count(); i++)
            {
                if (stDevInfo.szDevAddr == oDeviceInfoList[i].szDevAddr && stDevInfo.szDevSerailNum == oDeviceInfoList[i].szDevSerailNum)
                {
                    return;
                }
            }

            oDeviceInfoList.Add(stDevInfo);
            setDeviceInfoListView(stDevInfo);
        }

        private delegate void SetDeviceInfoListView(NETDEV_DISCOVERY_DEVINFO_S stDevInfo);
        private void setDeviceInfoListView(NETDEV_DISCOVERY_DEVINFO_S stDevInfo)
        {
            if (DeviceInfoListView.InvokeRequired)
            {
                SetDeviceInfoListView setInfo = new SetDeviceInfoListView(setDeviceInfoListView);
                DeviceInfoListView.Invoke(setInfo, new object[] { stDevInfo });
            }
            else
            {
                string str = null;
                switch (stDevInfo.enDevType)
                {
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_UNKNOWN:
                        str = "IPC";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_IPC:
                        str = "IPC";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_IPC_FISHEYE:
                        str = "IPC_DISECONOMIC_FISHEYE";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_IPC_ECONOMIC_FISHEYE:
                        str = "IPC_ECONOMIC_FISHEYE";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_NVR:
                        str = "NVR";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_NVR_BACKUP:
                        str = "NVR_BACKUP";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_DC:
                        str = "DC";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_EC:
                        str = "EC";
                        break;
                    case NETDEV_DEVICETYPE_E.NETDEV_DTYPE_VMS:
                        str = "VMS";
                        break;
                    default:
                        str = "INVALID";
                        break;
                }



                ListViewItem oListViewItem = new ListViewItem(str);
                oListViewItem.SubItems.AddRange(new String[] { stDevInfo.szDevAddr, Convert.ToString(stDevInfo.dwDevPort), stDevInfo.szDevMac, stDevInfo.szDevSerailNum, stDevInfo.szManuFacturer });
                this.DeviceInfoListView.Items.Add(oListViewItem);
                deviceNumberLabel.Text = Convert.ToString(DeviceInfoListView.Items.Count);
                oListViewItem.EnsureVisible();
            }
        }

        private void Discovery_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            discovery("0.0.0.0", "0.0.0.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
