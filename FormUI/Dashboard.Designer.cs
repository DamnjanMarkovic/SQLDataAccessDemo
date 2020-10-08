namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAddressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNUmberText = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 51;
            this.peopleFoundListBox.Location = new System.Drawing.Point(56, 216);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(683, 106);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(319, 59);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(475, 56);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(47, 59);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(230, 51);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(250, 142);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(270, 54);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(421, 371);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(475, 56);
            this.firstNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // lastNameTextInsert
            // 
            this.lastNameTextInsert.Location = new System.Drawing.Point(421, 459);
            this.lastNameTextInsert.Name = "lastNameTextInsert";
            this.lastNameTextInsert.Size = new System.Drawing.Size(475, 56);
            this.lastNameTextInsert.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address";
            // 
            // emailAddressText
            // 
            this.emailAddressText.Location = new System.Drawing.Point(421, 549);
            this.emailAddressText.Name = "emailAddressText";
            this.emailAddressText.Size = new System.Drawing.Size(475, 56);
            this.emailAddressText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 51);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // phoneNUmberText
            // 
            this.phoneNUmberText.Location = new System.Drawing.Point(421, 645);
            this.phoneNUmberText.Name = "phoneNUmberText";
            this.phoneNUmberText.Size = new System.Drawing.Size(475, 56);
            this.phoneNUmberText.TabIndex = 10;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(250, 738);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(270, 54);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 844);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNUmberText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL data Access Demo";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailAddressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNUmberText;
        private System.Windows.Forms.Button insertButton;
    }
}

