namespace WindowsFormsApplication2
{
    partial class FORMA
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
            this.bikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remuveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.openSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lvBike = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(609, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // bikeToolStripMenuItem
            // 
            this.bikeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.remuveToolStripMenuItem,
            this.tsSeparator,
            this.openSavedToolStripMenuItem});
            this.bikeToolStripMenuItem.Name = "bikeToolStripMenuItem";
            this.bikeToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bikeToolStripMenuItem.Text = "bike";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // remuveToolStripMenuItem
            // 
            this.remuveToolStripMenuItem.Name = "remuveToolStripMenuItem";
            this.remuveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.remuveToolStripMenuItem.Text = "remuve";
            this.remuveToolStripMenuItem.Click += new System.EventHandler(this.remuveToolStripMenuItem_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // openSavedToolStripMenuItem
            // 
            this.openSavedToolStripMenuItem.Name = "openSavedToolStripMenuItem";
            this.openSavedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openSavedToolStripMenuItem.Text = "open save";
            this.openSavedToolStripMenuItem.Click += new System.EventHandler(this.openSavedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.windowToolStripMenuItem.Text = "window";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvBike);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer.Size = new System.Drawing.Size(609, 296);
            this.splitContainer.SplitterDistance = 170;
            this.splitContainer.TabIndex = 2;
            // 
            // lvBike
            // 
            this.lvBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.lvBike.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size});
            this.lvBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBike.GridLines = true;
            this.lvBike.Location = new System.Drawing.Point(0, 0);
            this.lvBike.Name = "lvBike";
            this.lvBike.Size = new System.Drawing.Size(170, 296);
            this.lvBike.TabIndex = 0;
            this.lvBike.UseCompatibleStateImageBehavior = false;
            this.lvBike.View = System.Windows.Forms.View.Details;
            this.lvBike.SelectedIndexChanged += new System.EventHandler(this.lvBike_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // Size
            // 
            this.size.Text = "Size";
            // 
            // FORMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(609, 320);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(625, 359);
            this.Name = "FORMA";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMA_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORMA_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remuveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripMenuItem openSavedToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lvBike;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
    }
}

