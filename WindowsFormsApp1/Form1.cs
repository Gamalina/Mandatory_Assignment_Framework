using MandatoryAssignmentFramework.Library;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.Windows.Forms;
using MandatoryAssignmentFramework.Library.Interface;
using System.Xml.Linq;
using MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon;
using Microsoft.Extensions.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Creature player;
        Creature enemy;
        Creature player1 = new Creature("Player 1", "",500, 10, 5, false, 60, false, 182, 422);
        Creature enemy1 = new Creature("Enemy 1", "", 90, 10, 0, false, 60, false, 182, 2);
        
        PoisonedWeapon pw = new PoisonedWeapon(attackitem, 2, 10);
        //AttackItem attackItem = new AttackItem("Poison Dagger", "A dagger with poisonous effect, which deals damage over time.", 20, 50, 242, 122, true);
        //AttackItem attackItem2 = new AttackItem("Regular Boring Sword", "A sword that does nothing but cut the enemy", 20, 5, 182, 308, false);
        private readonly IConfiguration configuration;
        private readonly ILogger<World> _logger;
        private readonly TextBox _logTextBox;
        PickUpObserver pickUpObserver = new PickUpObserver();

        int n;
        PictureBox[,] P;
        private static AttackItem attackitem;
        

        public Form1(ILogger<World> logger)
        {

            attackitem = new AttackItem("Poison Dagger", "A dagger with poisonous effect, which deals damage over time.", 20, 9, 242, 122, true);
            _logger = logger;
            player = player1;
            enemy = enemy1;
            

            InitializeComponent();

            PlayerPictureBox.Image = Properties.Resources.Avatar60x60;
            PlayerPictureBox.Size = new Size(60, 60);
            PlayerPictureBox.Location = new Point(player.X, player.Y);

            EnemyPictureBox.Image = Properties.Resources.Avatar60x60;
            EnemyPictureBox.Size = new Size(60, 60);
            EnemyPictureBox.Location = new Point(enemy.X, enemy.Y);

            pictureBoxItem1.Tag = pw;
            pictureBoxItem1.Image = Properties.Resources.PoisonDagger;
            pictureBoxItem1.Size = new Size(60, 60);
            pictureBoxItem1.Location = new Point(242, 122);
            ProgBarEnemy.Value = enemy.HitPoints;
            ProgBarPlayer.Value = player.HitPoints;

            _logTextBox = LogTextBox;
            if (_logTextBox != null)
            {
                Controls.Add(_logTextBox);
                _logTextBox.ReadOnly = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //World world = new World(configuration, _logger);
            player = player1;
            
            enemy = enemy1;
            n = 8;
            P = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] {Color.White, Color.Black};
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }

                for(int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1: 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    //P[i, j].Size = new Size(world.MaxX, world.MaxY);
                    left += 60;
                    MapGrid.Controls.Add(P[i, j]);
                }
                top += 60;
            }

        }

        private void Attack_Click(object sender, EventArgs e)
        {
            // Calculate the distance between the player and enemy
            double distance = Math.Sqrt(Math.Pow(enemy.X - player.X, 2) + Math.Pow(enemy.Y - player.Y, 2));
            if (distance <= player.AttackRange)
            {
                if (ProgBarEnemy.Value <= 0)
                {

                    enemy.IsDead = true;
                    Attack.Enabled = false;
                    _logger.LogInformation(string.Format((player.Name) + " defeated " + (enemy.Name)));
                    _logTextBox.AppendText(string.Format((player.Name) + " defeated " + (enemy.Name)) + Environment.NewLine);
                    MessageBox.Show("You've defeated the enemy, and won the game.");
                    Close();
                }
                else if (enemy.HitPoints > 0)
                {
                    
                    player.Hit(enemy, player);
                    var enemyhit = enemy.HitPoints;
                    ProgBarEnemy.Value = enemy.HitPoints;

                    
                    TimerEnemyAttack.Enabled = true;
                    // Needs to have all buttons disabled after attacking.
                    Attack.Enabled = false;
                    ButtonDown.Enabled = false;
                    ButtonLeft.Enabled = false;
                    ButtonRight.Enabled = false;
                    ButtonUp.Enabled = false;
                    ButtonPickUp.Enabled = false;
                    
                    if(player.weaponEquiped)
                    {
                        string messagePW = string.Format((player.Name) + " attacks " + (enemy.Name) + " for " + (player.currentWeaponDamage + pw.Damage - enemy.DefensePoints) + " damage");
                        _logger.LogInformation(messagePW);
                        _logTextBox.AppendText(messagePW + Environment.NewLine);
                    }
                    else
                    {
                        string message = string.Format((player.Name) + " attacks " + (enemy.Name) + " for " + (player.currentWeaponDamage - enemy.DefensePoints) + " damage");
                        _logger.LogInformation(message);
                        _logTextBox.AppendText(message + Environment.NewLine);
                    }
                }
            }
            else
            {
                string message = string.Format("Player is not in range to hit the enemy!");
                _logger.LogInformation(message);
                _logTextBox.AppendText(message + Environment.NewLine);
            }
        }

       


        private void TimerEnemyAttack_Tick(object sender, EventArgs e)
        {
            TimerEnemyAttack.Enabled = false;
            player.ReceiveHit(enemy1.AttackPoints);
            if (player.HitPoints > 0)
            {
                ProgBarPlayer.Value = player.HitPoints;
            }
            else
            {
                ProgBarPlayer.Value = 0;
            }

            string message = string.Format(" " + (enemy.Name) + " attacks " + (player.Name) + " for " + (enemy.AttackPoints - player.DefensePoints) + " damage.");
            _logger.LogInformation(message);
            _logTextBox.AppendText(message + Environment.NewLine);

            Attack.Enabled = true;
            ButtonDown.Enabled = true;
            ButtonLeft.Enabled = true;
            ButtonRight.Enabled = true;
            ButtonUp.Enabled = true;
            ButtonPickUp.Enabled = true;

        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void ButtonUp_Click(object sender, EventArgs e)
        {
            player.Move(0, -60);
            PlayerPictureBox.Location = new Point(player.X, player.Y);

            string message = string.Format($"The player moved up. The player position is now: ({player.X}, {player.Y})");
            _logger.LogInformation(message);
            _logTextBox.AppendText(message + Environment.NewLine);
            

        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            player.Move(0, 60);
            PlayerPictureBox.Location = new Point(player.X, player.Y);

            string message = string.Format($"The player moved down. The player position is now: ({player.X}, {player.Y})");
            _logger.LogInformation(message);
            _logTextBox.AppendText(message + Environment.NewLine);


        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            player.Move(60, 0);
            PlayerPictureBox.Location = new Point(player.X, player.Y);

            string message = string.Format($"The player moved right. The player position is now: ({player.X}, {player.Y})");
            _logger.LogInformation(message);
            _logTextBox.AppendText(message + Environment.NewLine);

        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            player.Move(-60, 0);
            PlayerPictureBox.Location = new Point(player.X, player.Y);

            string message = string.Format($"The player moved left. The player position is now: ({player.X}, {player.Y})");
            _logger.LogInformation(message);
            _logTextBox.AppendText(message + Environment.NewLine);
        }

        private void ButtonPick_Click(object sender, EventArgs e)
        {
            // Check if the player is in range of the itemObject
            if (IsInRange(player, pw, 10))
            {
                var selectedObject = pictureBoxItem1.Tag as PoisonedWeapon;

                // Add the object to the player's inventory
                player.Pick(selectedObject);
                
                player.Inventory.AddItem(selectedObject);
               
                
                if(selectedObject.IsWeapon)
                {
                    player.EquipWeapon(selectedObject);
                    player.weaponEquiped= true;
                }

                // Remove the object from the game's list of objects
                
                pw.Remove(selectedObject);
                pictureBoxItem1.Visible = false;

                // Notify the player that they picked up the object
                
                pickUpObserver.OnAttackItemPicked(selectedObject);
                string message = string.Format($"You've picked up the {pw.Name}.");
                string description = string.Format($"The description of the item: {pw.Description}");
                _logger.LogInformation(message + description);
                _logTextBox.AppendText(message + Environment.NewLine);
                _logTextBox.AppendText(description + Environment.NewLine);

            }
            else
            {
                // The player is not in range, so you cannot pick up the object
                string message = string.Format("You are not close enough to the object to pick it up.");
                _logger.LogInformation(message);
                _logTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private bool IsInRange(IPosition position1, IPosition position2, int range)
        {
            double distance = Math.Sqrt(Math.Pow(player.X - pw.X, 2) + Math.Pow(player.Y - pw.Y, 2));
            return distance <= range;
        }
    }



}
