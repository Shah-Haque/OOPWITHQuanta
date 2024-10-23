namespace ShahBank
{
    partial class SunshineBank
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
            Current_Listbox = new ListBox();
            Savings_Listbox = new ListBox();
            loadbutton = new Button();
            Quit_Button = new Button();
            CustomerNameTextbox = new TextBox();
            AccountTypeTextbox = new TextBox();
            BalanceTextbox = new TextBox();
            CustomerNameLabel = new Label();
            AccountType_Label = new Label();
            Balance_Label = new Label();
            AccountNumber_Label = new Label();
            Current_Label = new Label();
            Savings_Label = new Label();
            InterestRate_Button = new Button();
            OverDraftLimit_Textbox = new TextBox();
            InterestRate_Textbox = new TextBox();
            OverdraftLimit_Label = new Label();
            InterestRate_Label = new Label();
            AccountNumber_TextBox = new TextBox();
            TotalSaving_Textbox = new TextBox();
            TotalSaving_Label = new Label();
            TotalCurrentLabel = new Label();
            TotalCurrent_Textbox = new TextBox();
            SuspendLayout();
            // 
            // Current_Listbox
            // 
            Current_Listbox.FormattingEnabled = true;
            Current_Listbox.ItemHeight = 15;
            Current_Listbox.Location = new Point(12, 49);
            Current_Listbox.Name = "Current_Listbox";
            Current_Listbox.Size = new Size(140, 379);
            Current_Listbox.TabIndex = 0;
            Current_Listbox.SelectedIndexChanged += Current_Listbox_SelectedIndexChanged;
            // 
            // Savings_Listbox
            // 
            Savings_Listbox.FormattingEnabled = true;
            Savings_Listbox.ItemHeight = 15;
            Savings_Listbox.Location = new Point(648, 49);
            Savings_Listbox.Name = "Savings_Listbox";
            Savings_Listbox.Size = new Size(140, 379);
            Savings_Listbox.TabIndex = 1;
            Savings_Listbox.SelectedIndexChanged += Savings_Listbox_SelectedIndexChanged;
            // 
            // loadbutton
            // 
            loadbutton.Location = new Point(648, 454);
            loadbutton.Name = "loadbutton";
            loadbutton.Size = new Size(140, 44);
            loadbutton.TabIndex = 2;
            loadbutton.Text = "Load from database";
            loadbutton.UseVisualStyleBackColor = true;
            loadbutton.Click += loadbutton_Click;
            // 
            // Quit_Button
            // 
            Quit_Button.Location = new Point(12, 454);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(140, 44);
            Quit_Button.TabIndex = 3;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = true;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // CustomerNameTextbox
            // 
            CustomerNameTextbox.Location = new Point(352, 151);
            CustomerNameTextbox.Name = "CustomerNameTextbox";
            CustomerNameTextbox.Size = new Size(205, 23);
            CustomerNameTextbox.TabIndex = 4;
            // 
            // AccountTypeTextbox
            // 
            AccountTypeTextbox.Location = new Point(352, 191);
            AccountTypeTextbox.Name = "AccountTypeTextbox";
            AccountTypeTextbox.Size = new Size(205, 23);
            AccountTypeTextbox.TabIndex = 5;
            // 
            // BalanceTextbox
            // 
            BalanceTextbox.Location = new Point(352, 232);
            BalanceTextbox.Name = "BalanceTextbox";
            BalanceTextbox.Size = new Size(205, 23);
            BalanceTextbox.TabIndex = 6;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(249, 151);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(97, 15);
            CustomerNameLabel.TabIndex = 7;
            CustomerNameLabel.Text = "Customer Name:";
            // 
            // AccountType_Label
            // 
            AccountType_Label.AutoSize = true;
            AccountType_Label.Location = new Point(264, 191);
            AccountType_Label.Name = "AccountType_Label";
            AccountType_Label.Size = new Size(82, 15);
            AccountType_Label.TabIndex = 8;
            AccountType_Label.Text = "Account Type:";
            // 
            // Balance_Label
            // 
            Balance_Label.AutoSize = true;
            Balance_Label.Location = new Point(286, 232);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(51, 15);
            Balance_Label.TabIndex = 9;
            Balance_Label.Text = "Balance:";
            // 
            // AccountNumber_Label
            // 
            AccountNumber_Label.AutoSize = true;
            AccountNumber_Label.Location = new Point(249, 102);
            AccountNumber_Label.Name = "AccountNumber_Label";
            AccountNumber_Label.Size = new Size(102, 15);
            AccountNumber_Label.TabIndex = 10;
            AccountNumber_Label.Text = "Account Number:";
            // 
            // Current_Label
            // 
            Current_Label.AutoSize = true;
            Current_Label.Location = new Point(12, 20);
            Current_Label.Name = "Current_Label";
            Current_Label.Size = new Size(47, 15);
            Current_Label.TabIndex = 11;
            Current_Label.Text = "Current";
            // 
            // Savings_Label
            // 
            Savings_Label.AutoSize = true;
            Savings_Label.Location = new Point(668, 20);
            Savings_Label.Name = "Savings_Label";
            Savings_Label.Size = new Size(47, 15);
            Savings_Label.TabIndex = 12;
            Savings_Label.Text = "Savings";
            // 
            // InterestRate_Button
            // 
            InterestRate_Button.Location = new Point(322, 455);
            InterestRate_Button.Name = "InterestRate_Button";
            InterestRate_Button.Size = new Size(140, 44);
            InterestRate_Button.TabIndex = 13;
            InterestRate_Button.Text = "Change Interest Rate";
            InterestRate_Button.UseVisualStyleBackColor = true;
            InterestRate_Button.Click += InterestRate_Button_Click;
            // 
            // OverDraftLimit_Textbox
            // 
            OverDraftLimit_Textbox.Location = new Point(352, 282);
            OverDraftLimit_Textbox.Name = "OverDraftLimit_Textbox";
            OverDraftLimit_Textbox.Size = new Size(205, 23);
            OverDraftLimit_Textbox.TabIndex = 14;
            // 
            // InterestRate_Textbox
            // 
            InterestRate_Textbox.Location = new Point(352, 322);
            InterestRate_Textbox.Name = "InterestRate_Textbox";
            InterestRate_Textbox.Size = new Size(205, 23);
            InterestRate_Textbox.TabIndex = 15;
            // 
            // OverdraftLimit_Label
            // 
            OverdraftLimit_Label.AutoSize = true;
            OverdraftLimit_Label.Location = new Point(259, 282);
            OverdraftLimit_Label.Name = "OverdraftLimit_Label";
            OverdraftLimit_Label.Size = new Size(87, 15);
            OverdraftLimit_Label.TabIndex = 16;
            OverdraftLimit_Label.Text = "Overdraft Limit";
            // 
            // InterestRate_Label
            // 
            InterestRate_Label.AutoSize = true;
            InterestRate_Label.Location = new Point(259, 325);
            InterestRate_Label.Name = "InterestRate_Label";
            InterestRate_Label.Size = new Size(72, 15);
            InterestRate_Label.TabIndex = 17;
            InterestRate_Label.Text = "Interest Rate";
            // 
            // AccountNumber_TextBox
            // 
            AccountNumber_TextBox.Location = new Point(357, 102);
            AccountNumber_TextBox.Name = "AccountNumber_TextBox";
            AccountNumber_TextBox.Size = new Size(205, 23);
            AccountNumber_TextBox.TabIndex = 18;
            // 
            // TotalSaving_Textbox
            // 
            TotalSaving_Textbox.Location = new Point(578, 369);
            TotalSaving_Textbox.Name = "TotalSaving_Textbox";
            TotalSaving_Textbox.Size = new Size(47, 23);
            TotalSaving_Textbox.TabIndex = 19;
            TotalSaving_Textbox.Text = "0";
            // 
            // TotalSaving_Label
            // 
            TotalSaving_Label.AutoSize = true;
            TotalSaving_Label.Location = new Point(490, 372);
            TotalSaving_Label.Name = "TotalSaving_Label";
            TotalSaving_Label.Size = new Size(73, 15);
            TotalSaving_Label.TabIndex = 20;
            TotalSaving_Label.Text = "Total Saving:";
            // 
            // TotalCurrentLabel
            // 
            TotalCurrentLabel.AutoSize = true;
            TotalCurrentLabel.Location = new Point(216, 372);
            TotalCurrentLabel.Name = "TotalCurrentLabel";
            TotalCurrentLabel.Size = new Size(78, 15);
            TotalCurrentLabel.TabIndex = 22;
            TotalCurrentLabel.Text = "Total Current:";
            // 
            // TotalCurrent_Textbox
            // 
            TotalCurrent_Textbox.Location = new Point(304, 369);
            TotalCurrent_Textbox.Name = "TotalCurrent_Textbox";
            TotalCurrent_Textbox.Size = new Size(47, 23);
            TotalCurrent_Textbox.TabIndex = 21;
            TotalCurrent_Textbox.Text = "0";
            // 
            // SunshineBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(TotalCurrentLabel);
            Controls.Add(TotalCurrent_Textbox);
            Controls.Add(TotalSaving_Label);
            Controls.Add(TotalSaving_Textbox);
            Controls.Add(AccountNumber_TextBox);
            Controls.Add(InterestRate_Label);
            Controls.Add(OverdraftLimit_Label);
            Controls.Add(InterestRate_Textbox);
            Controls.Add(OverDraftLimit_Textbox);
            Controls.Add(InterestRate_Button);
            Controls.Add(Savings_Label);
            Controls.Add(Current_Label);
            Controls.Add(AccountNumber_Label);
            Controls.Add(Balance_Label);
            Controls.Add(AccountType_Label);
            Controls.Add(CustomerNameLabel);
            Controls.Add(BalanceTextbox);
            Controls.Add(AccountTypeTextbox);
            Controls.Add(CustomerNameTextbox);
            Controls.Add(Quit_Button);
            Controls.Add(loadbutton);
            Controls.Add(Savings_Listbox);
            Controls.Add(Current_Listbox);
            Name = "SunshineBank";
            Text = "SunshineBank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Current_Listbox;
        private ListBox Savings_Listbox;
        private Button loadbutton;
        private Button Quit_Button;
        private TextBox CustomerNameTextbox;
        private TextBox AccountTypeTextbox;
        private TextBox BalanceTextbox;
        private Label CustomerNameLabel;
        private Label AccountType_Label;
        private Label Balance_Label;
        private Label AccountNumber_Label;
        private Label Current_Label;
        private Label Savings_Label;
        private Button InterestRate_Button;
        private TextBox OverDraftLimit_Textbox;
        private TextBox InterestRate_Textbox;
        private Label OverdraftLimit_Label;
        private Label InterestRate_Label;
        private TextBox AccountNumber_TextBox;
        private TextBox TotalSaving_Textbox;
        private Label TotalSaving_Label;
        private Label TotalCurrentLabel;
        private TextBox TotalCurrent_Textbox;
    }
}