using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            int current_id = 0;
            User_CRUD user_CRUD = new User_CRUD();
            //
            //
            int option = 0;

            User_Details ud = new User_Details();
            Console.WriteLine("Login");
            Console.WriteLine("Enter user id");
            ud.User_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Password");
            ud.User_Password = Console.ReadLine();
            int result = user_CRUD.Login(ud.User_id, ud.User_Password);
            current_id = ud.User_id;
                      
            do
            {
                if (result == 0)
                {
                    Console.WriteLine("Invalid Entry");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Admin");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Display User");
                    Console.WriteLine("3. LogOut");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            User_Details ud1 = new User_Details();
                            Bank bank = new Bank();
                            Console.WriteLine("Enter user id ");
                            ud1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            ud1.User_Name = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            ud1.User_Password = Console.ReadLine();
                            Console.WriteLine("User Account number");
                            bank.Account_no = Convert.ToInt32(Console.ReadLine());
                            user_CRUD.AddUser(ud1);
                            break;

                        case 2:
                            List<User_Details> list = user_CRUD.GetUser_Details();

                            foreach (User_Details item in list)
                            {
                                Console.WriteLine($"{item.User_id}--{item.User_Name}--{item.User_Password}");
                            }
                            break;
                    }

                }
                else if (result == 2)
                {
                    Console.WriteLine("Welcome User");
                    Console.WriteLine("1. Credit");
                    Console.WriteLine("2. Debit");
                    Console.WriteLine("3.View Balance");
                    //Console.WriteLine("4.Account Details");
                    Console.WriteLine("4.Add Payee");
                    Console.WriteLine("5. Fund Transfer");
                    Console.WriteLine("6. Remove Payee");

                    int op1 = Convert.ToInt32(Console.ReadLine());

                    switch (op1)
                    {
                        //credit amount
                        case 1:
                            //User_Details user = new User_Details();
                            Bank_CRUD crud1 = new Bank_CRUD();
                            Bank b1 = new Bank();
                            Console.WriteLine("Enter user id");
                            b1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            b1.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            b1.Amount = Convert.ToInt32(Console.ReadLine());
                            crud1.CreditAmount(b1.User_id,b1.Balance,b1.Amount);
                            break;

                        //debit amount
                        case 2: 
                            Bank bank = new Bank();
                            Bank_CRUD crud2 = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            bank.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            bank.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            bank.Amount = Convert.ToInt32(Console.ReadLine());
                            crud2.DebitAmount(bank.User_id,bank.Balance,bank.Amount);
                            break;

                        //view balance
                        case 3: 
                            Bank bank1 = new Bank();
                            Bank_CRUD crud3 = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            bank1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            bank1.Balance = Convert.ToInt32(Console.ReadLine());
                            crud3.ViewAmount(bank1.User_id,bank1.Balance);
                            break;


                        //add payee 
                        case 4: 
                            Bank bank2 = new Bank();
                            Bank_CRUD crud4 = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            bank2.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee NAme");
                            bank2.PayeeName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Payee Account Number");
                            bank2.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            crud4.AddPayee(bank2.User_id,bank2.PayeeName,bank2.PayeeAccNo);
                            break;

                        //fund transfer
                        case 5: 
                            Bank bank3 = new Bank();
                            Bank_CRUD crud5 = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            bank3.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            bank3.Amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee Number");
                            bank3.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            crud5.FundTransfer(bank3.User_id,bank3.Amount,bank3.PayeeAccNo);
                            break;

                        //remove payee
                        case 6: 
                            Bank bank4 = new Bank();
                            Bank_CRUD crud6 = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            bank4.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee Account Number");
                            bank4.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            crud6.RemovePayee(bank4.User_id,bank4.PayeeAccNo);
                            break;

                    }
                }   
                
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());               
            }
            while (option == 1);
        }
    }
}
