using Bankclasslibrary;

// Normal Account
Account account = new Account("Sarag Cooper", "15-16-23", "1234 5555 1111 1211", 1000);
account.DisplayAccountDetails();
account.Deposit(600);
account.Withdraw(100);
Console.WriteLine(account);

// OverDraftAccount
OverDraftAccount overdraft = new OverDraftAccount("Jerry Paul", "22-66-55", "2612 2222 3333 4444", 1500);
overdraft.DisplayAccountDetails();
overdraft.Withdraw(1800);  // within overdraft limit
overdraft.Withdraw(500);   // may hit overdraft limit
Console.WriteLine(overdraft);

Console.WriteLine("\nThank you for banking with LLoyds Bank!"); 