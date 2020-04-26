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
      
        public playerDataEntry(string playerName)
        {
            InitializeComponent();
        }
       
        public void submitPlayerDataBtn_Click(object sender, EventArgs e)
        {
            userName = playerNameText.Text;
            userEmail = playerEmailText.Text;
            MessageBox.Show("user data was submitted");
            Form1.Show(playerNameText);
            //save player data
        }

        private void playerDataEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
