﻿using System.Windows.Forms;

namespace WinFormsUI
{
    partial class FormCheckersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckersGame));
            this.PanelScorePlayer2 = new System.Windows.Forms.Panel();
            this.labelScorePlayer2 = new System.Windows.Forms.Label();
            this.labelNamePlayer2 = new System.Windows.Forms.Label();
            this.PanelScorePlayer1 = new System.Windows.Forms.Panel();
            this.labelScorePlayer1 = new System.Windows.Forms.Label();
            this.labelNamePlayer1 = new System.Windows.Forms.Label();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxArrowTurn = new System.Windows.Forms.PictureBox();
            this.TimerToStartComputerMove = new System.Windows.Forms.Timer(this.components);
            this.PanelScorePlayer2.SuspendLayout();
            this.PanelScorePlayer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelScorePlayer2
            // 
            this.PanelScorePlayer2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PanelScorePlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PanelScorePlayer2.BackgroundImage = global::WinFormsUI.Properties.Resources.wood_deep;
            this.PanelScorePlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelScorePlayer2.Controls.Add(this.labelScorePlayer2);
            this.PanelScorePlayer2.Controls.Add(this.labelNamePlayer2);
            this.PanelScorePlayer2.Location = new System.Drawing.Point(486, 12);
            this.PanelScorePlayer2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelScorePlayer2.Name = "PanelScorePlayer2";
            this.PanelScorePlayer2.Size = new System.Drawing.Size(298, 91);
            this.PanelScorePlayer2.TabIndex = 2;
            // 
            // labelScorePlayer2
            // 
            this.labelScorePlayer2.AutoSize = true;
            this.labelScorePlayer2.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.labelScorePlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScorePlayer2.Location = new System.Drawing.Point(200, 10);
            this.labelScorePlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScorePlayer2.Name = "labelScorePlayer2";
            this.labelScorePlayer2.Size = new System.Drawing.Size(59, 61);
            this.labelScorePlayer2.TabIndex = 2;
            this.labelScorePlayer2.Text = "0";
            // 
            // labelNamePlayer2
            // 
            this.labelNamePlayer2.AutoSize = true;
            this.labelNamePlayer2.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.labelNamePlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNamePlayer2.Location = new System.Drawing.Point(21, 20);
            this.labelNamePlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamePlayer2.Name = "labelNamePlayer2";
            this.labelNamePlayer2.Size = new System.Drawing.Size(194, 50);
            this.labelNamePlayer2.TabIndex = 2;
            this.labelNamePlayer2.Text = "Second:";
            // 
            // PanelScorePlayer1
            // 
            this.PanelScorePlayer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PanelScorePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PanelScorePlayer1.BackgroundImage = global::WinFormsUI.Properties.Resources.wood_deep;
            this.PanelScorePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelScorePlayer1.Controls.Add(this.labelScorePlayer1);
            this.PanelScorePlayer1.Controls.Add(this.labelNamePlayer1);
            this.PanelScorePlayer1.Location = new System.Drawing.Point(15, 12);
            this.PanelScorePlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.PanelScorePlayer1.Name = "PanelScorePlayer1";
            this.PanelScorePlayer1.Size = new System.Drawing.Size(306, 91);
            this.PanelScorePlayer1.TabIndex = 1;
            // 
            // labelScorePlayer1
            // 
            this.labelScorePlayer1.AutoSize = true;
            this.labelScorePlayer1.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.labelScorePlayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScorePlayer1.Location = new System.Drawing.Point(162, 10);
            this.labelScorePlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScorePlayer1.Name = "labelScorePlayer1";
            this.labelScorePlayer1.Size = new System.Drawing.Size(59, 61);
            this.labelScorePlayer1.TabIndex = 1;
            this.labelScorePlayer1.Text = "0";
            // 
            // labelNamePlayer1
            // 
            this.labelNamePlayer1.AutoSize = true;
            this.labelNamePlayer1.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.labelNamePlayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNamePlayer1.Location = new System.Drawing.Point(28, 20);
            this.labelNamePlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamePlayer1.Name = "labelNamePlayer1";
            this.labelNamePlayer1.Size = new System.Drawing.Size(145, 50);
            this.labelNamePlayer1.TabIndex = 0;
            this.labelNamePlayer1.Text = "First:";
            // 
            // panelBoard
            // 
            this.panelBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBoard.BackColor = System.Drawing.Color.BurlyWood;
            this.panelBoard.BackgroundImage = global::WinFormsUI.Properties.Resources.checkers_board;
            this.panelBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoard.Location = new System.Drawing.Point(102, 114);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Padding = new System.Windows.Forms.Padding(60, 50, 60, 50);
            this.panelBoard.Size = new System.Drawing.Size(599, 500);
            this.panelBoard.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxArrowTurn);
            this.panel1.Controls.Add(this.PanelScorePlayer2);
            this.panel1.Controls.Add(this.PanelScorePlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 106);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxArrowTurn
            // 
            this.pictureBoxArrowTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxArrowTurn.Image = global::WinFormsUI.Properties.Resources.turn_arrow;
            this.pictureBoxArrowTurn.Location = new System.Drawing.Point(360, 30);
            this.pictureBoxArrowTurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxArrowTurn.Name = "pictureBoxArrowTurn";
            this.pictureBoxArrowTurn.Size = new System.Drawing.Size(92, 58);
            this.pictureBoxArrowTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowTurn.TabIndex = 3;
            this.pictureBoxArrowTurn.TabStop = false;
            // 
            // TimerToStartComputerMove
            // 
            this.TimerToStartComputerMove.Interval = 1000;
            this.TimerToStartComputerMove.Tick += new System.EventHandler(this.TimerComputerThinking_Tick);
            // 
            // FormCheckersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsUI.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(798, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCheckersGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckersGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCheckersGame_FormClosing);
            this.PanelScorePlayer2.ResumeLayout(false);
            this.PanelScorePlayer2.PerformLayout();
            this.PanelScorePlayer1.ResumeLayout(false);
            this.PanelScorePlayer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelNamePlayer1;
        private Panel PanelScorePlayer2;
        private Panel PanelScorePlayer1;
        private Label labelScorePlayer1;
        private Label labelScorePlayer2;
        private Label labelNamePlayer2;
        private Panel panelBoard;
        private Panel panel1;
        private PictureBox pictureBoxArrowTurn;
        private System.Windows.Forms.Timer TimerToStartComputerMove;
    }
}