using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Finance
{
    public static void Check(int age,int amount)
    {
        
        // int amount=500000;
        int n;
        int cnt=0;
        int limit=40000;
        while (true)
        {
            // n=Convert.ToInt32(Console)
            Console.WriteLine("Enter 1 to check loan eligibility");
            Console.WriteLine("Enter 2 to calculate tax");
            Console.WriteLine("Enter 3 for transactions");
            Console.WriteLine("Enter 4 to exit");
            Console.WriteLine("5 Credit");
            Console.WriteLine("6 Debit");
            n=Convert.ToInt32(Console.ReadLine());
            if(n==4)
            break;
            
           switch (n){
                case 1:
                    if(age<21)
                    Console.WriteLine("You are not eligible for loan , you are underaged");
                    else Console.WriteLine("You are eligible");
                    break;
                case 2:
                if(amount<=250000)
                Console.WriteLine("You have 0 tax to pay");
                else if(amount>=250001 && amount <= 500000)
                    {
                        Console.WriteLine($"you have {(5/100)*amount} tax to pay");
                    }
                    else if(amount>=500001 && amount <= 1000000)
                    {
                        Console.WriteLine($"You have {0.2*amount} to pay");
                    }
                    else
                    {
                        Console.WriteLine($"you have {0.3*amount} tax to pay");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter transaction amount:");
                    // int cnt=0;
                    while(true){
                        if(cnt>5)
                        {
                            Console.WriteLine("you have reached your transaction limit for this day");
                            break;
                        }
                        int a=Convert.ToInt32(Console.ReadLine());
                    if (a <= 0)
                    {
                        Console.WriteLine("Ente valid amount");
                    }
                    else if (a > amount)
                        {
                            Console.WriteLine("insufficient fund in your account");
                        }
                        else
                    {
                        cnt++;
                        amount-=age;
                        break;
                        
                    }
                    // break;
                    }
                    Console.WriteLine("Transaction successful");
                    break;
                case 5:
                Console.WriteLine("Entering into credit operations...");
                    while (true)
                    {
                        Console.WriteLine("1.Atm withdrawal");
                        Console.WriteLine("2.Emi evaluation");
                        Console.WriteLine("3.Transaction calculator");
                        Console.WriteLine("4.Minimum balance check");
                        Console.WriteLine("5.Exit");
                        int i=Convert.ToInt32(Console.ReadLine());
                        if(i==5)
                        break;
                        switch (i)
                        {
                            case 1:
                            Console.WriteLine("Enter withdrawal Amount");
                                while (true)
                                {
                                int w=Convert.ToInt32(Console.ReadLine());
                                if(w<0)Console.WriteLine("Enter a valid amount negative integers are not allowed");
                                    if (w <= limit)
                                    {
                                        limit-=w;
                                        Console.WriteLine("Withdrawal successfull");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Daily ATM withdrawal limit exceeded");
                                        break;

                                    }
                                    
                                }
                                break;
                                case 2:
                                Console.WriteLine("Enter your monthly income");
                                int m=Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter EMI amount:");
                                int emi=Convert.ToInt32(Console.ReadLine());
                                if (emi > 0.4 * m)
                                {
                                    Console.WriteLine("EMI exceeds safe income limit");
                                }
                                else
                                {
                                    Console.WriteLine("Emi is managable");
                                }
                                break;
                                case 3:
                                Console.WriteLine("Enter daily spends and press 8 to exit");
                                int expense=0;
                                while (true)
                                {
                                    int c=Convert.ToInt32(Console.ReadLine());
                                    if(c==8)
                                    break;
                                    expense+=c;
                                }
                                Console.WriteLine($"Total expenditure of thr day is {expense}");
                                break;
                                case 4:
                                Console.WriteLine("Enter Balance amount:");
                                int am=Convert.ToInt32(Console.ReadLine());
                                if (am < 2000)
                                {
                                    Console.WriteLine("Minimum balance not maintained. Penalty applicable");
                                }else
                                {
                                    Console.WriteLine("Minimum balance requirement satisfied");
                                }
                                break;
                                default:
                                Console.WriteLine("Enter a valid number ");
                                break;

                        }
                       
                    }
                    break;
                    case 6:
                    Console.WriteLine("Entering into credit operations");
                    Console.WriteLine("1.Net Salary Credit Calculation");
                    Console.WriteLine("2.Fixed Deposit Maturity Calculation");
                    Console.WriteLine("3.Credit Card Reward Points Evaluation");
                    Console.WriteLine("4.Employee Bonus Eligibility Check");
                    Console.WriteLine("Enter 9 to exit");
                    while (true)
                    {
                        int l=Convert.ToInt32(Console.ReadLine());
                        if(l==9)break;
                        switch (l)
                        {
                            case 1:
                            Console.WriteLine("Enter net salary");
                            double a=Convert.ToInt32(Console.ReadLine());
                            a-=0.1*a;
                            Console.WriteLine($"Net salary is {a}");
                            break;
                            case 2:
                            Console.WriteLine("Enter principal roi and time ");
                            int p=Convert.ToInt32(Console.ReadLine());
                            int roi=Convert.ToInt32(Console.ReadLine());
                            int t=Convert.ToInt32(Console.ReadLine());
                            int total=p*t*roi/100;
                            Console.WriteLine($"Fixed Deposit maturity amount:{total+p}");
                            break;
                            case 3:
                            Console.WriteLine("Enter total credit card spending ");
                            int c=Convert.ToInt32(Console.ReadLine());
                            int r=c/100;
                            Console.WriteLine($"Reward points earned:{r}");
                            break;
                            case 4:
                            Console.WriteLine("Enter your salary and experience");
                            int s=Convert.ToInt32(Console.ReadLine());
                            int e=Convert.ToInt32(Console.ReadLine());
                            // Console.WriteLine("")
                            if(s>500000 && e>=3)Console.WriteLine("Employee is eligible for bonus");
                            else Console.WriteLine("Employee is not eligible");
                            break;

                        }                    
                    }
                    break;
                    default:
                    Console.WriteLine("Enter a number between 1 and 4 only ");
                    break;
            }
        }    
    }
}
