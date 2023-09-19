namespace _23.WorkWithControls.Forms.Member
{
    partial class AddMember
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
            birthDateTimePicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            firstNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(98, 73);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(195, 23);
            birthDateTimePicker.TabIndex = 0;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(98, 104);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(195, 23);
            genderComboBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(98, 9);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(195, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 13);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 3;
            label1.Text = "نام: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "نام خانوادگی: ";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(98, 41);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(195, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 73);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "تاریخ تولد: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 104);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "جنسیت:";
            // 
            // button1
            // 
            button1.Location = new Point(98, 133);
            button1.Name = "button1";
            button1.Size = new Size(195, 28);
            button1.TabIndex = 8;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 293);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstNameTextBox);
            Controls.Add(genderComboBox);
            Controls.Add(birthDateTimePicker);
            Name = "AddMember";
            Text = "AddMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker birthDateTimePicker;
        private ComboBox genderComboBox;
        private TextBox firstNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}