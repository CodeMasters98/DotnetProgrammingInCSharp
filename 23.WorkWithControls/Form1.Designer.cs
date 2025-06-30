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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            showCurrentListToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            addNewMemberToolStripMenuItem = new ToolStripMenuItem();
            showCurrentListToolStripMenuItem1 = new ToolStripMenuItem();
            listView1 = new ListView();
            richTextBox1 = new RichTextBox();
            checkedListBox1 = new CheckedListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            addNewBookToolStripMenuItem.Size = new Size(167, 22);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // showCurrentListToolStripMenuItem
            // 
            showCurrentListToolStripMenuItem.Name = "showCurrentListToolStripMenuItem";
            showCurrentListToolStripMenuItem.Size = new Size(167, 22);
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
            // listView1
            // 
            listView1.Location = new Point(12, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(247, 97);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(282, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 164);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
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
        private ListView listView1;
        private RichTextBox richTextBox1;
        private CheckedListBox checkedListBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}