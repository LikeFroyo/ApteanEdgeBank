using System.Linq;


namespace ApteanEdgeBankDataLayer
{
    public class BranchDL
    {
        ApteanEdgeBankMasterDatabaseDataContext dbBank = new ApteanEdgeBankMasterDatabaseDataContext();
        public double GetBranchTotalBalance(int _branchID)
        {
            var branch = (from branchs in dbBank.ApteanBankBranches where branchs.BranchId == _branchID select branchs).First();
            return branch.TotalBalance;
        }
    }
}
