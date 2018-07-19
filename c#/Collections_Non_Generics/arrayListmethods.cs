using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class arrayListmethods
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(20);
           // Console.WriteLine("Adding elements to list");
            //for adding any type of element
            Console.WriteLine(list.Add(1));
            list.Add(2);//we can insert duplicates
            list.Add('c');
            list.Add('c');
            list.Add("hello");
            list.Add("hello");
            list.Add(true);
            list.Add(true);
            list.Contains(1);
            //list.Sort();
            int count = list.Count;
            int i = list.Capacity;
            
            list.Reverse();
            //Console.WriteLine(list.ToString());
            //Console.WriteLine(list.Capacity);
             list.TrimToSize();
            //Console.WriteLine(list.Capacity);
            ArrayList list1 = (ArrayList)list.Clone();
       
            //Console.WriteLine(list.IndexOf('c'));
            //Console.WriteLine(list.Capacity);
            //list.CopyTo(a);
            foreach (var v in list1)
            {
                //Console.WriteLine(v + "clone");
            }
           
            foreach (var v in list)
            {
                //Console.WriteLine(v);
            }
            //Console.WriteLine("Removing elements from list");
            //removing a specific element
            list.Remove(1);//removing element whose content is '1' of int type
            list.RemoveAt(2);//removing 2nd indexed element of list

            foreach (var v in list)
            {
                //Console.WriteLine(v);
            }
           // Console.WriteLine("inserting  elements to list");
            list.Insert(2, "insert");//we are adding in middle
            //list.Clear();//removes all elements from arraylist
            list.ToArray();
            Console.ReadKey();
        }

    }
}
//arrayList allow any type of data
//it allows duplicates
//insertion order is preserved

//Add(object obj) =  for adding any type of element into list
//Remove(element) = for removing specific element
//RemoveAt(index) = for removing particualr indexed element from list
//Insert(index, value) = for inserting an element at specific index of list
//Sort = property for sorting elements of arraylist(but all the elements of array should be of same type)
//Clear() = for removing all the elements from arraylist

//Count = gets total number of elements currently available in the list
//Capacity = get max number of elements that can be inserted into the list
//Clone() = creates a another copy of ArryList
//Contains(element) = to check whether the specific elemetn available or not
//IndexOf(element) = returns the index of first occurance of specific element in the list
//Reverse() = reverses the contens of arraylist
//ToTrimSize() = deletes the unfilled indexes from list
//CopyTo() = copies the elemetn from one arrayList to another array
//ToString() = returns a string that represents the current object
//ToArray() = copies the arraylist elemetns to a new array