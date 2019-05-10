using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_ExtrctMethodObject
{
 public class Consumer
{
public AccountManager AccountManager { get; set; }

public Consumer(AccountManager accountManager)
{
AccountManager = accountManager;
}

 public void Get(int id)
 {
 Account account = AccountManager.GetAccount(id);
 }
 }

 public class AccountManager
 {
 public AccountDataProvider DataProvider { get; set; }

 public AccountManager(AccountDataProvider dataProvider)
 {
 DataProvider = dataProvider;
 }

 public Account GetAccount(int id)
 {
 return DataProvider.GetAccount(id);
 }
 }

 public class AccountDataProvider
 {
 public Account GetAccount(int id)
 {
 // get account
 }
 }
}
