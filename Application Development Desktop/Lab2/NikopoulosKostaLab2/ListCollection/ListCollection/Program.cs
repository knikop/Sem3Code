﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main() {
         // create a new List of strings
        var items = new List<string>(); 

         // display List’s Count and Capacity before adding elements
         Console.WriteLine("Before adding to items: " +
         $"Count = { items.Count}; Capacity = {items.Capacity }");
                    items.Add("red");
                    items.Insert(0, "yellow");

         // display List’s Count and Capacity after adding two elements
         Console.WriteLine("After adding two elements to items: " +
         $"Count = {items.Count }; Capacity = {items.Capacity }");

         // display the colors in the list
         Console.Write(
         "\nDisplay list contents with counter-controlled loop:"); 
         for(var i = 0; i < items.Count; i++)
         {
         Console.Write($" {items[i] }");
         }

        // display colors using foreach 
        Console.Write("\nDisplay list contents with foreach statement:");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($" { items}");
            }

             items.Add("green"); // add "green" to the end of the List
             items.Add("yellow"); // add "yellow" to the end of the List

         // display List’s Count and Capacity after adding two more elements
         Console.WriteLine("\n\nAfter adding two more elements to items: " +
         $"Count = { items.Count}; Capacity = {items.Capacity }");

         // display the List
         Console.Write("\nList with two new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
                    items.Remove("yellow");
        // display the List
        Console.Write("\n\nRemove first instance of yellow:");
             foreach (var item in items)
             {
                Console.Write($" {item}");
             }
    
        // display the List
         Console.Write("\nRemove second list element (green):");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

         // display List’s Count and Capacity after removing two elements
         Console.WriteLine("\nAfter removing two elements from items: " +
         $"Count = { items.Count}; Capacity = {items.Capacity }");

         // check if a value is in the List
         Console.WriteLine("\n\"red\" is " +
         $"{( items.Contains("red") ? string.Empty : "not ")}in the list");

            items.Add("orange"); // add "orange" to the end of the List
            items.Add("violet"); // add "violet" to the end of the List
            items.Add("blue"); // add "blue" to the end of the List

         // display List’s Count and Capacity after adding three elements
         Console.WriteLine("\nAfter adding three more elements to items: " +
         $"Count = {items.Count }; Capacity = {items.Capacity }");

         // display the List
         Console.Write("List with three new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
                Console.WriteLine();
        }
    }
}
