using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
//D->Deposit
//W->Withdrawal
//-write a function that updates the balance depending upon the transaction type
	//-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance
 // function  Credit(int amount) 
	//-If transaction type is withdraw call the function debit by passing the amount to be withdrawn and update the balance
  //Debit(int amt) function
//- Pass the other information like Acount no, customer name, acc type through constructor
//-write and call the show data method to display the values.

namespace Assignment_3
{
    public class Accounts
    {
        public int accountNo;
        public String customerName;
        public String accountType;
        public String transactionType;
        public double amount;
        public double balance;

        public Accounts(int accountNo,String customerName,String accountType,String transactionType,double amount,double balance)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public static void credit(double amount)
        {
             if(amount > 0)
            {
                
            }
        }

        public static void transactionTypes(String transactionType )
        {
            if(transactionType == "deposit")
            {

            }
        }
    }
}
