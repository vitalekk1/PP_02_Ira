using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_02_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<string> names = new List<string>();
        static List<string> phone = new List<string>();
        private delegate void SafeCallDelegate(Label LB, string text);
        Thread L, B;
        private void button1_Click(object sender, EventArgs e)
        {
            L = new Thread(Linear);
            B = new Thread(Binary);

            L.Start(TB_FIO.Text);
            B.Start(TB_FIO.Text);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:/famtel.txt");
            string[] lines = new string[2];
            for (int i = 0; !sr.EndOfStream; i++)
            {
                lines = sr.ReadLine().Split('\t');
                names.Add(lines[0]);
                phone.Add(lines[1]);
            }
        }



        public void Linear(object T)
        {
            string name = ((string)T).ToUpper();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < names.Count; i++)
            {
                if (name == names[i])
                {
                    WriteTextSafe(LB_Linear ,names[i] + " " + phone[i] + "    Время поиска: " + stopWatch.ElapsedTicks);
                }
            }
        }
        private void WriteTextSafe(Label TB, string text)
        {
            if (TB.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                TB.Invoke(d, new object[] { TB, text });
            }
            else
            {
                TB.Text = text;
            }
        }

        public void Binary(object T)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int i = names.BinarySearch(((string)T).ToUpper());
            WriteTextSafe(LB_Binary, names[i] + " " + phone[i] + "    Время поиска: " + stopWatch.ElapsedTicks);

        }

        private void continueL_Click(object sender, EventArgs e)
        {
            L.Resume();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            L.Suspend();
            MessageBox.Show("ПОТОК ПРИОСТАНОВЛЕН");
        }
    }
}
