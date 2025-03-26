using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookstoreManagementSystem
{
    public partial class Spalsh : Form
    {
        public Spalsh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spalsh_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);

            // Update status text based on progress
            if (progressBar1.Value < 30)
            {
                lblStatus.Text = "Loading resources...";
            }
            else if (progressBar1.Value < 70)
            {
                lblStatus.Text = "Connecting to database...";
            }
            else
            {
                lblStatus.Text = "Starting application...";
            }

            // When complete
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();

                Login login = new Login();
                login.Show();

           
            }
        }
    }
}
