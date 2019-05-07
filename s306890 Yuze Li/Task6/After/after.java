public class Consumer
    {
        public AccountDataProvider AccountDataProvider { get; set; }

        public Consumer(AccountDataProvider dataProvider)
        {
            AccountDataProvider = dataProvider;
        }

        public void Get(int id)
        {
            Account account = AccountDataProvider.GetAccount(id);
        }
    }

    public class AccountDataProvider
    {
        public Account GetAccount(int id)
        {
            // get account
        }
    }