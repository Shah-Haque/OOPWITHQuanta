namespace ShahBank
{
    partial class Frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            ok = new Button();
            quit = new Button();
            lstbox = new ListBox();
            Bank_Label = new Label();
            interestrate_label = new Label();
            NumberOfAccountsLabel = new Label();
            numberfield = new Label();
            TxtAccountInterestRate = new TextBox();
            ChangeInterestRateButton = new Button();
            SuspendLayout();
            // 
            // ok
            // 
            ok.Font = new Font("Segoe UI", 15.75F);
            ok.Location = new Point(673, 424);
            ok.Name = "ok";
            ok.Size = new Size(160, 40);
            ok.TabIndex = 0;
            ok.Text = "Test the Code";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // quit
            // 
            quit.Font = new Font("Segoe UI", 15.75F);
            quit.Location = new Point(37, 424);
            quit.Name = "quit";
            quit.Size = new Size(104, 40);
            quit.TabIndex = 1;
            quit.Text = "Quit";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // lstbox
            // 
            lstbox.Font = new Font("Segoe UI", 15.75F);
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 30;
            lstbox.Location = new Point(37, 131);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(796, 274);
            lstbox.TabIndex = 2;
            // 
            // Bank_Label
            // 
            Bank_Label.AutoSize = true;
            Bank_Label.Font = new Font("Segoe UI", 29F);
            Bank_Label.Location = new Point(65, 9);
            Bank_Label.Name = "Bank_Label";
            Bank_Label.Size = new Size(648, 52);
            Bank_Label.TabIndex = 3;
            Bank_Label.Text = "Welcome to Shah's Bank Application";
            // 
            // interestrate_label
            // 
            interestrate_label.AutoSize = true;
            interestrate_label.Font = new Font("Segoe UI", 12F);
            interestrate_label.Location = new Point(355, 64);
            interestrate_label.Name = "interestrate_label";
            interestrate_label.Size = new Size(218, 21);
            interestrate_label.TabIndex = 5;
            interestrate_label.Text = "Savings Account Interest Rate:";
            // 
            // NumberOfAccountsLabel
            // 
            NumberOfAccountsLabel.AutoSize = true;
            NumberOfAccountsLabel.Font = new Font("Segoe UI", 12F);
            NumberOfAccountsLabel.Location = new Point(487, 100);
            NumberOfAccountsLabel.Name = "NumberOfAccountsLabel";
            NumberOfAccountsLabel.Size = new Size(226, 21);
            NumberOfAccountsLabel.TabIndex = 7;
            NumberOfAccountsLabel.Text = "Total Number of Accounts held:";
            // 
            // numberfield
            // 
            numberfield.AutoSize = true;
            numberfield.Font = new Font("Segoe UI", 12F);
            numberfield.Location = new Point(740, 100);
            numberfield.Name = "numberfield";
            numberfield.Size = new Size(19, 21);
            numberfield.TabIndex = 8;
            numberfield.Text = "0";
            // 
            // TxtAccountInterestRate
            // 
            TxtAccountInterestRate.Location = new Point(579, 64);
            TxtAccountInterestRate.Name = "TxtAccountInterestRate";
            TxtAccountInterestRate.Size = new Size(97, 23);
            TxtAccountInterestRate.TabIndex = 9;
            // 
            // ChangeInterestRateButton
            // 
            ChangeInterestRateButton.Font = new Font("Segoe UI", 10F);
            ChangeInterestRateButton.Location = new Point(682, 64);
            ChangeInterestRateButton.Name = "ChangeInterestRateButton";
            ChangeInterestRateButton.Size = new Size(151, 33);
            ChangeInterestRateButton.TabIndex = 10;
            ChangeInterestRateButton.Text = "Change Interest Rate";
            ChangeInterestRateButton.UseVisualStyleBackColor = true;
            ChangeInterestRateButton.Click += ChangeInterestRateButton_Click;
            // 
            // Frmmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(864, 572);
            Controls.Add(ChangeInterestRateButton);
            Controls.Add(TxtAccountInterestRate);
            Controls.Add(numberfield);
            Controls.Add(NumberOfAccountsLabel);
            Controls.Add(interestrate_label);
            Controls.Add(Bank_Label);
            Controls.Add(lstbox);
            Controls.Add(quit);
            Controls.Add(ok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frmmain";
            Text = "Shah's bank";
            Load += Frmmain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private Button quit;
        private ListBox lstbox;
        private Label Bank_Label;
        private Label interestrate_label;
        private Label NumberOfAccountsLabel;
        private Label numberfield;
        private TextBox TxtAccountInterestRate;
        private Button ChangeInterestRateButton;
    }
}
