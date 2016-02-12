using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        string _surname;

        public string Surname
        {
            get
            {
                //MessageBox.Show(_surname);
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            string mail = "gor.rustamyan@gmail.com";

            MessageBox.Show("My mail is " + mail);

        }

        void TestFunction()
        {
        }

        void button1_Click(object sender, EventArgs e)
        {
            //TestFunction();


            //this.Surname = this.UserInputTextBox.Text;

            //this.OutPutTextBox.Text = this.Surname;

            var t=this.Surname;
            

            //TcpClient client = new TcpClient();
            //client.

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
