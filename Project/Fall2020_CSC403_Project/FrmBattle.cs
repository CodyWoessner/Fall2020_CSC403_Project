﻿using Fall2020_CSC403_Project.code;
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
        public FrmLevel parentForm = null;

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
        }
        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

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
        }

        // button attacks start here.

        // Attack Slash
        private void btnAtk_Slash(object sender, EventArgs e)
        {
            // updates the dialogue
            updateDialogue();
            player.OnAttack(-5);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                instance = null;
                parentForm.enemyDefeated();
                Close();
            }
        }

        //Attack RiskyHit
        private void btnAtk_RiskyHit(object sender, EventArgs e)
        {
            // updates the dialogue
            updateDialogue();

            player.OnAttack(-8);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                instance = null;
                parentForm.enemyDefeated();
                Close();
            }
        }

        //Attack Dodge
        private void btnAtk_Dodge(object sender, EventArgs e)
        { 
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                instance = null;
                parentForm.enemyDefeated();
                Close();
            }
        }
        // updateDialogue function picks a random script of dialogue to show and hides the others
        private void updateDialogue()
        {
            Random randint = new Random();
            var scripts = new List<PictureBox>()
        {
            script0,script1,script2,script3,script4,script5,scriptDialogue
        };
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

    }
}