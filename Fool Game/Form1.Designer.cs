namespace Fool_Game
{
    partial class FoolGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoolGame));
            this.HomePanel = new System.Windows.Forms.Panel();
            this.YesPanel = new System.Windows.Forms.Panel();
            this.NoPanel = new System.Windows.Forms.Panel();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.NExitButton = new System.Windows.Forms.Button();
            this.NoLabel = new System.Windows.Forms.Label();
            this.WowImg = new System.Windows.Forms.PictureBox();
            this.TryButton = new System.Windows.Forms.Button();
            this.FExitButton = new System.Windows.Forms.Button();
            this.FoolLabel = new System.Windows.Forms.Label();
            this.HaHaImg = new System.Windows.Forms.PictureBox();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HomePanel.SuspendLayout();
            this.YesPanel.SuspendLayout();
            this.NoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WowImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaHaImg)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePanel.BackgroundImage")));
            this.HomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomePanel.Controls.Add(this.YesPanel);
            this.HomePanel.Controls.Add(this.NoButton);
            this.HomePanel.Controls.Add(this.YesButton);
            this.HomePanel.Controls.Add(this.TitleLabel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(714, 516);
            this.HomePanel.TabIndex = 0;
            // 
            // YesPanel
            // 
            this.YesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YesPanel.BackgroundImage")));
            this.YesPanel.Controls.Add(this.NoPanel);
            this.YesPanel.Controls.Add(this.TryButton);
            this.YesPanel.Controls.Add(this.FExitButton);
            this.YesPanel.Controls.Add(this.FoolLabel);
            this.YesPanel.Controls.Add(this.HaHaImg);
            this.YesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesPanel.Location = new System.Drawing.Point(0, 0);
            this.YesPanel.Name = "YesPanel";
            this.YesPanel.Size = new System.Drawing.Size(710, 512);
            this.YesPanel.TabIndex = 3;
            this.YesPanel.Visible = false;
            // 
            // NoPanel
            // 
            this.NoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoPanel.BackgroundImage")));
            this.NoPanel.Controls.Add(this.ReplayButton);
            this.NoPanel.Controls.Add(this.NExitButton);
            this.NoPanel.Controls.Add(this.NoLabel);
            this.NoPanel.Controls.Add(this.WowImg);
            this.NoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoPanel.Location = new System.Drawing.Point(0, 0);
            this.NoPanel.Name = "NoPanel";
            this.NoPanel.Size = new System.Drawing.Size(710, 512);
            this.NoPanel.TabIndex = 4;
            this.NoPanel.Visible = false;
            // 
            // ReplayButton
            // 
            this.ReplayButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplayButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReplayButton.Location = new System.Drawing.Point(169, 400);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(90, 38);
            this.ReplayButton.TabIndex = 4;
            this.ReplayButton.Text = "Play Again";
            this.ReplayButton.UseVisualStyleBackColor = false;
            this.ReplayButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NExitButton
            // 
            this.NExitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NExitButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NExitButton.Location = new System.Drawing.Point(411, 400);
            this.NExitButton.Name = "NExitButton";
            this.NExitButton.Size = new System.Drawing.Size(90, 38);
            this.NExitButton.TabIndex = 3;
            this.NExitButton.Text = "Exit";
            this.NExitButton.UseVisualStyleBackColor = false;
            this.NExitButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NoLabel
            // 
            this.NoLabel.AutoSize = true;
            this.NoLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLabel.Location = new System.Drawing.Point(163, 61);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(373, 32);
            this.NoLabel.TabIndex = 1;
            this.NoLabel.Text = "You are a NOT a fool !!!";
            // 
            // WowImg
            // 
            this.WowImg.Image = global::Fool_Game.Properties.Resources.wow_Crop2;
            this.WowImg.Location = new System.Drawing.Point(222, 130);
            this.WowImg.Name = "WowImg";
            this.WowImg.Size = new System.Drawing.Size(225, 213);
            this.WowImg.TabIndex = 0;
            this.WowImg.TabStop = false;
            // 
            // TryButton
            // 
            this.TryButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TryButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TryButton.Location = new System.Drawing.Point(169, 400);
            this.TryButton.Name = "TryButton";
            this.TryButton.Size = new System.Drawing.Size(90, 38);
            this.TryButton.TabIndex = 4;
            this.TryButton.Text = "Try Again";
            this.TryButton.UseVisualStyleBackColor = false;
            this.TryButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FExitButton
            // 
            this.FExitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FExitButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FExitButton.Location = new System.Drawing.Point(411, 400);
            this.FExitButton.Name = "FExitButton";
            this.FExitButton.Size = new System.Drawing.Size(90, 38);
            this.FExitButton.TabIndex = 3;
            this.FExitButton.Text = "Exit";
            this.FExitButton.UseVisualStyleBackColor = false;
            this.FExitButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FoolLabel
            // 
            this.FoolLabel.AutoSize = true;
            this.FoolLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoolLabel.Location = new System.Drawing.Point(192, 61);
            this.FoolLabel.Name = "FoolLabel";
            this.FoolLabel.Size = new System.Drawing.Size(273, 32);
            this.FoolLabel.TabIndex = 1;
            this.FoolLabel.Text = "You are a fool !!!";
            // 
            // HaHaImg
            // 
            this.HaHaImg.Image = ((System.Drawing.Image)(resources.GetObject("HaHaImg.Image")));
            this.HaHaImg.Location = new System.Drawing.Point(222, 130);
            this.HaHaImg.Name = "HaHaImg";
            this.HaHaImg.Size = new System.Drawing.Size(214, 223);
            this.HaHaImg.TabIndex = 0;
            this.HaHaImg.TabStop = false;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoButton.Location = new System.Drawing.Point(414, 223);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(90, 38);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.ButtonClick);
            this.NoButton.MouseEnter += new System.EventHandler(this.ButtonEnter);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YesButton.Location = new System.Drawing.Point(201, 223);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(90, 38);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLabel.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(201, 76);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(303, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Are You A FOOL ?";
            // 
            // FoolGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.HomePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoolGame";
            this.Text = "Fool Game";
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.YesPanel.ResumeLayout(false);
            this.YesPanel.PerformLayout();
            this.NoPanel.ResumeLayout(false);
            this.NoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WowImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaHaImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel YesPanel;
        private System.Windows.Forms.PictureBox HaHaImg;
        private System.Windows.Forms.Button TryButton;
        private System.Windows.Forms.Button FExitButton;
        private System.Windows.Forms.Label FoolLabel;
        private System.Windows.Forms.Panel NoPanel;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button NExitButton;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.PictureBox WowImg;
    }
}

