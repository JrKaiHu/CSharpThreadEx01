using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace CSharpThreadEx01
{    
    public partial class MianForm : Form
    {
        ConnectForm m_ConnectForm = new ConnectForm();

        public MianForm()
        {
            InitializeComponent();
        }

        private void MianForm_Load(object sender, EventArgs e)
        {
        }

        private void OnConnectMenuClick(object sender, EventArgs e)
        {
            Thread testThread = new Thread(Run);
            testThread.Start();
            m_ConnectForm.Show();
        }

        public void Run()
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                System.Console.WriteLine(i);
            }

            m_ConnectForm.BeginInvoke(new MethodInvoker(m_ConnectForm.Close));
        }
    }
}
