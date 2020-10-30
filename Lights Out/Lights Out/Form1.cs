using Lights_Out.Properties;
using MagicHome;
using System;
using System.Windows.Forms;

namespace Lights_Out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void LightsOut1()
        {
            if (Settings.Default.IP1 != "")
            {
                Light light = new Light(Settings.Default.IP1);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut2()
        {
            if (Settings.Default.IP2 != "")
            {
                Light light = new Light(Settings.Default.IP2);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut3()
        {
            if (Settings.Default.IP3 != "")
            {
                Light light = new Light(Settings.Default.IP3);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut4()
        {
            if (Settings.Default.IP4 != "")
            {
                Light light = new Light(Settings.Default.IP4);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut5()
        {
            if (Settings.Default.IP5 != "")
            {
                Light light = new Light(Settings.Default.IP5);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut6()
        {
            if (Settings.Default.IP6 != "")
            {
                Light light = new Light(Settings.Default.IP6);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut7()
        {
            if (Settings.Default.IP7 != "")
            {
                Light light = new Light(Settings.Default.IP7);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut8()
        {
            if (Settings.Default.IP8 != "")
            {
                Light light = new Light(Settings.Default.IP8);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut9()
        {
            if (Settings.Default.IP9 != "")
            {
                Light light = new Light(Settings.Default.IP9);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOut10()
        {
            if (Settings.Default.IP10 != "")
            {
                Light light = new Light(Settings.Default.IP10);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOffAsync();
                }
            }
        }

        public async void LightsOn1()
        {
            if (Settings.Default.IP1 != "")
            {
                Light light = new Light(Settings.Default.IP1);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn2()
        {
            if (Settings.Default.IP2 != "")
            {
                Light light = new Light(Settings.Default.IP2);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn3()
        {
            if (Settings.Default.IP3 != "")
            {
                Light light = new Light(Settings.Default.IP3);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn4()
        {
            if (Settings.Default.IP4 != "")
            {
                Light light = new Light(Settings.Default.IP4);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn5()
        {
            if (Settings.Default.IP5 != "")
            {
                Light light = new Light(Settings.Default.IP5);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn6()
        {
            if (Settings.Default.IP6 != "")
            {
                Light light = new Light(Settings.Default.IP6);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn7()
        {
            if (Settings.Default.IP7 != "")
            {
                Light light = new Light(Settings.Default.IP7);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn8()
        {
            if (Settings.Default.IP8 != "")
            {
                Light light = new Light(Settings.Default.IP8);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn9()
        {
            if (Settings.Default.IP9 != "")
            {
                Light light = new Light(Settings.Default.IP9);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        public async void LightsOn10()
        {
            if (Settings.Default.IP10 != "")
            {
                Light light = new Light(Settings.Default.IP10);
                await light.ConnectAsync();
                if (light.Connected)
                {
                    await light.TurnOnAsync();
                }
            }
        }

        private void xuiWifiPercentageAPI1_Tick(object sender, EventArgs e)
        {
            xuiWifiPercentageAPI1.Interval = 1000;
            xuiCircleProgressBar1.Percentage = xuiWifiPercentageAPI1.Value;
            ActiveForm.Text = "Lights Out - WiFi: " + xuiWifiPercentageAPI1.SSID;
        }

        private void xuiBatteryPercentageAPI1_Tick(object sender, EventArgs e)
        {
            xuiBatteryPercentageAPI1.Interval = 1000;
            xuiCircleProgressBar2.Percentage = xuiBatteryPercentageAPI1.Value;
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            LightsOut1();
            LightsOut2();
            LightsOut3();
            LightsOut4();
            LightsOut5();
            LightsOut6();
            LightsOut7();
            LightsOut8();
            LightsOut9();
            LightsOut10();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.loOnExecute)
            {
                LightsOut1();
                LightsOut2();
                LightsOut3();
                LightsOut4();
                LightsOut5();
                LightsOut6();
                LightsOut7();
                LightsOut8();
                LightsOut9();
                LightsOut10();
            }
        }

        private void xuiSuperButton9_Click(object sender, EventArgs e)
        {
            LightsOn1();
        }

        private void xuiSuperButton8_Click(object sender, EventArgs e)
        {
            LightsOn2();
        }

        private void xuiSuperButton7_Click(object sender, EventArgs e)
        {
            LightsOn3();
        }

        private void xuiSuperButton6_Click(object sender, EventArgs e)
        {
            LightsOn4();
        }

        private void xuiSuperButton5_Click(object sender, EventArgs e)
        {
            LightsOn5();
        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            LightsOn6();
        }

        private void xuiSuperButton10_Click(object sender, EventArgs e)
        {
            LightsOn7();
        }

        private void xuiSuperButton11_Click(object sender, EventArgs e)
        {
            LightsOn8();
        }

        private void xuiSuperButton12_Click(object sender, EventArgs e)
        {
            LightsOn9();
        }

        private void xuiSuperButton13_Click(object sender, EventArgs e)
        {
            LightsOn10();
        }

        private void xuiSuperButton22_Click(object sender, EventArgs e)
        {
            LightsOut6();
        }

        private void xuiSuperButton17_Click(object sender, EventArgs e)
        {
            LightsOut1();
        }

        private void xuiSuperButton18_Click(object sender, EventArgs e)
        {
            LightsOut2();
        }

        private void xuiSuperButton19_Click(object sender, EventArgs e)
        {
            LightsOut3();
        }

        private void xuiSuperButton20_Click(object sender, EventArgs e)
        {
            LightsOut4();
        }

        private void xuiSuperButton21_Click(object sender, EventArgs e)
        {
            LightsOut5();
        }

        private void xuiSuperButton15_Click(object sender, EventArgs e)
        {
            LightsOut9();
        }

        private void xuiSuperButton3_Click(object sender, EventArgs e)
        {
            LightsOut7();
        }

        private void xuiSuperButton14_Click(object sender, EventArgs e)
        {
            LightsOut8();
        }

        private void xuiSuperButton16_Click(object sender, EventArgs e)
        {
            LightsOut10();
        }
    }
}
