using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocket4Net;

namespace DatabaseServer
{
    public partial class Login: Form
    {
        public static WebSocket websocket;
        public Login()
        {
            InitializeComponent();
        }

       

        private  void LoginCheck()
        {
            User user = new User();
            user.password = txtPassword.Text.Trim().ToString();
            user.username = txtUserName.Text.Trim().ToString();
            var json = JsonConvert.SerializeObject(user);
            websocket.Send("L" + json);
        }

        private void OnMessage(object sender, MessageReceivedEventArgs e)
        {
            if (e.Message.ToString().Contains("Active?"))
                Invoke(new Action(() => pnlAuthonication.Visible = true));
            else if (e.Message.ToString().Contains("User Registation Sucessfull"))
            {
                MessageBox.Show("User Registation Sucessfull \n Please Login");
                Invoke(new Action(() => btnRegistration.Visible = false));
                Invoke(new Action(() => txtPassword.Text = ""));
                Invoke(new Action(() => txtUserName.Text = ""));
            }
            else if (e.Message.ToString().Contains("User Registation Unsucessfull"))
                MessageBox.Show("User Registation Sucessfull");

            else if (e.Message.Contains("User Auth failed "))
            {
                MessageBox.Show("Authintication Failed");



                Invoke(new Action(() => btnConnect.Text = "Connect Again"));
                Invoke(new Action(() => pnlAuthonication.Visible = false));
            }


            else
            {
                if ((e.Message.Length > 0))

                {
                    Helper.USERID = e.Message.ToString();
                    Helper.USERNAME =txtUserName.Text;
                }
                Invoke(new Action(() => Go()));

            }
            
            

        }

        private void Go()
        {
            new Client().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlAuthonication.Visible = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ServerInitialization();

        }

        void ServerInitialization()
        {
            try
            {
                Helper.HOST = txtHost.Text.Trim().ToString();
                websocket = new WebSocket(Helper.HOST);


                websocket.Open();

                websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(OnMessage);
                Thread.Sleep(500);
                websocket.Send("Active?");


                //btnConnect.Visible = false;


            }
            catch (Exception)
            {
                MessageBox.Show(" Connection Failed");
                return;
            }
        }

        private void OnError(object sender, MessageReceivedEventArgs e)
        {
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.password = txtPassword.Text.Trim().ToString();
            user.username = txtUserName.Text.Trim().ToString();
            var json = JsonConvert.SerializeObject(user);
            websocket.Send("R" + json);
        }
    }
}
