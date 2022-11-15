using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //System.Collections namespace 
        //var arlist = new ArrayList();
        //ArrayList arlist = new ArrayList(); 

        ArrayList liste = new ArrayList();
        //liste.Add("Ayşe");
        //liste.Add('A');
        //liste.Add(9);
        //liste.Add(true);


        //Access to data in the list..
        //Console.WriteLine(liste[0]);

        //foreach (var item in liste)
        //    Console.WriteLine(item);

        //AddRange
        Console.WriteLine("\n-AddRange-");
        //string[] renkler={"Kırmızı","Mavi","Yeşil"};
        List<int> sayilar = new List<int>() { 1, 5, 2, 25, 13, 4 };
        //liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
            Console.WriteLine(item);

        //Sort
        Console.WriteLine("\n-Sort-");
        liste.Sort();

        foreach (var item in liste)
            Console.WriteLine(item);

        //Binary Search
        Console.WriteLine("\n-Binary Search-");
        Console.WriteLine(liste.BinarySearch(13));

        //Reverse
        Console.WriteLine("\n-Reverse-");
        liste.Reverse();

        foreach (var item in liste)
            Console.WriteLine(item);

        //Clear
        Console.WriteLine("\n-Clear-");
        liste.Clear();

        foreach (var item in liste)
            Console.WriteLine(item);


        //Exp
        var arlist1 = new ArrayList();
        // adding elements using ArrayList.Add() method
        arlist1.Add(1);
        arlist1.Add("Bill");
        arlist1.Add(" ");
        arlist1.Add(true);
        arlist1.Add(4.5);
        arlist1.Add(null);

        //adding elements using object initializer syntax
        var arlist2 = new ArrayList()
                    {
                        1, "Steve", " ", true, 4.5, null
                    };

        int[] arr = { 100, 200, 300, 400 };
        arlist1.Insert(1, "Second Item");

        ArrayList arlist3 = new ArrayList()
                {
                    300, 400, 500
                };
       arlist1.InsertRange(2, arlist3);

        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World!");

        arlist1.AddRange(arlist2); //adding arraylist in arraylist 
        arlist1.AddRange(arr); //adding array in arraylist 
        arlist1.AddRange(myQ); //adding Queue in arraylist 

        arlist1.Remove(null); //Removes first occurance of null
        arlist1.RemoveAt(4); //Removes element at index 4
        arlist1.RemoveRange(0, 2);//Removes two elements starting from 1st item 

        Console.WriteLine("\n-arlist1 by foreach-");
        foreach (var item in arlist1)
                Console.WriteLine(item);

        Console.WriteLine("\n-arlist1 by for-");
        for(int i = 0 ; i < arlist1.Count; i++)
        Console.Write(arlist1[i] + ", ");

        Console.WriteLine("\n300 elamanı var mı?");
        Console.WriteLine(arlist1.Contains(4.5));

        




    }
}