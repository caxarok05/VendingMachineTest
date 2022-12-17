using System;
using System.Xml;

namespace VendingMachineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter money value:");
            float moneyValue = float.Parse(Console.ReadLine());


            XmlDocument xDoc = new XmlDocument();

            Console.WriteLine("Enter xml-file path:");
            string filePath = Console.ReadLine(); //C:\Users\User\source\repos\VendingMachineTest\WendingWachineList.xml
            xDoc.Load(filePath);

            InfoDislpay.ShowInfo(xDoc);

            int ItemsNumber = xDoc.DocumentElement.SelectNodes("Key").Count;
            for (int i = 0; i < ItemsNumber; i++)
            {
                Console.WriteLine("Enter number do you want to buy:");

                int purchaseNumber = int.Parse(Console.ReadLine()) - 1;

                PurchaseMethod.BuyItem(xDoc, ref moneyValue, purchaseNumber);

                Console.WriteLine("Your money value now: " + moneyValue);

                InfoDislpay.ShowInfo(xDoc);

                Console.WriteLine("Do you want buy one more item? 1 = yes, 0 = no");
                int oneMoreBuy = int.Parse(Console.ReadLine());
                if (oneMoreBuy == 0)
                    break;
            }
            
        }
    }
}
