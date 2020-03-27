using System.Reflection;
using System;
using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch03_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Skin lib + Reflection
            {
                /*
                var factoryType = ConfigurationManager.AppSettings["factory"];
                var factory = (Themes.ISkinFactory)Assembly.Load("ch03_AbstractFactory").CreateInstance(factoryType);
                var btn = factory.CreateButton();
                var txtBox = factory.CreateTextbox();
                btn.Show();
                txtBox.Show();
                */
            }
            // Exercise 1. IComputer(PC, Mac), ICpu(IntelCpu, AmdCpu), IDisk(WDDisk, SeagateDisk)

            // Exercise 2. machien factory
            {
                /*
                var haierFactory = new Machien.HaierFactory();
                var haierTV = haierFactory.CreateTV();
                var haierFridge = haierFactory.CreateFridge();
                haierTV.Play();
                haierFridge.Freeze();

                var hisenseFactory = new Machien.HisenseFactory();
                var hisenseTV = hisenseFactory.CreateTV();
                var hisenseFridge = hisenseFactory.CreateFridge();
                hisenseTV.Play();
                hisenseFridge.Freeze();
                */
            }

            // Exercise 3. IData(Oracle, MySql), IConnect(OracleConn, MySqlConn), ICommand(OracleCmd, MySqlCmd)
            //             App.Config: connectionString

            // Exercise 4. IOperationSystem(Windows, Linux, UNIX), IButton(WinBtn, LinuxBtn, UnixBtn), ITextbox(WinTb, LinuxTb, UnixTb)

            // Exercise 5. IPlatform(iOS, Android, WindowsPhone), IOperation(iOSCtrl, AndroidCtrl, WinPhoneCtrl), IUserInterface(iOSUI, AndroidUI, WinPhoneUI)
            {
                var iPhone = new MobileGame.iOSMobile();
                var iOperation = iPhone.OperationControl();
                var iUI = iPhone.UIControl();
                iOperation.Operation();
                iUI.UI();

                var huawei = new MobileGame.AndroidMobile();
                var hOperation = huawei.OperationControl();
                var hUI= huawei.UIControl();
                hOperation.Operation();
                hUI.UI();

                // Add Windows Phone: WinMobile(Nokia), WinOperation, WinUI
            }


            Console.Read();
        }
    }
}
