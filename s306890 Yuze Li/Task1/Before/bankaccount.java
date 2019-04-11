
class BankAccount {
	private int accountAge;
	private int creditScore;
	private AccountInterest accountInterest;
	
	public BankAccount(int accountAge, int creditScore, AccountInterest accountInterest) {
		this.accountAge = accountAge;
		this.creditScore = creditScore;
		this.accountInterest = accountInterest;
	}
	
	public int getAccountAge() {
		return this.accountAge;
	}
	
	public int getCreditScore() {
		return this.creditScore;
	}
	
	public AccountInterest getAccountInterest() {
		return this.accountInterest;
	}
	
	public double calculateInterestRate() {
		if (this.creditScore > 800) {
			return 0.02;
		}
		
		if (this.accountAge > 10) {
			return 0.03;
		}
		
		return 0.05;
	}
}
 
class AccountInterest {
	private BankAccount account;
	
	public AccountInterest(BankAccount account) {
		this.account = account;
	}
	
	public BankAccount getAccount() {
		return this.account;
	}
	
	public double getInterestRate() {
		return account.calculateInterestRate();
	}
	
	public boolean isIntroductoryRate() {
		return (account.calculateInterestRate() < 0.05);
	}
}
