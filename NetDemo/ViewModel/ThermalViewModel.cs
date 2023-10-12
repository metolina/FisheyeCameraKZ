using System;
using IVSDemo.Base;
using System.Windows.Input;
using NetSDKCS;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Security.Cryptography.X509Certificates;

namespace ThermalCamera.ViewModel
{
    class ThermalViewModel : BindableObject
    {
        static public IntPtr lLoginID = IntPtr.Zero;
        static public IntPtr playHandle1 = IntPtr.Zero;
        static public IntPtr playHandle2 = IntPtr.Zero;
        static public IntPtr hWnd = IntPtr.Zero;
        static public int currentChannel = 0;
        static public NET_DEVICEINFO_Ex DeviceInfo;
        public IntPtr testthermal;
        public IntPtr testthermal2;
        static public ObservableCollection<int> Channels { get; set; }

        static public string wndTitle = "Termal Kamera";

        public string WndTitle
        {
            get { return wndTitle; }
            set
            {
                if (wndTitle != value)
                {
                    wndTitle = value;
                    OnPropertyChanged("WndTitle");
                }

            }
        }

        //  login
        #region
        private string ip = "192.168.1.108";

        public string IP
        {
            get { return ip; }
            set
            {
                if (ip != value)
                {
                    ip = value;
                    OnPropertyChanged("IP");
                }
            }
        }

        private ushort port = 80;

        public ushort Port
        {
            get { return port; }
            set
            {
                if (port != value)
                {
                    port = value;
                    OnPropertyChanged("Port");
                }
            }
        }

        private string user = "admin";

        public string User
        {
            get { return user; }
            set
            {
                if (user != value)
                {
                    user = value;
                    OnPropertyChanged("User");
                }
            }
        }

        private string pwd = "kz-102030";

        public string Pwd
        {
            get { return pwd; }
            set
            {
                if (pwd != value)
                {
                    pwd = value;
                    OnPropertyChanged("Pwd");
                }
            }
        }

        private string loginState = "Login";

        public string LoginState
        {
            get { return loginState; }
            set
            {
                if (loginState != value)
                {
                    loginState = value;
                    OnPropertyChanged("LoginState");
                }
            }
        }

        private string playBtnText = "Bağlan";

        public string PlayBtnText
        {
            get { return playBtnText; }
            set
            {
                if (playBtnText != value)
                {
                    playBtnText = value;
                    OnPropertyChanged("PlayBtnText");
                }
            }
        }

        private int playChannel;

        public int PlayChannel
        {
            get { return playChannel; }
            set
            {
                if (playChannel != value)
                {
                    playChannel = value;
                    OnPropertyChanged("PlayChannel");
                }
            }
        }
        #endregion

        // button enable
        #region
        private bool temperPointEn = false;

        public bool TemperPointEn
        {
            get { return temperPointEn; }
            set
            {
                if (temperPointEn != value)
                {
                    temperPointEn = value;
                    OnPropertyChanged("TemperPointEn");
                }
            }
        }

        private bool temperItemEn = false;

        public bool TemperItemEn
        {
            get { return temperItemEn; }
            set
            {
                if (temperItemEn != value)
                {
                    temperItemEn = value;
                    OnPropertyChanged("TemperItemEn");
                }
            }
        }

        private bool temperQueryEn = false;

        public bool TemperQueryEn
        {
            get { return temperQueryEn; }
            set
            {
                if (temperQueryEn != value)
                {
                    temperQueryEn = value;
                    OnPropertyChanged("TemperQueryEn");
                }
            }
        }

        private bool subscribeEn = false;

        public bool SubscribeEn
        {
            get { return subscribeEn; }
            set
            {
                if (subscribeEn != value)
                {
                    subscribeEn = value;
                    OnPropertyChanged("SubscribeEn");
                }
            }
        }

        private bool playEn = false;

        public bool PlayEn
        {
            get { return playEn; }
            set
            {
                if (playEn != value)
                {
                    playEn = value;
                    OnPropertyChanged("PlayEn");
                }
            }
        }

        private bool cmbEn;

        public bool CmbEn
        {
            get { return cmbEn; }
            set
            {
                if (cmbEn != value)
                {
                    cmbEn = value;
                    OnPropertyChanged("CmbEn");
                }
            }
        }

        private bool wndEnable;

        public bool WndEnable
        {
            get { return wndEnable; }
            set
            {
                wndEnable = value;
                OnPropertyChanged("WndEnable");
            }
        }



        #endregion

        public ICommand LoginCmd { get; set; }
        public ICommand PlayCmd { get; set; }
        public ICommand TemperPointCmd { get; set; }
        public ICommand TemperItemCmd { get; set; }
        public ICommand TemperQueryCmd { get; set; }
        public ICommand SubscriptionCmd { get; set; }

        private fDisConnectCallBack disConnectCallback;
        private fHaveReConnectCallBack haveReConnectCallBack;

        public ThermalViewModel()
        {
            DeviceInfo = new NET_DEVICEINFO_Ex();
            Channels = new ObservableCollection<int>();

            LoginCmd = new DelegateCommand(Login);
            PlayCmd = new DelegateCommand(RealPlay);


            disConnectCallback = new fDisConnectCallBack(DisConnectCallBack);
            haveReConnectCallBack = new fHaveReConnectCallBack(HaveReConnectCallBack);
            try
            {
                NETClient.Init(disConnectCallback, IntPtr.Zero, null);
                NETClient.SetAutoReconnect(haveReConnectCallBack, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
        }

        ~ThermalViewModel()
        {
            //if (playHandle1 != IntPtr.Zero)
            //{
            //    NETClient.StopRealPlay(playHandle1);
            //    playHandle1 = IntPtr.Zero;
            //}

            //if (lLoginID != IntPtr.Zero)
            //{
            //    NETClient.Logout(lLoginID);
            //}
            //NETClient.Cleanup();
        }

        private void DisConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                //UpdateUI(false);
            }));
        }

        private void HaveReConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                //UpdateUI(true);
            }));
        }

        private void UpdateUI(bool isOnline)
        {
            if (isOnline)
            {
                //WndTitle = "Termal";
                //LoginState = "Çıkış Yap";
                TemperPointEn = true;
                TemperItemEn = true;
                TemperQueryEn = true;
                SubscribeEn = true;
                PlayEn = true;
                CmbEn = true;
            }
            else
            {
                //LoginState = "Bağlan";
                //WndTitle = "Termal Kamera";
                TemperPointEn = false;
                TemperItemEn = false;
                TemperQueryEn = false;
                SubscribeEn = false;
                PlayEn = false;
                CmbEn = false;
            }
        }

        //private void SubscriptionDlg()
        //{
        //    HeatMapWnd heapmapWnd = new HeatMapWnd();
        //    heapmapWnd.Owner = App.Current.MainWindow;
        //    heapmapWnd.ShowDialog();
        //}

        //private void TemperQueryDlg()
        //{
        //    TemperQueryWnd queryWnd = new TemperQueryWnd();
        //    queryWnd.Owner = App.Current.MainWindow;
        //    queryWnd.ShowDialog();
        //}

        //private void TemperItemDlg()
        //{
        //    TemperItemWnd itemWnd = new TemperItemWnd();
        //    itemWnd.Owner = App.Current.MainWindow;
        //    itemWnd.ShowDialog();
        //}

        //private void TemperPointDlg()
        //{
        //    TemperPointWnd pointWnd = new TemperPointWnd();
        //    pointWnd.Owner = App.Current.MainWindow;
        //    pointWnd.ShowDialog();
        //}


        public void RealPlay(IntPtr obj, int screennumber)
        {
            hWnd = (IntPtr)obj;

            playHandle1 = NETClient.RealPlay(lLoginID, screennumber, hWnd);
            if (playHandle1 != IntPtr.Zero)
            {
                //currentChannel = PlayChannel;
                currentChannel = screennumber;
                //PlayBtnText = "Durdur";
            }
            //else
            //{
            //    MessageBox.Show("Bağlantı Hatası!");
            //    testthermal = IntPtr.Zero;

            //    return;
            //}


            //playHandle2 = NETClient.RealPlay(lLoginID, 0, hWnd);
            //if (playHandle2 != IntPtr.Zero)
            //{
            //    //currentChannel = PlayChannel;
            //    currentChannel = 0;
            //    //PlayBtnText = "Durdur";
            //}
            //else
            //{
            //    MessageBox.Show("Bağlantı Hatası!");
            //    testthermal = IntPtr.Zero;
            //    return;
            //}

            //lse
            //{
            //    //NETClient.StopRealPlay(playHandle);
            //    //playHandle = IntPtr.Zero;
            //    //PlayBtnText = "Başlat";
            //    //WndEnable = false;
            //}
            testthermal = playHandle1;
            testthermal2 = playHandle2;
            return;
        }



        public IntPtr verihandle()
        {
            return testthermal;
        }
        //public IntPtr verihandle2()
        //{
        //    return testthermal2;
        //}
        public string ipadress = "";
        public ushort pport;
        public string username;
        public string password;
        public void LoginInformation(string ipaadress, ushort port, string uusername, string passsword)
        {
            ipadress = ipaadress;
            pport = port;
            username = uusername;
            password = passsword;
        }



        public IntPtr LoginIDForThermal = IntPtr.Zero;
        public IntPtr LoginIDForRGB = IntPtr.Zero;
        public void LoginForThermal()
        {
            if (lLoginID == IntPtr.Zero)
            {
                LoginIDForThermal = NETClient.LoginWithHighLevelSecurity(ipadress, pport, username, Pwd, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref DeviceInfo);
                if (LoginIDForThermal != IntPtr.Zero)
                {
                    Channels.Clear();
                    for (int i = 0; i < DeviceInfo.nChanNum; i++)
                    {
                        Channels.Add(i);
                    }
                    //UpdateUI(true);
                }
                else
                {
                    MessageBox.Show("Bağlantı Hatası!");
                }
            }
        }
        public void LoginForRgb()
        {
            if (lLoginID == IntPtr.Zero)
            {
                LoginIDForRGB = NETClient.LoginWithHighLevelSecurity(ipadress, pport, username, Pwd, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref DeviceInfo);
                if (LoginIDForRGB != IntPtr.Zero)
                {
                    Channels.Clear();
                    for (int i = 0; i < DeviceInfo.nChanNum; i++)
                    {
                        Channels.Add(i);
                    }
                    //UpdateUI(true);
                }
                else
                {
                    MessageBox.Show("Bağlantı Hatası!");
                }
            }
        }
        public void thermalandrgb()
        {
            LoginForThermal();
            LoginForRgb();

        }
        public void Login()
        {
            if (lLoginID == IntPtr.Zero)
            {
                lLoginID = NETClient.LoginWithHighLevelSecurity(ipadress, pport, username, Pwd, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref DeviceInfo);
                if (lLoginID != IntPtr.Zero)
                {
                    Channels.Clear();
                    for (int i = 0; i < DeviceInfo.nChanNum; i++)
                    {
                        Channels.Add(i);
                    }
                    //UpdateUI(true);
                }
                else
                {
                    MessageBox.Show("Bağlantı Hatası!");
                }
            }
            //else
            //{
            //    if (playHandle != IntPtr.Zero)
            //    {
            //        NETClient.StopRealPlay(playHandle);
            //        playHandle = IntPtr.Zero;
            //        //PlayBtnText = "Bağlan";
            //        //WndEnable = false;
            //    }

            //    NETClient.Logout(lLoginID);
            //    lLoginID = IntPtr.Zero;
            //    UpdateUI(false);
            //}



        }

    }
}
