using ShahBankLibrary.Objects;

namespace ShahBank
{
    public partial class SunshineBank : Form
    {
        private SortedDictionary<int, Current> CurrentList = new SortedDictionary<int, Current>();
        private SortedDictionary<int, Savings> SavingsList = new SortedDictionary<int, Savings>();

        Random random = new Random();

        public SunshineBank()
        {
            InitializeComponent();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            CurrentList.Clear();
            SavingsList.Clear();

            Current c1 = new Current();
            CurrentList.Add(c1.AccountNum, c1);

            Current c2 = new Current(101, "menna finch", 500, 250);
            CurrentList.Add(c2.AccountNum, c2);

            Current c3 = new Current(102, "rowan finch", 500, 300);
            CurrentList.Add(c3.AccountNum, c3);

            for (int i = 103; i < 200; i++)
            {
                Current c = new Current(i, "Mr " + i.ToString(), random.Next(1000) - 200, i + 100);
                CurrentList.Add(c.AccountNum, c);
            }

            Savings s1 = new Savings();
            SavingsList.Add(s1.AccountNum, s1);

            Savings s2 = new Savings(201, "annie benning", 600);
            SavingsList.Add(s2.AccountNum, s2);

            s2.Withdraw(100);

            Savings s3 = new Savings(202, "bobby smith", 900);
            SavingsList.Add(s3.AccountNum, s3);

            for (int i = 203; i < 300; i++)
            {
                Savings s = new Savings(i, "Mr " + i.ToString(), random.Next(5000));
                SavingsList.Add(s.AccountNum, s);
            }

            DisplayAccountNumbers();
        }

        private void DisplayAccountNumbers()
        {
            foreach (KeyValuePair<int, Current> kvp in CurrentList)
            {
                Current_Listbox.Items.Add(kvp.Value.AccountNum);
            }

            foreach (var kvp in SavingsList)
            {
                Savings_Listbox.Items.Add(kvp.Key);
            }
        }

        private void Current_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region oldcode
            //if (Current_Listbox.SelectedItems != null)
            //{
            //    int key = (int)Current_Listbox.SelectedItem;
            //    Current thisAccount = CurrentList[key];

            //    AccountTypeTextbox.Text = "Current";
            //    AccountNumber_TextBox.Text = thisAccount.AccountNum.ToString();
            //    CustomerNameTextbox.Text = thisAccount.CustomerName.ToString();
            //    BalanceTextbox.Text = thisAccount.GetBalance().ToString("c");
            //    OverDraftLimit_Textbox.Text = thisAccount.OverdraftLimit.ToString("c");
            //    InterestRate_Textbox.Text = "N/A";
            //}
            #endregion

            Current thisAccount;
            int key = (int)Current_Listbox.SelectedItem;
            thisAccount = CurrentList[key];
            AccountTypeTextbox.Text = "Current";
            AccountNumber_Label.Text = thisAccount.AccountNum.ToString();
            CustomerNameTextbox.Text = thisAccount.CustomerName;
            BalanceTextbox.Text = thisAccount.GetBalance().ToString("c");
            OverDraftLimit_Textbox.Text = thisAccount.OverdraftLimit.ToString("c");
            InterestRate_Textbox.Text = "N/A";
           
        }

        private void Savings_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Savings thisAccount;
            thisAccount = SavingsList[(int)Savings_Listbox.SelectedItem];
            AccountTypeTextbox.Text = "Savings";
            AccountNumber_TextBox.Text = thisAccount.AccountNum.ToString();
            CustomerNameTextbox.Text = thisAccount.CustomerName;
            BalanceTextbox.Text = thisAccount.GetBalance().ToString("c");
            OverDraftLimit_Textbox.Text = "N/A";
            InterestRate_Textbox.Text = Savings.InterestRate.ToString() + "%";
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InterestRate_Button_Click(object sender, EventArgs e)
        {
            ChangeInterestRateFRM f1 = new ChangeInterestRateFRM();

            if (f1.ShowDialog() == DialogResult.OK)
            {
                Savings.InterestRate = double.Parse(f1.InterestRate_Textbox.Text);
                TotalSaving_Textbox.Text = Savings.InterestRate.ToString("c");
            }
        }

       
    }
}
