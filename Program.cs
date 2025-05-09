using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Expense_Tracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Expense expense = new Expense();

            List<Expense> expensesList = new List<Expense>()
            {
                { new Expense("cab","travel",88.00) },
                { new Expense("milk","food",47.00) }
            };
            do
            {
                Console.WriteLine("-----Expense Tracker-----");
                int choice;
                try
                {
                    Console.WriteLine("\n1. Add expense\n2. View expenses\n3. Exit\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.Write("Enter description: ");
                                string? description = Console.ReadLine();
                                if (description == string.Empty)
                                {
                                    throw new FormatException("Description cannot be empty. Try again!");
                                }
                                if (Regex.IsMatch(description, @"\d"))
                                {
                                    throw new NotStringInputException("Number not allowed in expense description");
                                }
                                Console.Write("Enter category: ");
                                string? category = Console.ReadLine();
                                if(category == string.Empty)
                                {
                                    throw new FormatException("Category cannot be empty. Try again!");
                                }
                                if (Regex.IsMatch(category, @"\d"))
                                {
                                    throw new NotStringInputException("Number not allowed in expense category");
                                }
                                Console.Write("Enter amount: ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                if(amount <= 0)
                                {
                                    throw new NegativeAmountException("Amount cannot be less than zero");
                                }
                                expensesList.Add(new Expense(description, category, amount));
                                Console.WriteLine();
                                expense.ViewExpenses(expensesList);
                                Console.WriteLine();
                            }
                            catch (NotStringInputException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch(NegativeAmountException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:
                            Console.WriteLine("EXPENSES: ");
                            expense.ViewExpenses(expensesList);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice Try again!");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid choice entered");
                }
                Console.WriteLine();
            } while(true);
        }
    }
}
