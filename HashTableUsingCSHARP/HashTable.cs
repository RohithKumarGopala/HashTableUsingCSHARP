using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableUsingCSHARP
{
    internal class HashTable<T>
    {
        int num;

        public class Node<T>
        {
            public T Temp;
            public Node<T> Next;

            public Node(T data)
            {
                Temp = data;
            }
        }

        private Node<T>[] Values;
        public HashTable(int size)
        {
            Values = new Node<T>[size];
        }

        public void AddOperation(T value)
        {
            Node<T> newNode = new Node<T>(value);
            int arrayIndex = Math.Abs(value.GetHashCode()) % Values.Length;
            newNode.Next = Values[arrayIndex];
            Values[arrayIndex] = newNode;
        }
        public void Display()
        {
            for (int index = 0; index < Values.Length; index++)
            {
                Node<T> temp = Values[index];
                Console.Write($"Index {index} : ");
                while (temp != null)
                {
                    Console.Write(temp.Temp + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }
    }
}

  
