namespace Graphics7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_l = new System.Windows.Forms.Label();
            this.trackBarOP = new System.Windows.Forms.TrackBar();
            this.trackBarTH = new System.Windows.Forms.TrackBar();
            this.op_val = new System.Windows.Forms.Label();
            this.th_val = new System.Windows.Forms.Label();
            this.op_l = new System.Windows.Forms.Label();
            this.th_l = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.AutoSize = false;
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.th_l);
            this.panel1.Controls.Add(this.op_l);
            this.panel1.Controls.Add(this.color_l);
            this.panel1.Controls.Add(this.th_val);
            this.panel1.Controls.Add(this.op_val);
            this.panel1.Controls.Add(this.trackBarTH);
            this.panel1.Controls.Add(this.trackBarOP);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 52);
            this.panel1.TabIndex = 1;
            // 
            // color_l
            // 
            this.color_l.BackColor = System.Drawing.Color.Turquoise;
            this.color_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_l.Location = new System.Drawing.Point(494, 11);
            this.color_l.Name = "color_l";
            this.color_l.Size = new System.Drawing.Size(25, 23);
            this.color_l.TabIndex = 0;
            // 
            // trackBarOP
            // 
            this.trackBarOP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarOP.Location = new System.Drawing.Point(11, 3);
            this.trackBarOP.Maximum = 255;
            this.trackBarOP.Name = "trackBarOP";
            this.trackBarOP.Size = new System.Drawing.Size(182, 45);
            this.trackBarOP.TabIndex = 1;
            // 
            // trackBarTH
            // 
            this.trackBarTH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarTH.Location = new System.Drawing.Point(260, 3);
            this.trackBarTH.Maximum = 255;
            this.trackBarTH.Name = "trackBarTH";
            this.trackBarTH.Size = new System.Drawing.Size(182, 45);
            this.trackBarTH.TabIndex = 2;
            // 
            // op_val
            // 
            this.op_val.AutoSize = true;
            this.op_val.Location = new System.Drawing.Point(199, 21);
            this.op_val.Name = "op_val";
            this.op_val.Size = new System.Drawing.Size(13, 13);
            this.op_val.TabIndex = 3;
            this.op_val.Text = "0";
            // 
            // th_val
            // 
            this.th_val.AutoSize = true;
            this.th_val.Location = new System.Drawing.Point(448, 21);
            this.th_val.Name = "th_val";
            this.th_val.Size = new System.Drawing.Size(13, 13);
            this.th_val.TabIndex = 4;
            this.th_val.Text = "0";
            // 
            // op_l
            // 
            this.op_l.AutoSize = true;
            this.op_l.Location = new System.Drawing.Point(77, 35);
            this.op_l.Name = "op_l";
            this.op_l.Size = new System.Drawing.Size(43, 13);
            this.op_l.TabIndex = 5;
            this.op_l.Text = "Opacity";
            // 
            // th_l
            // 
            this.th_l.AutoSize = true;
            this.th_l.Location = new System.Drawing.Point(326, 35);
            this.th_l.Name = "th_l";
            this.th_l.Size = new System.Drawing.Size(56, 13);
            this.th_l.TabIndex = 6;
            this.th_l.Text = "Thickness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(532, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarTH;
        private System.Windows.Forms.TrackBar trackBarOP;
        private System.Windows.Forms.Label color_l;
        private System.Windows.Forms.Label th_l;
        private System.Windows.Forms.Label op_l;
        private System.Windows.Forms.Label th_val;
        private System.Windows.Forms.Label op_val;
    }
}

