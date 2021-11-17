using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        bool burn = false;
        Random RNG = new Random();
        public FrmLevel parentForm = null;

        public FrmBattle(bool burn)
        {
            this.burn = burn;
        }

        private FrmBattle()
        {
            InitializeComponent();
            InitDialogue();// Initialize the dialogue
            
            player = Game.player;
        }
        // InitDialogue function shows the script dialogue then hides the scripts
        private void InitDialogue()
        {
            scriptDialogue.Show();
            script0.Hide();
            script1.Hide();
            script2.Hide();
            script3.Hide();
            script4.Hide();
            script5.Hide();
            BossBeg.Hide();
        }
        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;
            btnAttack1.Visible = false;
            btnAttack2.Visible = false;
            btnAttack3.Visible = false;
            btnMercy.Visible = false;
            btnObliterate.Visible = false;

            bool Status = false;
            
            // add current weapons effects
            this.btnAttack4.Visible = false;
            // this.btnAttack4.Visible = true;
            if (player.Inventory[2].ItemType == "cheeto_knives") 
            {
                this.btnAttack4.Visible = true;
            }
            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;
            scriptDialogue.Hide();
            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;

        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();

            if (enemy.Health == 1)
            {
                btnMercy.Visible = true;
                btnObliterate.Visible = true;
            }
            if (enemy.Health > 1)
            {
                btnAttack1.Visible = true;
                btnAttack2.Visible = true;
                btnAttack3.Visible = true;
            }
            /*if (player.Health <= 0 || enemy.Health <= 0)
            {
                instance = null;
                Close();
            }*/
        }

        // button attacks start here.

        // Attack Slash
        private void btnAtk_Slash(object sender, EventArgs e)
        {
            // updates the dialogue
            updateDialogue();

            // See if player's attack hits
            if (RNG.Next(1, 11) > 1)
            {
                player.OnAttack(-3);
            }

            // deals damage if burnAtk has been used
            bool burn = BurnDmg(this.burn);


            if (enemy.Health > 0 && RNG.Next(1, 11) > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (enemy.Health <= 0)
            {
                btnAttack1.Visible = false;
                btnAttack2.Visible = false;
                btnAttack3.Visible = false;
                while (enemy.Health != 1)
                {
                    enemy.AlterHealth(+1);
                }
                UpdateHealthBars();

            }
            if (player.Health <= 0)
            {
                instance = null;
                Close();
            }
        }

        //Attack RiskyHit
        private void btnAtk_RiskyHit(object sender, EventArgs e)
        {
            // updates the dialogue
            updateDialogue();

            // See if player's attack hits
            if (RNG.Next(1, 11) > 1)
            {
                // Try to "Crit' dealing massive damage
                if (RNG.Next(1, 11) > 9)
                {
                    player.OnAttack(-10);
                }
                else
                {
                    player.OnAttack(-1);
                }
            }
            // deals damage if burnAtk has been used
            bool burn = BurnDmg(this.burn);
            if (enemy.Health > 0 && RNG.Next(1, 11) > 1)
            {
                enemy.OnAttack(-4);
            }

            UpdateHealthBars();
            if (enemy.Health <= 0)
            {
                btnAttack1.Visible = false;
                btnAttack2.Visible = false;
                btnAttack3.Visible = false;
                while (enemy.Health != 1)
                {
                    enemy.AlterHealth(+1);
                }
                UpdateHealthBars();
             
            }
            if (player.Health <= 0)
            {
                instance = null;
                Close();
            }
        }

        //Attack Dodge
        private void btnAtk_Dodge(object sender, EventArgs e)
        {
            player.OnAttack(0);
            // deals damage if burnAtk has been used
            bool burn = BurnDmg(this.burn);

            // See if enemies's attack hits
            if (enemy.Health > 0 && RNG.Next(1, 11) > 9)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (enemy.Health <= 0)
            {
                btnAttack1.Visible = false;
                btnAttack2.Visible = false;
                btnAttack3.Visible = false;
                while (enemy.Health != 1)
                {
                    enemy.AlterHealth(+1);
                }
                UpdateHealthBars();
            }
            if (player.Health <= 0)
            {
                instance = null;
                Close();
            }
        }
        private void btnMercy_Mercy(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
        private void btnObliterate_Kill(object sender, EventArgs e)
        {

            player.OnAttack(-1); 
            instance = null; 
            parentForm.enemyDefeated(); 
            Close();
        }

        //Attack Burn
        private void btnAtk_Burn(object sender, EventArgs e)
        {
            // updates the dialogue
            updateDialogue();
            // See if player's attack hits
            if (RNG.Next(1, 11) > 1)
            {
                player.OnAttack(-2);
                this.burn = BurnDmg(true);
            }
            if (enemy.Health > 0 && RNG.Next(1, 11) > 1)
            {
                enemy.OnAttack(-1);
                instance = null;
                parentForm.enemyDefeated();
                Close();
            }

            UpdateHealthBars();
            

                player.OnAttack(-1);
                instance = null;
                parentForm.enemyDefeated();
                Close();

        }
            // updateDialogue function picks a random script of dialogue to show and hides the others
            private void updateDialogue()
            {
                Random randint = new Random();
                var scripts = new List<PictureBox>()
            {
                script0,script1,script2,script3,script4,script5,BossBeg,scriptDialogue
            };
                if (enemy.Health == 1)
                {
                    var i = 7;
                    scripts[i].Show();
                    foreach (var script in scripts)
                    {
                        if (script != scripts[i])
                        {
                            script.Hide();
                        }
                    }
                }
                else
                {
                    var i = randint.Next(6);
                    scripts[i].Show();
                    foreach (var script in scripts)
                    {
                        if (script != scripts[i])
                    {
                        script.Hide();
                    }
                }   
            }
        }

        private bool BurnDmg(bool burn)
        {
            if (enemy.Health > 0 && burn == true)
            {
                EnemyDamage(-2);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            scriptDialogue.Show();
            tmrFinalBattle.Enabled = false;
        }

        private void BossBeg_Click(object sender, EventArgs e)
        {

        }
    }
}