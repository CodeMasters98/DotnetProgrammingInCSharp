namespace _03_2.ShowCollectionInWindowsFormApplication
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
            this.PeopleGridView = new System.Windows.Forms.DataGridView();
            this.FisrtNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleGridView
            // 
            this.PeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridView.Location = new System.Drawing.Point(12, 198);
            this.PeopleGridView.Name = "PeopleGridView";
            this.PeopleGridView.RowTemplate.Height = 25;
            this.PeopleGridView.Size = new System.Drawing.Size(331, 191);
            this.PeopleGridView.TabIndex = 0;
            // 
            // FisrtNameTextBox
            // 
            this.FisrtNameTextBox.Location = new System.Drawing.Point(93, 12);
            this.FisrtNameTextBox.Name = "FisrtNameTextBox";
            this.FisrtNameTextBox.Size = new System.Drawing.Size(248, 23);
            this.FisrtNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(93, 57);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(248, 23);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(93, 102);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(248, 23);
            this.AgeTextBox.TabIndex = 3;
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Location = new System.Drawing.Point(23, 15);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(64, 15);
            this.FirstNamelbl.TabIndex = 4;
            this.FirstNamelbl.Text = "FirstName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNamelbl);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FisrtNameTextBox);
            this.Controls.Add(this.PeopleGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PeopleGridView;
        private TextBox FisrtNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox AgeTextBox;
        private Label FirstNamelbl;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}