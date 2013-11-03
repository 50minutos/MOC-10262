using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _003_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar();
            Mostrar();
            Mostrar();
        }

        void Mostrar()
        {
            MessageBox.Show("Qualquer coisa");
        }

        void Mostrar(Object msg)
        {
            MessageBox.Show(msg.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Mostrar)).Start();
            new Thread(new ThreadStart(Mostrar)).Start();
            new Thread(new ThreadStart(Mostrar)).Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(Mostrar)).Start("um");
            new Thread(new ParameterizedThreadStart(Mostrar)).Start("dois");
            new Thread(new ParameterizedThreadStart(Mostrar)).Start("três");
        }
    }
}
