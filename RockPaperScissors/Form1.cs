﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        //declaring the variables for this game

        public int rounds = 3; // 5 rounds per game
        public int timePerRound = 5; // 5 seconds per rounds
        //player choice options stored inside of an array
        string[] computerChoice = { "rock", "paper", "scissor", "paper" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int playerWins = 0;
        int computerWins = 0;


        public RockPaperScissors()
        {
            InitializeComponent();
            timer1.Enabled = true;
            playerChoice = "none";
        }

       private void timer1_Tick(object sender, EventArgs e)
       {
            roundNumLabel.Text = Convert.ToString(rounds);
            timePerRound--; //reduce the timeby1
            timerCntLabel.Text = Convert.ToString(timePerRound); //show the time on the screen
            if (timePerRound < 1)//if the time is less then one second
            {
                timer1.Enabled = false; //timer will disbale if its less than one second left

                timePerRound = 5; // set the timer back to 5 seconds
                randomNumber = rnd.Next(0, 3); // randomize the number again
                command = computerChoice[randomNumber]; // computer choice will be the random number

                //a switch statment will show the computer choice and change the picture box accordingly

                switch (command)
                {
                    case "rock":
                        pictureBox2.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        pictureBox2.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        pictureBox2.Image = Properties.Resources.scissor;
                        break;

                    default:
                        break;
                }

                //if there are still more rounds to play, the chcek game function will run
                if(rounds > 1)
                {
                    checkGame();
                }
                //if no rounds remaining to play, go to final decision engine
                else
                {
                    decisionEngine();
                }  
            }
       }

        private  void checkGame()
        {
            if (playerChoice == "rock" && command == "paper")
            {
                MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "rock")
            {
                MessageBox.Show("player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "scissor")
            {
                MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();

            }
            else if (playerChoice == "scissor" && command == "paper")
            {
                MessageBox.Show("Player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "scissor" && command == "rock")
            {
                MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "rock" && command == "scissor")
            {
                MessageBox.Show("Player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "rock" && command == "paper")
            {
                MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show(player1NameLabel.Text + "Make a choice");
                nextRound();
            }
            else
            {
                MessageBox.Show("Draw");
                nextRound();
            }

        }

        private void decisionEngine()
        {
            if(playerWins > computerWins)
            {
                winnerLabel.Text = player1NameLabel.Text + "Wins the game";
                
            }
            else
            {
                winnerLabel.Text = " Computer wins the game";
            }
        }

        private void nextRound()
        {
            playerChoice = "none";
            pictureBox1.Image = Properties.Resources.question;
            timer1.Enabled = true;
            pictureBox2.Image = Properties.Resources.question;
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            pictureBox1.Image = Properties.Resources.rock;
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            pictureBox1.Image = Properties.Resources.paper;
        }

        private void scissorBtn_Click(object sender, EventArgs e)
        {
            playerChoice = "scissor";
            pictureBox1.Image = Properties.Resources.scissor;
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpScreenLabel help = new helpScreenLabel();
            help.Show();
        }

        //Display Player Data Entry Form
        private void enterPlayerDataLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            new playerDataEntry().Show();
            //this.Hide();
            enterPlayerDataLinkLabel.LinkVisited = true;
        }
    }

   
}
