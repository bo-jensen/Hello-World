using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseReader2
{
    public partial class Form1 : Form
    {
        private Point m_Example;
        private DateTime m_LastUpdate;
        private Random m_Ran;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(OnMouseDownX);
            // Milliseconds between updates
            this.timer1.Interval = 3000;
            m_Ran = new Random();
            m_LastUpdate = DateTime.Now;
        }

        private void AppLoop()
        {
            GetCursorPos(out m_Example);
            this.Text = m_Example.ToString();

            m_LastUpdate = DateTime.Now;

            SetCursorRan();
        }

        private void SetCursorRan()
        {
            SetCursorPos(m_Ran.Next(0, 1366), m_Ran.Next(0, 768));
        }

        private void OnMouseDownX(object sender, MouseEventArgs e)
        {
            SetCursorRan();
        }

        [DllImport("User32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("User32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        private void timer1_Tick(object sender, EventArgs e)
        {
            AppLoop();
        }
    }
}
