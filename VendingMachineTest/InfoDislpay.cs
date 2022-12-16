using System;
using System.Xml;

namespace VendingMachineTest
{
    class InfoDislpay
    {
     
        public static void ShowInfo(XmlDocument productList)
        {
            XmlElement rootElement = productList.DocumentElement;

            if (rootElement != null)
            {
                int NumberValue = 1;
                foreach (XmlElement xnode in rootElement)
                {
                    
                    Console.WriteLine($"----------------------{NumberValue}----------------------------");

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "name")
                        {
                            Console.WriteLine($"Name: {childnode.InnerText}");
                        }
                        if (childnode.Name == "price")
                        {
                            Console.WriteLine($"Price: {childnode.InnerText}$");
                        }
                    }
                    NumberValue++;
                }
            }
            Console.WriteLine();
        }
    }
}
