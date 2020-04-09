using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RockPaperScissors;


namespace RockPaperScissors
{
    public partial class playerDataEntry : Form
    {
        public static string userName = "Your Name";
        public string userEmail = "you@domain.com";
      
        public playerDataEntry()
        {
            InitializeComponent();
        }
       
        public void submitPlayerDataBtn_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Form1")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            userName = playerNameText.Text;
            userEmail = playerEmailText.Text;            
            MessageBox.Show("user data was submitted");
            RockPaperScissors form1 = new RockPaperScissors();
            form1.Show();
            
        }
            
    }
}
