namespace TruckRacingGame
{
    partial class TruckRaceForm
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
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonAI = new System.Windows.Forms.RadioButton();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownForBet = new System.Windows.Forms.NumericUpDown();
            this.btnBets = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.truck4 = new System.Windows.Forms.PictureBox();
            this.truck3 = new System.Windows.Forms.PictureBox();
            this.truck2 = new System.Windows.Forms.PictureBox();
            this.truck1 = new System.Windows.Forms.PictureBox();
            this.truckTrack = new System.Windows.Forms.PictureBox();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingParlor
            // 
            this.bettingParlor.BackColor = System.Drawing.Color.MistyRose;
            this.bettingParlor.Controls.Add(this.resetButton);
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.numericUpDownNumber);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.numericUpDownForBet);
            this.bettingParlor.Controls.Add(this.btnBets);
            this.bettingParlor.Controls.Add(this.nameLabel);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.alBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.radioButtonAI);
            this.bettingParlor.Controls.Add(this.radioButtonBob);
            this.bettingParlor.Controls.Add(this.radioButtonJoe);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(336, 297);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(352, 276);
            this.bettingParlor.TabIndex = 5;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Place";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(28, 32);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(83, 16);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet";
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Location = new System.Drawing.Point(31, 61);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(96, 17);
            this.radioButtonJoe.TabIndex = 1;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "radioButtonJoe";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(31, 93);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(98, 17);
            this.radioButtonBob.TabIndex = 2;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "radioButtonBob";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            // 
            // radioButtonAI
            // 
            this.radioButtonAI.AutoSize = true;
            this.radioButtonAI.Location = new System.Drawing.Point(31, 126);
            this.radioButtonAI.Name = "radioButtonAI";
            this.radioButtonAI.Size = new System.Drawing.Size(89, 17);
            this.radioButtonAI.TabIndex = 3;
            this.radioButtonAI.TabStop = true;
            this.radioButtonAI.Text = "radioButtonAI";
            this.radioButtonAI.UseVisualStyleBackColor = true;
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(163, 126);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(158, 17);
            this.alBetLabel.TabIndex = 15;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(163, 93);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(158, 17);
            this.bobBetLabel.TabIndex = 14;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(163, 62);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(158, 17);
            this.joeBetLabel.TabIndex = 13;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bets";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(286, 170);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownNumber.TabIndex = 21;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "bets on truck number";
            // 
            // numericUpDownForBet
            // 
            this.numericUpDownForBet.Location = new System.Drawing.Point(117, 172);
            this.numericUpDownForBet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownForBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForBet.Name = "numericUpDownForBet";
            this.numericUpDownForBet.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownForBet.TabIndex = 19;
            this.numericUpDownForBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(62, 170);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(45, 23);
            this.btnBets.TabIndex = 18;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(19, 13);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "----";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // raceButton
            // 
            this.raceButton.BackColor = System.Drawing.Color.Black;
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.raceButton.Location = new System.Drawing.Point(31, 221);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(154, 49);
            this.raceButton.TabIndex = 22;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = false;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(205, 221);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 48);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // RaceTimer
            // 
            this.RaceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // truck4
            // 
            this.truck4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck4.Image = global::TruckRacingGame.Properties.Resources.t441;
            this.truck4.Location = new System.Drawing.Point(210, 12);
            this.truck4.Name = "truck4";
            this.truck4.Size = new System.Drawing.Size(23, 76);
            this.truck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck4.TabIndex = 4;
            this.truck4.TabStop = false;
            // 
            // truck3
            // 
            this.truck3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck3.Image = global::TruckRacingGame.Properties.Resources.t331;
            this.truck3.Location = new System.Drawing.Point(172, 12);
            this.truck3.Name = "truck3";
            this.truck3.Size = new System.Drawing.Size(23, 76);
            this.truck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck3.TabIndex = 3;
            this.truck3.TabStop = false;
            // 
            // truck2
            // 
            this.truck2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck2.Image = global::TruckRacingGame.Properties.Resources.t221;
            this.truck2.Location = new System.Drawing.Point(133, 12);
            this.truck2.Name = "truck2";
            this.truck2.Size = new System.Drawing.Size(23, 76);
            this.truck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck2.TabIndex = 2;
            this.truck2.TabStop = false;
            // 
            // truck1
            // 
            this.truck1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck1.Image = global::TruckRacingGame.Properties.Resources.t111;
            this.truck1.Location = new System.Drawing.Point(93, 12);
            this.truck1.Name = "truck1";
            this.truck1.Size = new System.Drawing.Size(23, 76);
            this.truck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck1.TabIndex = 1;
            this.truck1.TabStop = false;
            // 
            // truckTrack
            // 
            this.truckTrack.Image = global::TruckRacingGame.Properties.Resources.track331;
            this.truckTrack.Location = new System.Drawing.Point(0, 0);
            this.truckTrack.Name = "truckTrack";
            this.truckTrack.Size = new System.Drawing.Size(320, 585);
            this.truckTrack.TabIndex = 0;
            this.truckTrack.TabStop = false;
            // 
            // TruckRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 585);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.truck4);
            this.Controls.Add(this.truck3);
            this.Controls.Add(this.truck2);
            this.Controls.Add(this.truck1);
            this.Controls.Add(this.truckTrack);
            this.Name = "TruckRaceForm";
            this.Text = "TruckRaceForm";
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox truckTrack;
        private System.Windows.Forms.PictureBox truck1;
        private System.Windows.Forms.PictureBox truck2;
        private System.Windows.Forms.PictureBox truck3;
        private System.Windows.Forms.PictureBox truck4;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton radioButtonAI;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownForBet;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer RaceTimer;
    }
}