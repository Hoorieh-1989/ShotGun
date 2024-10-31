namespace ShotGun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonShoot = new Button();
            buttonLoad = new Button();
            buttonBlock = new Button();
            buttonStartAgain = new Button();
            label1 = new Label();
            labelPlayer = new Label();
            labelComputer = new Label();
            labelMessage = new Label();
            buttonShotGun = new Button();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.BackColor = Color.Firebrick;
            buttonShoot.Font = new Font("Bernard MT Condensed", 10.8F);
            buttonShoot.Location = new Point(99, 315);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(152, 47);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = false;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.PaleGoldenrod;
            buttonLoad.Font = new Font("Bernard MT Condensed", 10.8F);
            buttonLoad.Location = new Point(311, 315);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(152, 47);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackColor = Color.DeepSkyBlue;
            buttonBlock.Font = new Font("Bernard MT Condensed", 10.8F);
            buttonBlock.Location = new Point(99, 415);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(152, 47);
            buttonBlock.TabIndex = 2;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = false;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonStartAgain
            // 
            buttonStartAgain.BackColor = Color.YellowGreen;
            buttonStartAgain.Font = new Font("Bernard MT Condensed", 10.8F);
            buttonStartAgain.Location = new Point(311, 415);
            buttonStartAgain.Name = "buttonStartAgain";
            buttonStartAgain.Size = new Size(152, 47);
            buttonStartAgain.TabIndex = 3;
            buttonStartAgain.Text = "Start Again";
            buttonStartAgain.UseVisualStyleBackColor = false;
            buttonStartAgain.Click += buttonStartAgain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.BackColor = SystemColors.ActiveCaptionText;
            labelPlayer.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayer.ForeColor = Color.Snow;
            labelPlayer.Location = new Point(108, 32);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(65, 24);
            labelPlayer.TabIndex = 5;
            labelPlayer.Text = "Player ";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.BackColor = SystemColors.ActiveCaptionText;
            labelComputer.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelComputer.ForeColor = Color.Ivory;
            labelComputer.Location = new Point(108, 116);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(84, 24);
            labelComputer.TabIndex = 6;
            labelComputer.Text = "Computer";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.BackColor = SystemColors.ActiveCaptionText;
            labelMessage.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.OrangeRed;
            labelMessage.Location = new Point(108, 205);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(101, 33);
            labelMessage.TabIndex = 7;
            labelMessage.Text = "Message";
            // 
            // buttonShotGun
            // 
            buttonShotGun.BackColor = Color.Salmon;
            buttonShotGun.Font = new Font("Bernard MT Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShotGun.Location = new Point(502, 337);
            buttonShotGun.Name = "buttonShotGun";
            buttonShotGun.Size = new Size(275, 72);
            buttonShotGun.TabIndex = 10;
            buttonShotGun.Text = "ShotGun";
            buttonShotGun.UseVisualStyleBackColor = false;
            buttonShotGun.Click += buttonShotGun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(813, 512);
            Controls.Add(buttonShotGun);
            Controls.Add(labelMessage);
            Controls.Add(labelComputer);
            Controls.Add(labelPlayer);
            Controls.Add(label1);
            Controls.Add(buttonStartAgain);
            Controls.Add(buttonBlock);
            Controls.Add(buttonLoad);
            Controls.Add(buttonShoot);
            Name = "Form1";
            Text = "ShotGun";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonLoad;
        private Button buttonBlock;
        private Button buttonStartAgain;
        private Label label1;
        private Label labelPlayer;
        private Label labelComputer;
        private Label labelMessage;
        private Button buttonShotGun;
    }
}
