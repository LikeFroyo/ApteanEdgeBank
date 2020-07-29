using System;
using System.Linq;
using System.Data.Linq.SqlClient;

namespace ApteanEdgeBankDataLayer
{
    public class CustomerDL
    {
        ApteanEdgeBankMasterDatabaseDataContext dbBank = new ApteanEdgeBankMasterDatabaseDataContext();

        //GetNewCustomerID
        public Int64 GetNewCustomerId()
        {
            Int64 newCustomerId = (from customer in dbBank.Customers orderby customer.CustomerId descending select customer).First().CustomerId + 1;
            return newCustomerId;
        }

        //Addition Of New Customer
        public bool AddCustomer(string _customerName, DateTime _dateOpened, int _customerBranchID)
        {
            try
            {
                var addCustomer = new Customer
                {
                    CustomerName = _customerName,
                    DateOpened = _dateOpened,
                    customerBranchId = _customerBranchID
                };

                dbBank.Customers.InsertOnSubmit(addCustomer);
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //GetCustomerDetail
        public Customer GetCustomerDetail(Int64 _customerId)
        {
            try
            {
                Customer tmpCustomer = (from customer in dbBank.Customers where customer.CustomerId == _customerId select customer).First();
                return tmpCustomer;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //UpdateCustomerID
        public bool UpdateCustomer(Int64 _customerId,string _customerName, DateTime _dateOpened, int _customerBranchID)
        {
            try
            {
                Customer updateCustomer = this.GetCustomerDetail(_customerId);
                updateCustomer.CustomerName = _customerName;
                updateCustomer.DateOpened = _dateOpened;
                updateCustomer.customerBranchId = _customerBranchID;
                dbBank.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        //Get All Customer In Bank
        public IQueryable<Customer> GetAllCustomer(string _customerName)
        {
            try
            {
                var customerList = from customer in dbBank.Customers where SqlMethods.Like(customer.CustomerName, _customerName + "%") select customer;
                return customerList;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IQueryable<Account> GetCustomerAccount(Int64 _customerId)
        {
            try
            {
                var customerAccounts = from account in dbBank.Accounts where account.CustomerId == _customerId && account.StatusAccount == true select account;
                return customerAccounts;
            }
            catch (Exception)
            {
                return null; 
            }
        }
    }
}

