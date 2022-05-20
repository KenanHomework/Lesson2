using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            CenterToScreen();
            Icon = Resources.destination;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        public bool ChangeTask1 { get; set; } = false;
        private void btn_task1_Click(object sender, EventArgs e)
        {
            ChangeTask1 = true;
            this.Close();
        }

        public bool ChangeTask2 { get; set; }
        private void btn_task2_Click(object sender, EventArgs e)
        {
            ChangeTask2 = true;
            Close();
        }
    }
}
