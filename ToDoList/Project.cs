using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Project
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Please type Add or View)");
      string response = Console.ReadLine();
      if (response.ToLower() == "add")
      {
        Console.WriteLine("Please enter a description for your item");
        string userDescription = Console.ReadLine();
        Item userItem = new Item(userDescription);
        Console.WriteLine("- " + userItem.Description + " has been added to your To Do List");
      }
      else
      {
        Console.WriteLine("There are no items in your To Do List");
      }
      Console.WriteLine("Would you like to add an item to your list or view your list? (Please type Add or View)");
      string response2 = Console.ReadLine();
      if(response2.ToLower() == "add"){
        Console.WriteLine("Please enter a description for your item");
        string userDescription2 = Console.ReadLine();
        Item userItem2 = new Item(userDescription2);
        Console.WriteLine("- " + userItem2.Description + " has been added to your To Do List");
      }
      else
      {
        List<Item> result = Item.GetAll();
        Console.WriteLine("Here is everything in your To Do List:");
        foreach (Item thisItem in result)
        {
          Console.WriteLine(thisItem.Description);
        }
      }
    }
  }
}