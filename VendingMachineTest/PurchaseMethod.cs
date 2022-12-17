using System;
using System.Xml;

namespace VendingMachineTest
{
    class PurchaseMethod
    {
        public static void BuyItem(XmlDocument productList, ref float moneyValue, int number)
        {
            XmlNode root = productList.DocumentElement;

            if (moneyValue >= float.Parse(root.SelectNodes("Key").Item(number).SelectSingleNode("price").InnerText))
            {
                moneyValue -= float.Parse(root.SelectNodes("Key").Item(number).SelectSingleNode("price").InnerText);
                root.RemoveChild(root.SelectNodes("Key").Item(number));              
            }
            else
                Console.WriteLine("You don't have enough money for that item");
        }

    }
}
