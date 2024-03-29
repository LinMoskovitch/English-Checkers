﻿using System.Windows.Forms;

namespace WinFormsUI
{
    partial class FormProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProperties));
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.radioButtonSize6X6 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize8X8 = new System.Windows.Forms.RadioButton();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecondPlayer = new System.Windows.Forms.TextBox();
            this.checkBoxWantPlayer2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButton10X10 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.labelBoardSize.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.labelBoardSize.Location = new System.Drawing.Point(61, 46);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(492, 91);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // radioButtonSize6X6
            // 
            this.radioButtonSize6X6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSize6X6.AutoSize = true;
            this.radioButtonSize6X6.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSize6X6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSize6X6.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButtonSize6X6.Location = new System.Drawing.Point(16, 20);
            this.radioButtonSize6X6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSize6X6.Name = "radioButtonSize6X6";
            this.radioButtonSize6X6.Size = new System.Drawing.Size(175, 59);
            this.radioButtonSize6X6.TabIndex = 1;
            this.radioButtonSize6X6.Text = "6 X 6";
            this.radioButtonSize6X6.UseVisualStyleBackColor = false;
            // 
            // radioButtonSize8X8
            // 
            this.radioButtonSize8X8.AutoSize = true;
            this.radioButtonSize8X8.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSize8X8.Checked = true;
            this.radioButtonSize8X8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSize8X8.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButtonSize8X8.Location = new System.Drawing.Point(194, 20);
            this.radioButtonSize8X8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSize8X8.Name = "radioButtonSize8X8";
            this.radioButtonSize8X8.Size = new System.Drawing.Size(175, 59);
            this.radioButtonSize8X8.TabIndex = 1;
            this.radioButtonSize8X8.TabStop = true;
            this.radioButtonSize8X8.Text = "8 X 8";
            this.radioButtonSize8X8.UseVisualStyleBackColor = false;
            // 
            // labelPlayers
            // 
            this.labelPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayers.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.labelPlayers.Location = new System.Drawing.Point(61, 273);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(365, 91);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Players:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F);
            this.label1.Location = new System.Drawing.Point(63, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "First player:";
            // 
            // textBoxFirstPlayer
            // 
            this.textBoxFirstPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstPlayer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxFirstPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstPlayer.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.textBoxFirstPlayer.Location = new System.Drawing.Point(548, 369);
            this.textBoxFirstPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstPlayer.MaxLength = 10;
            this.textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            this.textBoxFirstPlayer.Size = new System.Drawing.Size(466, 63);
            this.textBoxFirstPlayer.TabIndex = 2;
            this.textBoxFirstPlayer.Text = "Player1";
            this.textBoxFirstPlayer.TextChanged += new System.EventHandler(this.textBoxFirstPlayer_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F);
            this.label2.Location = new System.Drawing.Point(120, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 79);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second player:";
            // 
            // textBoxSecondPlayer
            // 
            this.textBoxSecondPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondPlayer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSecondPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondPlayer.Enabled = false;
            this.textBoxSecondPlayer.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.textBoxSecondPlayer.Location = new System.Drawing.Point(666, 452);
            this.textBoxSecondPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSecondPlayer.MaxLength = 10;
            this.textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            this.textBoxSecondPlayer.Size = new System.Drawing.Size(348, 63);
            this.textBoxSecondPlayer.TabIndex = 2;
            this.textBoxSecondPlayer.Text = "Computer";
            this.textBoxSecondPlayer.TextChanged += new System.EventHandler(this.textBoxSecondPlayer_TextChanged);
            // 
            // checkBoxWantPlayer2
            // 
            this.checkBoxWantPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxWantPlayer2.AutoSize = true;
            this.checkBoxWantPlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWantPlayer2.Location = new System.Drawing.Point(77, 466);
            this.checkBoxWantPlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxWantPlayer2.Name = "checkBoxWantPlayer2";
            this.checkBoxWantPlayer2.Size = new System.Drawing.Size(28, 27);
            this.checkBoxWantPlayer2.TabIndex = 3;
            this.checkBoxWantPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxWantPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxWantPlayer2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.label3.Location = new System.Drawing.Point(61, 559);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 91);
            this.label3.TabIndex = 0;
            this.label3.Text = "Difficulty:";
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEasy.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButtonEasy.Location = new System.Drawing.Point(84, 654);
            this.radioButtonEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(168, 59);
            this.radioButtonEasy.TabIndex = 4;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = false;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMedium.Checked = true;
            this.radioButtonMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMedium.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButtonMedium.Location = new System.Drawing.Point(261, 654);
            this.radioButtonMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(249, 59);
            this.radioButtonMedium.TabIndex = 4;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = false;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonHard.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButtonHard.Location = new System.Drawing.Point(508, 654);
            this.radioButtonHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(177, 59);
            this.radioButtonHard.TabIndex = 4;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = false;
            // 
            // radioButton10X10
            // 
            this.radioButton10X10.AutoSize = true;
            this.radioButton10X10.BackColor = System.Drawing.Color.Transparent;
            this.radioButton10X10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton10X10.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.radioButton10X10.Location = new System.Drawing.Point(370, 20);
            this.radioButton10X10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton10X10.Name = "radioButton10X10";
            this.radioButton10X10.Size = new System.Drawing.Size(233, 59);
            this.radioButton10X10.TabIndex = 1;
            this.radioButton10X10.Text = "10 X 10";
            this.radioButton10X10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton10X10);
            this.panel1.Controls.Add(this.radioButtonSize6X6);
            this.panel1.Controls.Add(this.radioButtonSize8X8);
            this.panel1.Location = new System.Drawing.Point(77, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 89);
            this.panel1.TabIndex = 5;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlay.BackgroundImage = global::WinFormsUI.Properties.Resources.black_tile_small;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Font = new System.Drawing.Font("Cooper Black", 28.2F);
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(712, 618);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(290, 100);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsUI.Properties.Resources.white_wood_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 764);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonHard);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonEasy);
            this.Controls.Add(this.checkBoxWantPlayer2);
            this.Controls.Add(this.textBoxSecondPlayer);
            this.Controls.Add(this.textBoxFirstPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayers);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1132, 835);
            this.Name = "FormProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game properties";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBoardSize;
        private RadioButton radioButtonSize6X6;
        private RadioButton radioButtonSize8X8;
        private Label labelPlayers;
        private Label label1;
        private TextBox textBoxFirstPlayer;
        private Label label2;
        private TextBox textBoxSecondPlayer;
        private CheckBox checkBoxWantPlayer2;
        private Label label3;
        private RadioButton radioButtonEasy;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonHard;
        private RadioButton radioButton10X10;
        private Panel panel1;
        private Button buttonPlay;
    }
}