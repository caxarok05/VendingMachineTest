using System;
using System.Xml;

namespace VendingMachineTest
{
    class PurchaseMethod
    {
        public static void BuyItem(XmlDocument productList, float moneyValue, int number)
        {
            XmlNode root = productList.DocumentElement;

            if (moneyValue >= int.Parse(root.SelectNodes("Key").Item(number).SelectSingleNode("price").InnerText))
            {
                root.RemoveChild(root.SelectNodes("Key").Item(number));          
            }

        }

    }
}
