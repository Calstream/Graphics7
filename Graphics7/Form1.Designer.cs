﻿namespace Graphics7
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.th_l = new System.Windows.Forms.Label();
            this.op_l = new System.Windows.Forms.Label();
            this.color_l = new System.Windows.Forms.Label();
            this.trackBarTHval = new System.Windows.Forms.Label();
            this.trackBarOPval = new System.Windows.Forms.Label();
            this.trackBarTH = new System.Windows.Forms.TrackBar();
            this.trackBarOP = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(535, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.AutoSize = false;
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.exitMenu});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(112, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(112, 22);
            this.openMenu.Text = "Open...";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(112, 22);
            this.saveMenu.Text = "Save...";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(112, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.th_l);
            this.panel1.Controls.Add(this.op_l);
            this.panel1.Controls.Add(this.color_l);
            this.panel1.Controls.Add(this.trackBarTHval);
            this.panel1.Controls.Add(this.trackBarOPval);
            this.panel1.Controls.Add(this.trackBarTH);
            this.panel1.Controls.Add(this.trackBarOP);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 52);
            this.panel1.TabIndex = 1;
            // 
            // th_l
            // 
            this.th_l.AutoSize = true;
            this.th_l.BackColor = System.Drawing.Color.White;
            this.th_l.Location = new System.Drawing.Point(326, 35);
            this.th_l.Name = "th_l";
            this.th_l.Size = new System.Drawing.Size(56, 13);
            this.th_l.TabIndex = 6;
            this.th_l.Text = "Thickness";
            // 
            // op_l
            // 
            this.op_l.AutoSize = true;
            this.op_l.BackColor = System.Drawing.Color.White;
            this.op_l.Location = new System.Drawing.Point(77, 35);
            this.op_l.Name = "op_l";
            this.op_l.Size = new System.Drawing.Size(43, 13);
            this.op_l.TabIndex = 5;
            this.op_l.Text = "Opacity";
            // 
            // color_l
            // 
            this.color_l.BackColor = System.Drawing.Color.Turquoise;
            this.color_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_l.Location = new System.Drawing.Point(494, 11);
            this.color_l.Name = "color_l";
            this.color_l.Size = new System.Drawing.Size(25, 23);
            this.color_l.TabIndex = 0;
            this.color_l.Click += new System.EventHandler(this.color_l_Click);
            // 
            // trackBarTHval
            // 
            this.trackBarTHval.AutoSize = true;
            this.trackBarTHval.Location = new System.Drawing.Point(448, 21);
            this.trackBarTHval.Name = "trackBarTHval";
            this.trackBarTHval.Size = new System.Drawing.Size(13, 13);
            this.trackBarTHval.TabIndex = 4;
            this.trackBarTHval.Text = "0";
            // 
            // trackBarOPval
            // 
            this.trackBarOPval.AutoSize = true;
            this.trackBarOPval.Location = new System.Drawing.Point(199, 21);
            this.trackBarOPval.Name = "trackBarOPval";
            this.trackBarOPval.Size = new System.Drawing.Size(13, 13);
            this.trackBarOPval.TabIndex = 3;
            this.trackBarOPval.Text = "0";
            // 
            // trackBarTH
            // 
            this.trackBarTH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarTH.Location = new System.Drawing.Point(260, 3);
            this.trackBarTH.Maximum = 100;
            this.trackBarTH.Name = "trackBarTH";
            this.trackBarTH.Size = new System.Drawing.Size(182, 45);
            this.trackBarTH.TabIndex = 2;
            this.trackBarTH.TickFrequency = 10;
            this.trackBarTH.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarOP
            // 
            this.trackBarOP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarOP.LargeChange = 10;
            this.trackBarOP.Location = new System.Drawing.Point(11, 3);
            this.trackBarOP.Maximum = 255;
            this.trackBarOP.Name = "trackBarOP";
            this.trackBarOP.Size = new System.Drawing.Size(182, 45);
            this.trackBarOP.TabIndex = 1;
            this.trackBarOP.TickFrequency = 17;
            this.trackBarOP.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(0, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 217);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(532, 292);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarTH;
        private System.Windows.Forms.TrackBar trackBarOP;
        private System.Windows.Forms.Label color_l;
        private System.Windows.Forms.Label th_l;
        private System.Windows.Forms.Label op_l;
        private System.Windows.Forms.Label trackBarTHval;
        private System.Windows.Forms.Label trackBarOPval;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

