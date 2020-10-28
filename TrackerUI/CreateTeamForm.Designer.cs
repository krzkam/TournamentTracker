namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.newMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deteleSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.newMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 19);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.createTeamLabel.TabIndex = 2;
            this.createTeamLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(16, 87);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(124, 30);
            this.teamNameLabel.TabIndex = 10;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teamNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameValue.Location = new System.Drawing.Point(21, 120);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(355, 35);
            this.teamNameValue.TabIndex = 11;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addMemberButton.Location = new System.Drawing.Point(22, 248);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(354, 39);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(22, 200);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(354, 29);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(17, 167);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // newMemberGroupBox
            // 
            this.newMemberGroupBox.Controls.Add(this.createMemberButton);
            this.newMemberGroupBox.Controls.Add(this.cellPhoneValue);
            this.newMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.newMemberGroupBox.Controls.Add(this.emailValue);
            this.newMemberGroupBox.Controls.Add(this.emailLabel);
            this.newMemberGroupBox.Controls.Add(this.lastNameValue);
            this.newMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.newMemberGroupBox.Controls.Add(this.firstNameValue);
            this.newMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.newMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newMemberGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.newMemberGroupBox.Location = new System.Drawing.Point(21, 305);
            this.newMemberGroupBox.Name = "newMemberGroupBox";
            this.newMemberGroupBox.Size = new System.Drawing.Size(403, 267);
            this.newMemberGroupBox.TabIndex = 20;
            this.newMemberGroupBox.TabStop = false;
            this.newMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createMemberButton.Location = new System.Drawing.Point(42, 208);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(313, 39);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cellPhoneValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellPhoneValue.Location = new System.Drawing.Point(155, 167);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(200, 35);
            this.cellPhoneValue.TabIndex = 28;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cellPhoneLabel.Location = new System.Drawing.Point(37, 167);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(72, 30);
            this.cellPhoneLabel.TabIndex = 27;
            this.cellPhoneLabel.Text = "Phone";
            // 
            // emailValue
            // 
            this.emailValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailValue.Location = new System.Drawing.Point(155, 127);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(200, 35);
            this.emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.emailLabel.Location = new System.Drawing.Point(37, 127);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameValue.Location = new System.Drawing.Point(155, 86);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(200, 35);
            this.lastNameValue.TabIndex = 24;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(37, 86);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameValue.Location = new System.Drawing.Point(155, 45);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(200, 35);
            this.firstNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(36, 48);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(436, 120);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(293, 452);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deteleSelectedMemberButton
            // 
            this.deteleSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deteleSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deteleSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.deteleSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deteleSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deteleSelectedMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.deteleSelectedMemberButton.Location = new System.Drawing.Point(762, 305);
            this.deteleSelectedMemberButton.Name = "deteleSelectedMemberButton";
            this.deteleSelectedMemberButton.Size = new System.Drawing.Size(130, 78);
            this.deteleSelectedMemberButton.TabIndex = 22;
            this.deteleSelectedMemberButton.Text = "Delete Selected";
            this.deteleSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTeamButton.Location = new System.Drawing.Point(290, 607);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(221, 39);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
             
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 681);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deteleSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.newMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Create Team";
            this.newMemberGroupBox.ResumeLayout(false);
            this.newMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox newMemberGroupBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deteleSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}