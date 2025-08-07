using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private readonly VisibilityManager visibilityManager = new VisibilityManager(false);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visibilityManager.visibilityToggle();
            labelmsg.Visible = visibilityManager.currentVisibility();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimeLable.Text = "time:";

            string jsonOutput = "";

            DateTime currentTime = DateTime.Now;

            string formattedTime = currentTime.ToString("HH:mm:ss");

            jsonOutput = JsonConvert.SerializeObject(formattedTime);

            TimeLable.Text = "time:" + jsonOutput;
        }
    }
}
