using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Banking
    {
        static void Main(string[] args)
        {
            int option = 0;
            int id=100;
            int furtherOption = 0;
            string name;
            List<Bank> BankObj = new List<Bank>();
            List<AccHolder> PersonObj = new List<AccHolder>();
            Bank ObBank = new Bank();
            AccHolder ObPerson = new AccHolder();
            int found = 0;
            while (option != 3)
            {
                Console.WriteLine("Press 1 to create a new account.\nPress 2 to access an existing account\nPress 3 to exit");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    ObBank.SetAccountId(id);
                    ObPerson.SetAccHolderId(id);
                    Console.WriteLine("Your Account no is {0}", id);
                    id++;
                    Console.WriteLine("Enter Account Type: S for savings, D for dmat and C for current");
                    ObBank.setAccountType(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine("Enter name of holder");
                    ObPerson.name = Console.ReadLine();
                    Console.WriteLine("Enter deposit money");
                    ObBank.Balance = float.Parse(Console.ReadLine());
                    BankObj.Add(ObBank);
                    PersonObj.Add(ObPerson);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter your account no");
                    ObBank.SetAccountId(int.Parse(Console.ReadLine()));
                    int accno = ObBank.GetAccountId();
                    
                    for (int i=0;i<BankObj.Count;i++)
                    {
                        if(accno==BankObj[i].GetAccountId())
                        {
                            found = 1;
                        }
                    }
                    

                    if (found==1)
                    {
                        while (furtherOption != 3)
                        {
                            var person = PersonObj.Find(x => x.GetAccHolderId() == accno);
                        var account = BankObj.Find(x => x.GetAccountId() == accno);
                        Console.WriteLine("Name: {0}\nAccount ID: {1}\nAccount Type: {2}\nBalance: {3}\nInterest:{4}", person.name,account.GetAccountId(),account.getAccountType(),account.Balance,account.CalculateInterest());
                        Console.WriteLine("Press 1 if you want to withdraw\nPress 2 to deposit\nPress 3 to exit");
                        
                        
                            furtherOption = int.Parse(Console.ReadLine());
                            if (furtherOption == 1)
                            {
                                Console.WriteLine("Enter amount you want to withdraw:");
                                account.withdraw(int.Parse(Console.ReadLine()));

                            }
                            else if (furtherOption == 2)
                            {
                                Console.WriteLine("Enter amount you want to deposit:");
                                account.deposit(int.Parse(Console.ReadLine()));
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }
               
          
                }
                found = 0;
            }
            

        }
    }
}
