using System;
using System.Linq;


namespace ApteanEdgeBankDataLayer
{
    public class AccountDL
    {
        ApteanEdgeBankMasterDatabaseDataContext dbBank = new ApteanEdgeBankMasterDatabaseDataContext();
        ActivityDL activityDL = new ActivityDL();
        public Int64 GetNewAccountId()
        {
            Int64 newAccountId = (from account in dbBank.Accounts orderby account.CustomerId descending select account).First().AccountId + 1;
            return newAccountId;
        }
        public bool AddAccount(Int64 _customerId, DateTime _dateOpened, int _customerBranchID,int _accountType) 
        {
            try
            {
                var addAccount = new Account
                {
                    CustomerId = _customerId,
                    BranchId = _customerBranchID,
                    TotalBalance = 0,
                    AccountOpenedDate = _dateOpened,
                    AccountType = _accountType,
                    StatusAccount = true,
                };
                dbBank.Accounts.InsertOnSubmit(addAccount);
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Account GetAccountDetail(Int64 _accountId)
        {
            try
            {
                Account tmpAccount = (from account in dbBank.Accounts where account.AccountId == _accountId select account).First();
                return tmpAccount;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool AccountHandle(Int64 _accountId, bool _statusOfAccount)
        {
            try
            {
                Account updateAccount = (from account in dbBank.Accounts where account.AccountId == _accountId select account).First();
                updateAccount.StatusAccount = _statusOfAccount;
                dbBank.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void GenerateActivity(Int64 _accountId, double _amount)
        {
            var transActivity = new Activity
            {
                AccoutId = _accountId,
                TimeStamp = System.DateTime.Now,
                Amount = Math.Abs(_amount),
                ActivityCode = (_amount >= 0) ? true : false
            };
            dbBank.Activities.InsertOnSubmit(transActivity);
            dbBank.SubmitChanges();
        }

        public bool AccountCreditOrWithdraw(Int64 _accountId,double _amount)
        {
            try
            {
                var account = (from accounts in dbBank.Accounts where accounts.AccountId == _accountId select accounts).First();
                var branch = (from branchs in dbBank.ApteanBankBranches where branchs.BranchId == account.BranchId select branchs).First();
                account.TotalBalance += _amount;
                branch.TotalBalance += _amount;

                this.GenerateActivity( _accountId, _amount);
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Repay(Int64 _accountId,double _amount)
        {
            try
            {
                var account = (from accounts in dbBank.Accounts where accounts.AccountId == _accountId select accounts).First();
                var branch = (from branchs in dbBank.ApteanBankBranches where branchs.BranchId == account.BranchId select branchs).First();
                account.TotalBalance -= (_amount+_amount*0.1);
                branch.TotalBalance += _amount;

                this.GenerateActivity(_accountId, _amount);
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Issue(Int64 _accountId, double _amount)
        {
            try
            {
                var account = (from accounts in dbBank.Accounts where accounts.AccountId == _accountId select accounts).First();
                var branch = (from branchs in dbBank.ApteanBankBranches where branchs.BranchId == account.BranchId select branchs).First();
                account.TotalBalance += _amount;
                branch.TotalBalance -= _amount;

                this.GenerateActivity(_accountId, _amount);
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
