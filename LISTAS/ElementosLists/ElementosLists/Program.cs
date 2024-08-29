using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace ElementosLists {
    class Program {
        static void Main(string[] args) {
            //List<string> list = ["Maria", "Alexandre", "Bruno", "Ana"];

            List<string> list = new List<string>();

            //uso do Add e Insert
            list.Add("Maria");
            list.Add("Alexandre");
            list.Add("Bruno");
            list.Add("Ana");
            list.Insert(2, "Matheus");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");

            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alexandre");
            Console.WriteLine("---------------------");
            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
                Console.WriteLine("---------------------");
            
            foreach(string obj in list) {
                Console.WriteLine(obj);
            }





        }
    }

}