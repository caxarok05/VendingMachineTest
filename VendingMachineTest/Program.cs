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
            string filePath = Console.ReadLine();
            xDoc.Load(@"C:\Users\User\Desktop\WendingWachineList.xml");


            int ItemsNumber = 10;
            for (int i = 0; i < ItemsNumber; i++)
            {
                InfoDislpay.ShowInfo(xDoc);

                Console.WriteLine("Enter number do you want to buy:");
                int purchaseNumber = int.Parse(Console.ReadLine()) - 1;

                PurchaseMethod.BuyItem(xDoc, moneyValue, purchaseNumber);
            }
            
        }
    }
}
