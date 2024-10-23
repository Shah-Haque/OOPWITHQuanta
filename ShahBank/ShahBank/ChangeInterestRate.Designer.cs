namespace ShahBank
{
    partial class ChangeInterestRateFRM
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
            OK = new Button();
            Cancel_Button = new Button();
            InterestRate_Textbox = new TextBox();
            InterestRate_Label = new Label();
            SuspendLayout();
            // 
            // OK
            // 
            OK.DialogResult = DialogResult.OK;
            OK.Location = new Point(255, 103);
            OK.Name = "OK";
            OK.Size = new Size(75, 23);
            OK.TabIndex = 0;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(111, 103);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(75, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // InterestRate_Textbox
            // 
            InterestRate_Textbox.Location = new Point(111, 54);
            InterestRate_Textbox.Name = "InterestRate_Textbox";
            InterestRate_Textbox.Size = new Size(46, 23);
            InterestRate_Textbox.TabIndex = 2;
            // 
            // InterestRate_Label
            // 
            InterestRate_Label.AutoSize = true;
            InterestRate_Label.Location = new Point(30, 57);
            InterestRate_Label.Name = "InterestRate_Label";
            InterestRate_Label.Size = new Size(75, 15);
            InterestRate_Label.TabIndex = 3;
            InterestRate_Label.Text = "Interest Rate:";
            // 
            // ChangeInterestRateFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 151);
            Controls.Add(InterestRate_Label);
            Controls.Add(InterestRate_Textbox);
            Controls.Add(Cancel_Button);
            Controls.Add(OK);
            Name = "ChangeInterestRateFRM";
            Text = "Change Interest Rate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button OK;
        public Button Cancel_Button;
        public TextBox InterestRate_Textbox;
        public Label InterestRate_Label;
    }
}