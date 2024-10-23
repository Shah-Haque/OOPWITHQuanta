using ShahBankLibrary.Objects;

namespace ShahBank
{
    public partial class Frmmain : Form
    {
        private List<Current> CurrentList = new List<Current>();
        private List<Savings> SavingsList = new List<Savings>();


        public Frmmain()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            #region test code
            //Account A1 = new Account();
            //DisplayAccount(A1);
            //A1.CustomerName = "Joe Swanson";
            //A1.AccountNum = 54458;
            //DisplayAccount(A1);
            //A1.Deposit(800);
            //A1.Withdraw(844);
            //DisplayAccount(A1);

            //Account A2 = new Account();
            //Current C1 = new Current();
            //C1.Withdraw(300);


            //A2.CustomerName = "Tim Corey";
            //A2.AccountNum = 5433458;
            //DisplayAccount(A2);
            //A2.Deposit(800);
            //A2.Withdraw(34);
            //DisplayAccount(A2);


            //Account A3 = new Account("Charlotte", 23454, 600423);
            //DisplayAccount(A3);
            //A3.Deposit(800);
            //DisplayAccount(A3);
            //A3.Withdraw(34);
            //DisplayAccount(A3);

            //Current c1 = new Current();
            //c1.AccountNum = 101;
            //c1.CustomerName = "Mr Grinch";
            //c1.Deposit(500);
            //DisplayAccount(c1);
            //c1.Withdraw(450);
            //DisplayAccount(c1);
            //c1.Withdraw(530);
            //DisplayAccount(c1);

            //Current c2 = new Current();
            //c2.AccountNum = 102;
            //c2.CustomerName = "Shane Micheals";
            //c2.Deposit(500);
            //DisplayAccount(c2);

            //Savings s1 = new Savings();
            //s1.AccountNum = 101;
            //s1.CustomerName = "Mr Grinch";
            //s1.Deposit(500);
            //DisplayAccount(s1);

            //Savings s2 = new Savings();
            //s2.AccountNum = 102;
            //s1.CustomerName = "Shane Micheals";
            //s1.Deposit(500);
            //DisplayAccount(s1);

            //c1.OverdraftLimitExceeded += OverdraftLimitExceeded;
            //c2.OverdraftLimitExceeded -= OverdraftLimitExceeded
            #endregion

            Current c1 = new Current();
            CurrentList.Add(c1);
            c1.AccountNum = 101;
            c1.CustomerName = "menna finch";
            c1.OverdraftLimit = 100;
            c1.Deposit(500);

            Current c2 = new Current();
            CurrentList.Add(c2);
            c2.AccountNum = 102;
            c2.CustomerName = "ronnie smith";
            c2.Deposit(500);

            Savings s1 = new Savings();
            SavingsList.Add(s1);
            s1.AccountNum = 201;
            s1.CustomerName = "pete johnson";
            s1.Deposit(500);

            Savings s2 = new Savings();
            SavingsList.Add(s2);
            s2.AccountNum = 202;
            s2.CustomerName = "pete johnson";
            s2.Deposit(700);
            DisplayAccounts();




        }

        private void OverdraftLimitExceeded(Current sender)
        {
            MessageBox.Show
            (
                sender.CustomerName + " has exceeded his/her Overdraft limit. \n\t£10 charge",
                "Overdraft Limit Exceeded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void DisplayAccounts()
        {
            #region old code
            //lstbox.Items.Add
            //(
            //    thisAccount.AccountNum + " " + 
            //    thisAccount.CustomerName + " " + " " +
            //    thisAccount.GetBalance().ToString("C")
            //);

            //lstbox.Items.Add
            // (
            //    thisAccount.AccountNum + "   " + 
            //    thisAccount.CustomerName + "   " +
            //    thisAccount.GetBalance().ToString("C")
            // );else lstbox.Items.Add("Unknown Account Type");
            #endregion


            foreach (Current CurrentAccounts in CurrentList)
            {
                lstbox.Items.Add
                (
                    "CURRENT\t" + CurrentAccounts.AccountNum
                    + "\t" + CurrentAccounts.CustomerName
                    + "\t" + (CurrentAccounts.GetBalance()).ToString("C")
                    + "\t\t" + CurrentAccounts.OverdraftLimit.ToString("C")
                );

            }

            foreach (var SavingsAccounts in SavingsList)
            {
                lstbox.Items.Add
                (
                    "SAVINGS\t\t" + SavingsAccounts.AccountNum
                    + "\t" + SavingsAccounts.CustomerName
                    + "\t" + (SavingsAccounts.GetBalance()).ToString("C")
                    //+ "\t\t" + Savings.InterestRate.ToString() + "%"
                ); 
            }
            numberfield.Text = Account.NumberOfAccounts.ToString();
        }



        private void Frmmain_Load(object sender, EventArgs e)
        {
            TxtAccountInterestRate.Text = Savings.InterestRate.ToString() + "%";
        }

        private void ChangeInterestRateButton_Click(object sender, EventArgs e)
        {
            //ChangeInterestRate interestRate = new ChangeInterestRate();

            //if (interestRate.ShowDialog() == DialogResult.OK)
            //{
            //    Savings.InterestRate = double.Parse(interestRate.InterestRate_Textbox.Text)
            //}


            //if (frmmain.ShowDialog() == DialogResult.OK)
            //{
            //    Savings.InterestRate = double.Parse(frmmain.InterestRate_Textbox.Text);
            //    TxtAccountInterestRate.Text = Savings.InterestRate.ToString();
            //}
        }



    }
}
