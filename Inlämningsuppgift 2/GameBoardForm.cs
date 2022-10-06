using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift_2.Classes;

namespace Inlämningsuppgift_2
{
    public partial class GameBoardForm : Form
    {
        Game game = new Game();
        
        
       
        public GameBoardForm()
        {
            InitializeComponent();
            
            
            
        }
        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            game.PlayerChoice("block");
            Update();


        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            game.PlayerChoice("load");
            Update();

        }

        private void ShootButton_Click(object sender, EventArgs e)
        {
            if (game.PlayerBullets() >= 1)
            {
                game.PlayerChoice("shoot");
                Update();
            }
            else
            {
                MessageBox.Show("Du har inte tillräckligt med skott");
            }
        }

        private void ShotgunButton_Click(object sender, EventArgs e)
        {
            if (game.PlayerBullets() >= 3)
            {
                game.PlayerChoice("shotgun");
                Update();
            }
            else
            {
                MessageBox.Show("Du har inte tillräckligt med skott");
            }
        }

        
        private void Update()
        {
            if (game.PlayerWon() == true)
            {
                GameBoxList.Items.Add("Grattis du vann den här rundan");
            }
            else if (game.ComputerWon() == true)
            {
                GameBoxList.Items.Add("Tyvärr förlorade du den här rundan");
            }
            CPUChoiceLabel.Text = $"CPU val :  {game.ComputerChoice()}";
            PlayerShotLabel.Text = $"Spelare antal skott : {game.PlayerBullets()}";
            CPUShotLabel.Text = $"CPU antal skott : {game.CPUBullets()}";
        }
    }
}
