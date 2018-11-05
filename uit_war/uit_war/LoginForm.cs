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

namespace uit_war
{

    public partial class LoginForm : Form
    {
        public static bool isServer = false;
        
        public LoginForm()
        {
            InitializeComponent();
            //no care
            Control.CheckForIllegalCrossThreadCalls = false;

            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            #region mycode
            //Const.client.CreateClient();
            ////server
            //if (!Const.client.isConnectedToServer())
            //{
            //    isServer = true;
            //    Const.server.CreateServer(Const.IP, Const.PORT);

            //    Const.server.WaitingConnection();
            //    Form1 f1 = new Form1();
            //    f1.Text = "server";
            //    f1.Show();
            //    this.Hide();
            //    //Thread task1 = new Thread(() =>
            //    //{
            //    //    while (true)
            //    //    {
            //    //        server.Show();
            //    //    }
            //    //});
            //    //task1.Start();

            //    //while (true)
            //    //{
            //    //    server.Send();
            //    //}
            //}
            ////client
            //else
            //{
            //    isServer = false;
            //    Const.client.ConnectServer(Const.IP, Const.PORT);
            //    Form1 f1 = new Form1();
            //    f1.Text = "client";
            //    f1.Show();
            //    this.Hide();
            //    //Thread task2 = new Thread(() =>
            //    //{
            //    //    while (true)
            //    //    {
            //    //        client.Show();
            //    //    }
            //    //});
            //    //task2.Start();
            //    //while (true)
            //    //{
            //    //    client.Send(20, 20);
            //    //}
            //}

            ////////////////
            #endregion

            //if server is not exist
            //create server
            //waiting for connect from client
            if (!Program.socket.ConnectServer())
            {
                Program.socket.isServer = true;
                Program.socket.CreateServer();
                ///
                Program.login.Close();
                Program.main.Text = "server";
            }
            //client
            else
            {
                Program.socket.isServer = false;
                ///
                Program.login.Close();
                Program.main.Text = "client";
            }
            
        }

        
    }
}
