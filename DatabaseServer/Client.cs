using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WebSocket4Net;

namespace DatabaseServer
{
    public partial class Client : Form
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        WebSocket websocket;
        public Client()
        {
            InitializeComponent();

            SocketInit();

            //websocket.Send("GetAll");
            lblUsername.Text = Helper.USERNAME;
        }

        private void SocketInit()
        {
            try
            {
                websocket = new WebSocket(Helper.HOST);

                websocket.Open();

                websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(OnMessage);

            }
            catch (Exception)
            {
                MessageBox.Show(" Connection Exception");
                return;
            }

        }

        private void OnMessage(object sender, MessageReceivedEventArgs e)
        {
            string str = e.Message;
            if (str[0] == 'A')
            {

                str = str.Remove(0, 1);
                List<Student> rtObj = serializer.Deserialize<List<Student>>(str);
                for (int i = 0; i < rtObj.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                    row.Cells[0].Value = rtObj[i].id;
                    row.Cells[1].Value = rtObj[i].name;
                    row.Cells[2].Value = rtObj[i].semester;
                    row.Cells[3].Value = rtObj[i].department;
                    Invoke(new Action(() => dataGridView.Rows.Add(row)));
                }
            }

            else if (str[0] == 'S')
            {
                str = str.Remove(0, 1);
                List<Student> seletedObj = serializer.Deserialize<List<Student>>(str);
                Invoke(new Action(() => txtUDepart.Text = seletedObj[0].department));
                Invoke(new Action(() => txtUId.Text = seletedObj[0].id));
                Invoke(new Action(() => txtUSemis.Text = seletedObj[0].semester));
                Invoke(new Action(() => txtUName.Text = seletedObj[0].name));
            }
            else if(str.Contains("User Updated"))
            {
                MessageBox.Show(str);
            }
            else if (str.Contains("User Not Updated"))
            {
                MessageBox.Show(str);
            }

            else if (str.Contains("replay"))
            {
                if (str.Contains("Delete"))
                {
                    if (str.Contains("true"))
                        MessageBox.Show("Delete Sucessfull");
                    else MessageBox.Show("Delete UnSucessfull !");
                }
                if (str.Contains("Create"))
                {
                    if (str.Contains("true"))
                        MessageBox.Show("Create Sucessfull");
                    else MessageBox.Show("Create UnSucessfull !");
                }

                if (str.Contains("Update"))
                {
                    if (str.Contains("true"))
                        MessageBox.Show("Update Sucessfull");
                    else MessageBox.Show("Update UnSucessfull !");
                }
                if (str.Contains("Select"))
                {
                    if (str.Contains("false"))
                        MessageBox.Show("No Data");
                }



            }

        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            Student std = new Student();

            std.userid = Helper.USERID;
            var json = JsonConvert.SerializeObject(std);
            websocket.Send("G"+json);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.id = txtCid.Text;
            std.name = txtCname.Text;
            std.department = txtCdept.Text;
            std.semester = txtCsem.Text;
            std.userid = Helper.USERID;

            InsertNewStudent(std);
        }

        private void InsertNewStudent(Student std)
        {
            var json = JsonConvert.SerializeObject(std);
            websocket.Send("I" + json);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            websocket.Send("S" + txtUId.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.id = txtUId.Text;
            std.name = txtUName.Text;
            std.department = txtUDepart.Text;
            std.semester = txtUSemis.Text;
            std.userid = Helper.USERID;
            var json = JsonConvert.SerializeObject(std);
            websocket.Send("U" + json);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.id = txtDId.Text;
            
            std.userid = Helper.USERID;
            var json = JsonConvert.SerializeObject(std);
            websocket.Send("D" + json);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = Helper.USERID;
            user.username = Helper.USERNAME;
            user.password = txtUMPassword.Text.ToString().Trim();
            var json = JsonConvert.SerializeObject(user);
            websocket.Send("P" + json);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
