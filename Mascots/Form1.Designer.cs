namespace Mascots
{
    partial class frmFunny
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblHeeHee = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.funnyBoysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maciekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tongoDrumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funnyBoysToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(448, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // lblHeeHee
            // 
            this.lblHeeHee.AutoSize = true;
            this.lblHeeHee.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeeHee.Location = new System.Drawing.Point(31, 91);
            this.lblHeeHee.Name = "lblHeeHee";
            this.lblHeeHee.Size = new System.Drawing.Size(127, 33);
            this.lblHeeHee.TabIndex = 1;
            this.lblHeeHee.Text = "HeeHee";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblHeeHee);
            this.groupBox.Location = new System.Drawing.Point(40, 77);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(370, 212);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // funnyBoysToolStripMenuItem
            // 
            this.funnyBoysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magnusToolStripMenuItem,
            this.danielToolStripMenuItem,
            this.maciekToolStripMenuItem,
            this.tongoDrumpToolStripMenuItem});
            this.funnyBoysToolStripMenuItem.Name = "funnyBoysToolStripMenuItem";
            this.funnyBoysToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.funnyBoysToolStripMenuItem.Text = "Funny Boys";
            // 
            // magnusToolStripMenuItem
            // 
            this.magnusToolStripMenuItem.Name = "magnusToolStripMenuItem";
            this.magnusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.magnusToolStripMenuItem.Text = "Magnus";
            this.magnusToolStripMenuItem.Click += new System.EventHandler(this.magnusToolStripMenuItem_Click);
            // 
            // danielToolStripMenuItem
            // 
            this.danielToolStripMenuItem.Name = "danielToolStripMenuItem";
            this.danielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.danielToolStripMenuItem.Text = "Daniel";
            this.danielToolStripMenuItem.Click += new System.EventHandler(this.danielToolStripMenuItem_Click);
            // 
            // maciekToolStripMenuItem
            // 
            this.maciekToolStripMenuItem.Name = "maciekToolStripMenuItem";
            this.maciekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maciekToolStripMenuItem.Text = "Maciek";
            this.maciekToolStripMenuItem.Click += new System.EventHandler(this.maciekToolStripMenuItem_Click);
            // 
            // tongoDrumpToolStripMenuItem
            // 
            this.tongoDrumpToolStripMenuItem.Name = "tongoDrumpToolStripMenuItem";
            this.tongoDrumpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tongoDrumpToolStripMenuItem.Text = "Tongo Drump";
            this.tongoDrumpToolStripMenuItem.Click += new System.EventHandler(this.tongoDrumpToolStripMenuItem_Click);
            // 
            // frmFunny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 391);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmFunny";
            this.Text = "Good Times";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem funnyBoysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magnusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maciekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tongoDrumpToolStripMenuItem;
        private System.Windows.Forms.Label lblHeeHee;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

