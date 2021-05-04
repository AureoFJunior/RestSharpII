using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestSharpII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestSs demo = new RestSs();
            var modelo = demo.GetUser();

            txt.Text += $"====\n{modelo.id}\n{modelo.userId}\n{modelo.title}\n{modelo.completed}\n====\n";
        }
    }
}
