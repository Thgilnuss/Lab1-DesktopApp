namespace Lab1_Bai2_NguyenVanMinhHai
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
            this.nguyễnVănMinhHảiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnVănMinhHảiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnVănMinhHảiToolStripMenuItem
            // 
            this.nguyễnVănMinhHảiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baiToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem,
            this.bài4ToolStripMenuItem});
            this.nguyễnVănMinhHảiToolStripMenuItem.Name = "nguyễnVănMinhHảiToolStripMenuItem";
            this.nguyễnVănMinhHảiToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.nguyễnVănMinhHảiToolStripMenuItem.Text = "Nguyễn Văn Minh Hải";
            this.nguyễnVănMinhHảiToolStripMenuItem.Click += new System.EventHandler(this.nguyễnVănMinhHảiToolStripMenuItem_Click);
            // 
            // baiToolStripMenuItem
            // 
            this.baiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baiToolStripMenuItem.Image")));
            this.baiToolStripMenuItem.Name = "baiToolStripMenuItem";
            this.baiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baiToolStripMenuItem.Text = "Bài 1";
            this.baiToolStripMenuItem.Click += new System.EventHandler(this.baiToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài2ToolStripMenuItem.Image")));
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài3ToolStripMenuItem.Image")));
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài4ToolStripMenuItem.Image")));
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnVănMinhHảiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
    }
}

