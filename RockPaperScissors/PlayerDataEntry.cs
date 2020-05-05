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
        public Player _playerOne = new Player();
        List<Player> PlayerList = new List<Player>();

        public playerDataEntry()
        {
            InitializeComponent();
            playerNameText.DataBindings.Add("Text", _playerOne, "UserName", true, DataSourceUpdateMode.OnValidation);   
        }
       
        public void submitPlayerDataBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user data was submitted");
            _playerOne.UserName = playerNameText.Text;
            _playerOne.UserEmail = playerEmailText.Text;

            // TO DO save player data to //collection data binding
            PlayerList.Add(this._playerOne);
        }

        private void playerDataEntry_Load(object sender, EventArgs e)
        {
            
        }
    }
}
