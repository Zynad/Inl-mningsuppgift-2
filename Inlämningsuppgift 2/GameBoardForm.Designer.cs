namespace Inlämningsuppgift_2
{
    partial class GameBoardForm
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.ShootButton = new System.Windows.Forms.Button();
            this.ShotgunButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GameBoxList = new System.Windows.Forms.ListBox();
            this.PlayerShotLabel = new System.Windows.Forms.Label();
            this.CPUShotLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CPUChoiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(27, 355);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(90, 29);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Ladda";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(142, 355);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(90, 29);
            this.BlockButton.TabIndex = 1;
            this.BlockButton.Text = "Blocka";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // ShootButton
            // 
            this.ShootButton.Location = new System.Drawing.Point(27, 399);
            this.ShootButton.Name = "ShootButton";
            this.ShootButton.Size = new System.Drawing.Size(90, 29);
            this.ShootButton.TabIndex = 2;
            this.ShootButton.Text = "Skjut";
            this.ShootButton.UseVisualStyleBackColor = true;
            this.ShootButton.Click += new System.EventHandler(this.ShootButton_Click);
            // 
            // ShotgunButton
            // 
            this.ShotgunButton.Location = new System.Drawing.Point(142, 399);
            this.ShotgunButton.Name = "ShotgunButton";
            this.ShotgunButton.Size = new System.Drawing.Size(90, 29);
            this.ShotgunButton.TabIndex = 3;
            this.ShotgunButton.Text = "Shotgun";
            this.ShotgunButton.UseVisualStyleBackColor = true;
            this.ShotgunButton.Click += new System.EventHandler(this.ShotgunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(672, 399);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 29);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Avbryt";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GameBoxList
            // 
            this.GameBoxList.FormattingEnabled = true;
            this.GameBoxList.ItemHeight = 15;
            this.GameBoxList.Location = new System.Drawing.Point(275, 69);
            this.GameBoxList.Name = "GameBoxList";
            this.GameBoxList.Size = new System.Drawing.Size(272, 214);
            this.GameBoxList.TabIndex = 5;
            // 
            // PlayerShotLabel
            // 
            this.PlayerShotLabel.AutoSize = true;
            this.PlayerShotLabel.Location = new System.Drawing.Point(142, 268);
            this.PlayerShotLabel.Name = "PlayerShotLabel";
            this.PlayerShotLabel.Size = new System.Drawing.Size(118, 15);
            this.PlayerShotLabel.TabIndex = 6;
            this.PlayerShotLabel.Text = "Spelare antal skott : 0";
            // 
            // CPUShotLabel
            // 
            this.CPUShotLabel.AutoSize = true;
            this.CPUShotLabel.Location = new System.Drawing.Point(564, 268);
            this.CPUShotLabel.Name = "CPUShotLabel";
            this.CPUShotLabel.Size = new System.Drawing.Size(103, 15);
            this.CPUShotLabel.TabIndex = 7;
            this.CPUShotLabel.Text = "CPU antal skott : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Runda 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Runda 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Runda 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Runda 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Runda 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Runda 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Runda 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Runda 6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Runda 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Runda 7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Runda 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Runda 8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Runda 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Runda 9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Runda 10";
            // 
            // CPUChoiceLabel
            // 
            this.CPUChoiceLabel.AutoSize = true;
            this.CPUChoiceLabel.Location = new System.Drawing.Point(597, 178);
            this.CPUChoiceLabel.Name = "CPUChoiceLabel";
            this.CPUChoiceLabel.Size = new System.Drawing.Size(54, 15);
            this.CPUChoiceLabel.TabIndex = 9;
            this.CPUChoiceLabel.Text = "CPU val :";
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPUChoiceLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUShotLabel);
            this.Controls.Add(this.PlayerShotLabel);
            this.Controls.Add(this.GameBoxList);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ShotgunButton);
            this.Controls.Add(this.ShootButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "GameBoardForm";
            this.Text = "Spelbräda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadButton;
        private Button BlockButton;
        private Button ShootButton;
        private Button ShotgunButton;
        private Button CancelButton;
        private ListBox GameBoxList;
        private Label PlayerShotLabel;
        private Label CPUShotLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label CPUChoiceLabel;
    }
}