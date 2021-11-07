namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattle));
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnAttack3 = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.script0 = new System.Windows.Forms.PictureBox();
            this.script1 = new System.Windows.Forms.PictureBox();
            this.script2 = new System.Windows.Forms.PictureBox();
            this.script3 = new System.Windows.Forms.PictureBox();
            this.script4 = new System.Windows.Forms.PictureBox();
            this.script5 = new System.Windows.Forms.PictureBox();
            this.scriptDialogue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.script5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptDialogue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack1
            // 
            this.btnAttack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack1.Location = new System.Drawing.Point(171, 495);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(128, 43);
            this.btnAttack1.TabIndex = 2;
            this.btnAttack1.Text = "Slash";
            this.btnAttack1.UseVisualStyleBackColor = true;
            this.btnAttack1.Click += new System.EventHandler(this.btnAtk_Slash);
            // 
            // btnAttack2
            // 
            this.btnAttack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack2.Location = new System.Drawing.Point(346, 495);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(128, 43);
            this.btnAttack2.TabIndex = 0;
            this.btnAttack2.Text = "RiskyHit";
            this.btnAttack2.UseVisualStyleBackColor = true;
            this.btnAttack2.Click += new System.EventHandler(this.btnAtk_RiskyHit);
            // 
            // btnAttack3
            // 
            this.btnAttack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack3.Location = new System.Drawing.Point(520, 495);
            this.btnAttack3.Name = "btnAttack3";
            this.btnAttack3.Size = new System.Drawing.Size(128, 43);
            this.btnAttack3.TabIndex = 0;
            this.btnAttack3.Text = "Dodge";
            this.btnAttack3.UseVisualStyleBackColor = true;
            this.btnAttack3.Click += new System.EventHandler(this.btnAtk_Dodge);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(71, 60);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(515, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(516, 60);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(780, 563);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(30, 28);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(515, 98);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(229, 267);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(70, 98);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(229, 267);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // script0
            // 
            this.script0.BackColor = System.Drawing.Color.Transparent;
            this.script0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script0.BackgroundImage")));
            this.script0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script0.Location = new System.Drawing.Point(515, 371);
            this.script0.Name = "script0";
            this.script0.Size = new System.Drawing.Size(229, 103);
            this.script0.TabIndex = 8;
            this.script0.TabStop = false;
            // 
            // script1
            // 
            this.script1.BackColor = System.Drawing.Color.Transparent;
            this.script1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script1.BackgroundImage")));
            this.script1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script1.Location = new System.Drawing.Point(515, 371);
            this.script1.Name = "script1";
            this.script1.Size = new System.Drawing.Size(229, 103);
            this.script1.TabIndex = 9;
            this.script1.TabStop = false;
            // 
            // script2
            // 
            this.script2.BackColor = System.Drawing.Color.Transparent;
            this.script2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script2.BackgroundImage")));
            this.script2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script2.Location = new System.Drawing.Point(515, 371);
            this.script2.Name = "script2";
            this.script2.Size = new System.Drawing.Size(229, 103);
            this.script2.TabIndex = 10;
            this.script2.TabStop = false;
            // 
            // script3
            // 
            this.script3.BackColor = System.Drawing.Color.Transparent;
            this.script3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script3.BackgroundImage")));
            this.script3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script3.Location = new System.Drawing.Point(515, 371);
            this.script3.Name = "script3";
            this.script3.Size = new System.Drawing.Size(229, 103);
            this.script3.TabIndex = 11;
            this.script3.TabStop = false;
            // 
            // script4
            // 
            this.script4.BackColor = System.Drawing.Color.Transparent;
            this.script4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script4.BackgroundImage")));
            this.script4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script4.Location = new System.Drawing.Point(515, 371);
            this.script4.Name = "script4";
            this.script4.Size = new System.Drawing.Size(229, 103);
            this.script4.TabIndex = 12;
            this.script4.TabStop = false;
            // 
            // script5
            // 
            this.script5.BackColor = System.Drawing.Color.Transparent;
            this.script5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script5.BackgroundImage")));
            this.script5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.script5.Location = new System.Drawing.Point(515, 371);
            this.script5.Name = "script5";
            this.script5.Size = new System.Drawing.Size(229, 103);
            this.script5.TabIndex = 13;
            this.script5.TabStop = false;
            // 
            // scriptDialogue
            // 
            this.scriptDialogue.BackColor = System.Drawing.Color.Transparent;
            this.scriptDialogue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scriptDialogue.BackgroundImage")));
            this.scriptDialogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scriptDialogue.Location = new System.Drawing.Point(515, 371);
            this.scriptDialogue.Name = "scriptDialogue";
            this.scriptDialogue.Size = new System.Drawing.Size(229, 103);
            this.scriptDialogue.TabIndex = 14;
            this.scriptDialogue.TabStop = false;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 603);
            this.Controls.Add(this.scriptDialogue);
            this.Controls.Add(this.script5);
            this.Controls.Add(this.script4);
            this.Controls.Add(this.script3);
            this.Controls.Add(this.script2);
            this.Controls.Add(this.script1);
            this.Controls.Add(this.script0);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack1);
            this.Controls.Add(this.btnAttack2);
            this.Controls.Add(this.btnAttack3);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.script5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptDialogue)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack1;
    private System.Windows.Forms.Button btnAttack2;
    private System.Windows.Forms.Button btnAttack3;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.PictureBox script0;
        private System.Windows.Forms.PictureBox script1;
        private System.Windows.Forms.PictureBox script2;
        private System.Windows.Forms.PictureBox script3;
        private System.Windows.Forms.PictureBox script4;
        private System.Windows.Forms.PictureBox script5;
        private System.Windows.Forms.PictureBox scriptDialogue;
    }
}