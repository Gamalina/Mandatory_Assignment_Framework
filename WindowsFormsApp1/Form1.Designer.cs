namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Attack = new System.Windows.Forms.Button();
            this.ButtonPickUp = new System.Windows.Forms.Button();
            this.ProgBarPlayer = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblEnemy = new System.Windows.Forms.Label();
            this.ProgBarEnemy = new System.Windows.Forms.ProgressBar();
            this.TimerEnemyAttack = new System.Windows.Forms.Timer(this.components);
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.MapGrid = new System.Windows.Forms.Panel();
            this.pictureBoxItem1 = new System.Windows.Forms.PictureBox();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MapGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(303, 533);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(75, 23);
            this.Attack.TabIndex = 1;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // ButtonPickUp
            // 
            this.ButtonPickUp.Location = new System.Drawing.Point(465, 533);
            this.ButtonPickUp.Name = "ButtonPickUp";
            this.ButtonPickUp.Size = new System.Drawing.Size(75, 23);
            this.ButtonPickUp.TabIndex = 2;
            this.ButtonPickUp.Text = "Pick Up";
            this.ButtonPickUp.UseVisualStyleBackColor = true;
            this.ButtonPickUp.Click += new System.EventHandler(this.ButtonPick_Click);
            // 
            // ProgBarPlayer
            // 
            this.ProgBarPlayer.Location = new System.Drawing.Point(3, 30);
            this.ProgBarPlayer.Maximum = 500;
            this.ProgBarPlayer.Name = "ProgBarPlayer";
            this.ProgBarPlayer.Size = new System.Drawing.Size(285, 23);
            this.ProgBarPlayer.TabIndex = 4;
            this.ProgBarPlayer.Value = 500;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPlayerName);
            this.panel1.Controls.Add(this.ProgBarPlayer);
            this.panel1.Location = new System.Drawing.Point(0, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 56);
            this.panel1.TabIndex = 5;
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerName.Location = new System.Drawing.Point(3, 6);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(56, 21);
            this.LblPlayerName.TabIndex = 5;
            this.LblPlayerName.Text = "Player";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblEnemy);
            this.panel2.Controls.Add(this.ProgBarEnemy);
            this.panel2.Location = new System.Drawing.Point(498, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 64);
            this.panel2.TabIndex = 6;
            // 
            // LblEnemy
            // 
            this.LblEnemy.AutoSize = true;
            this.LblEnemy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnemy.Location = new System.Drawing.Point(3, 6);
            this.LblEnemy.Name = "LblEnemy";
            this.LblEnemy.Size = new System.Drawing.Size(61, 21);
            this.LblEnemy.TabIndex = 5;
            this.LblEnemy.Text = "Enemy";
            // 
            // ProgBarEnemy
            // 
            this.ProgBarEnemy.Location = new System.Drawing.Point(3, 30);
            this.ProgBarEnemy.Maximum = 90;
            this.ProgBarEnemy.Name = "ProgBarEnemy";
            this.ProgBarEnemy.Size = new System.Drawing.Size(285, 23);
            this.ProgBarEnemy.TabIndex = 4;
            this.ProgBarEnemy.Value = 90;
            // 
            // TimerEnemyAttack
            // 
            this.TimerEnemyAttack.Interval = 2000;
            this.TimerEnemyAttack.Tick += new System.EventHandler(this.TimerEnemyAttack_Tick);
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.White;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogTextBox.Location = new System.Drawing.Point(798, 0);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(409, 589);
            this.LogTextBox.TabIndex = 7;
            this.LogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(303, 562);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(75, 23);
            this.ButtonLeft.TabIndex = 8;
            this.ButtonLeft.Text = "Left";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(384, 533);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(75, 23);
            this.ButtonUp.TabIndex = 9;
            this.ButtonUp.Text = "Up";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Location = new System.Drawing.Point(384, 562);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(75, 23);
            this.ButtonDown.TabIndex = 10;
            this.ButtonDown.Text = "Down";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(465, 562);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(75, 23);
            this.ButtonRight.TabIndex = 11;
            this.ButtonRight.Text = "Right";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // MapGrid
            // 
            this.MapGrid.Controls.Add(this.pictureBoxItem1);
            this.MapGrid.Controls.Add(this.EnemyPictureBox);
            this.MapGrid.Controls.Add(this.PlayerPictureBox);
            this.MapGrid.Location = new System.Drawing.Point(0, 0);
            this.MapGrid.Name = "MapGrid";
            this.MapGrid.Size = new System.Drawing.Size(492, 527);
            this.MapGrid.TabIndex = 13;
            // 
            // pictureBoxItem1
            // 
            this.pictureBoxItem1.Location = new System.Drawing.Point(242, 122);
            this.pictureBoxItem1.Name = "pictureBoxItem1";
            this.pictureBoxItem1.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxItem1.TabIndex = 16;
            this.pictureBoxItem1.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.Location = new System.Drawing.Point(208, 0);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(60, 60);
            this.EnemyPictureBox.TabIndex = 15;
            this.EnemyPictureBox.TabStop = false;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.Location = new System.Drawing.Point(208, 464);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(60, 60);
            this.PlayerPictureBox.TabIndex = 14;
            this.PlayerPictureBox.TabStop = false;
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.Location = new System.Drawing.Point(505, 357);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(120, 95);
            this.listBoxInventory.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 589);
            this.Controls.Add(this.listBoxInventory);
            this.Controls.Add(this.MapGrid);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPickUp);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MapGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button ButtonPickUp;
        private System.Windows.Forms.ProgressBar ProgBarPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEnemy;
        private System.Windows.Forms.ProgressBar ProgBarEnemy;
        private System.Windows.Forms.Timer TimerEnemyAttack;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Panel MapGrid;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.PictureBox EnemyPictureBox;
        private System.Windows.Forms.ListBox listBoxInventory;
        public System.Windows.Forms.PictureBox pictureBoxItem1;
    }
}

