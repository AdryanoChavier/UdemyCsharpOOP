using System.Collections.Generic;
internal class Program{
    static void Main(string[] args){
        
        List<string> list = new List<string>();
    
        
        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Ana");
        list.Add("didico");
        list.Add("alexre");


        list.Insert(2, "Marco");

        foreach (string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine();
        Console.WriteLine("Lista Count "+list.Count);
        Console.WriteLine();


        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("First 'A': " + s1);
        Console.WriteLine();

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A': " + s2);
        Console.WriteLine();

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First Position 'A': "+pos1);
        Console.WriteLine();

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Last Position 'A': "+pos2);
        Console.WriteLine();


        Console.WriteLine("----------------------------");
        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach(string obj2 in list2){
            Console.WriteLine(obj2);
        }
        Console.WriteLine("----------------------------");
        list.Remove("Alex");
        foreach (string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------");
        list.RemoveAll(x => x[0] == 'M');
        foreach (string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------");
        list.RemoveAt(0);
         foreach (string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------");
        list.RemoveRange(0,1);
         list.RemoveAt(0);
         foreach (string obj in list){
            Console.WriteLine(obj);
        }

    }

}