namespace _23.WorkWithControls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            showCurrentListToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            addNewMemberToolStripMenuItem = new ToolStripMenuItem();
            showCurrentListToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, booksToolStripMenuItem, membersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, showCurrentListToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(51, 20);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(180, 22);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // showCurrentListToolStripMenuItem
            // 
            showCurrentListToolStripMenuItem.Name = "showCurrentListToolStripMenuItem";
            showCurrentListToolStripMenuItem.Size = new Size(180, 22);
            showCurrentListToolStripMenuItem.Text = "Show Current List";
            showCurrentListToolStripMenuItem.Click += showCurrentListToolStripMenuItem_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewMemberToolStripMenuItem, showCurrentListToolStripMenuItem1 });
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(69, 20);
            membersToolStripMenuItem.Text = "Members";
            // 
            // addNewMemberToolStripMenuItem
            // 
            addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            addNewMemberToolStripMenuItem.Size = new Size(180, 22);
            addNewMemberToolStripMenuItem.Text = "Add New Member";
            addNewMemberToolStripMenuItem.Click += addNewMemberToolStripMenuItem_Click;
            // 
            // showCurrentListToolStripMenuItem1
            // 
            showCurrentListToolStripMenuItem1.Name = "showCurrentListToolStripMenuItem1";
            showCurrentListToolStripMenuItem1.Size = new Size(180, 22);
            showCurrentListToolStripMenuItem1.Text = "Show Current List";
            showCurrentListToolStripMenuItem1.Click += showCurrentListToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem showCurrentListToolStripMenuItem;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem addNewMemberToolStripMenuItem;
        private ToolStripMenuItem showCurrentListToolStripMenuItem1;
    }
}