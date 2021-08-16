namespace VideoRentalProject_Gursharan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.addMoviesToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.viewMovieToolStripMenuItem,
            this.issueMovieToolStripMenuItem,
            this.returnMovieToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.addCustomerToolStripMenuItem.Text = "Add Customers";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addMoviesToolStripMenuItem
            // 
            this.addMoviesToolStripMenuItem.Name = "addMoviesToolStripMenuItem";
            this.addMoviesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.addMoviesToolStripMenuItem.Text = "Add Movies";
            this.addMoviesToolStripMenuItem.Click += new System.EventHandler(this.addMoviesToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // viewMovieToolStripMenuItem
            // 
            this.viewMovieToolStripMenuItem.Name = "viewMovieToolStripMenuItem";
            this.viewMovieToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.viewMovieToolStripMenuItem.Text = "View Movie";
            this.viewMovieToolStripMenuItem.Click += new System.EventHandler(this.viewMovieToolStripMenuItem_Click);
            // 
            // issueMovieToolStripMenuItem
            // 
            this.issueMovieToolStripMenuItem.Name = "issueMovieToolStripMenuItem";
            this.issueMovieToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.issueMovieToolStripMenuItem.Text = "Issue Movie";
            this.issueMovieToolStripMenuItem.Click += new System.EventHandler(this.issueMovieToolStripMenuItem_Click);
            // 
            // returnMovieToolStripMenuItem
            // 
            this.returnMovieToolStripMenuItem.Name = "returnMovieToolStripMenuItem";
            this.returnMovieToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.returnMovieToolStripMenuItem.Text = "Return Movie";
            this.returnMovieToolStripMenuItem.Click += new System.EventHandler(this.returnMovieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 24);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Movies Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

