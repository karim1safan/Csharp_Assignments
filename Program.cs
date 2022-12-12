using System;
internal class Program
{
  static void Main()
  {
    // Karim Mahmoud Safan
    // Note => Phone number store as string not int .
    string name, address, phoneNumber, faxNumber, webSite,
      mangerName, mangerSurName, phoneNumberManger;

    Console.WriteLine("Enter The Name Of Your Company:");
    name = Console.ReadLine();

    Console.WriteLine("Enter The Address Of Company: ");
    address = Console.ReadLine();

    Console.WriteLine("Enter The Phone Number Of Company: ");
    phoneNumber = Console.ReadLine();

    Console.WriteLine("Enter The Fax Number Of Company: ");
    faxNumber = Console.ReadLine();

    Console.WriteLine("Enter The Website Of The Company: ");
    webSite = Console.ReadLine();

    Console.WriteLine("Enter The Name Of Manger: ");
    mangerName = Console.ReadLine();

    Console.WriteLine("Enter The Surname Of Manger: ");
    mangerSurName = Console.ReadLine();

    Console.WriteLine("Enter The Phone Number Of Manger: ");
    phoneNumberManger = Console.ReadLine();

    Console.WriteLine(); // to make a break line
    Console.WriteLine("----- The Data Of Company -----");
    Console.WriteLine("The Name Of Your Company Is: {0}", name);
    Console.WriteLine("The Address Of Your Company Is: {0}", address);
    Console.WriteLine("The Phone Number Of Your Company Is: {0}", phoneNumber);
    Console.WriteLine("The Fax Number Of Your Company Is: {0}", faxNumber);
    Console.WriteLine("The Website Of Your Company Is: {0}", webSite);
    Console.WriteLine("The Name Of Manger Is: {0}", mangerName);
    Console.WriteLine("The Surname Of Manger Is: {0}", mangerSurName);
    Console.WriteLine("The Phone Number Of Manger Is: {0}", phoneNumberManger);
    Console.WriteLine(); // to make a break line
  }
}