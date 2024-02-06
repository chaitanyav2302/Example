using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node<T> Prev;

        public Node(T data)
        {
            this.data = data;
            Next = null;
            Prev = null;
        }
    }

   public class Vdlist<T> : IEnumerable<T>,ICollection<T>
    {
        private Node<T> head;
        int ICollection<T>.Count => throw new NotImplementedException();
        bool ICollection<T>.IsReadOnly => throw new NotImplementedException();

        //Adding element to the last of the linkedlist
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Prev = current;
            }
        }

        //adding the elements to first of the linkedlist
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                //current.Next.Prev = current;
                current.Prev = newNode;
                newNode.Next = current;
                head = newNode;
            }
        }

        //removing the last number from the list
        public void RemoveLast()
        {
            Node<T> current = head;
            Node<T> previous = null;

            if (head == null)
            {
                Console.WriteLine("the list is empty element cannot be deleted");
            }

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;

            }
            previous.Next = null;

        }
        //removing the first element from the list
        public void RemoveFirst()
        {
            Node<T> current = head;

            if (head == null)
            {
                Console.WriteLine("the list is empty element cannot be deleted");
            }
            else
            {
                // Added a check for current.Next
                if (current.Next != null)
                {
                    head = current.Next;
                    current.Next.Prev = null;
                }
                else
                {
                    // If there's only one element in the list
                    head = null;
                }
            }
        }

        //converting the double linkedlist to the array
        public T[] ToArray()
        {
            int length = Count();
            int index = 0;
            T[] resArray = new T[length];
            Node<T> current = head;
            while (current != null)
            {
                resArray[index++] = current.data;
                current = current.Next;

            }
            return resArray;

        }
        //counting the total number of elements in the list
        public int Count()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;


        }
        //checking whether certain element is present in the list or not
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        //adding range of numbers
        public void AddRange(T[] array)
        {
            foreach (T i in array)
            {
                AddLast(i);
            }
        }

        //sum of the elements in the list
        public T Total()
        {
            Node<T> current = head;
            T sum = default(T);
            if (head == null)
            {
                Console.WriteLine("The List is Empty. Try adding the elements :)");
            }
            else
            {
                while (current != null)
                {
                    sum = (dynamic)sum + (dynamic)current.data;
                    current = current.Next;
                }
            }
            return sum;
        }
        //adding the element after a certain element
        public void AddAfterElement(T a, T b)
        {

            Node<T> current = head;
            if (head == null)
            {
                Console.WriteLine("the list is empty");

            }
            else
            {
                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.data, a))
                    {
                        Node<T> newNumber = new Node<T>(b);
                        if (current.Next != null)
                        {
                            newNumber.Next = current.Next;
                            newNumber.Prev = current;
                            current.Next.Prev = newNumber;
                            current.Next = newNumber;
                        }
                        else
                        {
                            current.Next = newNumber;
                            newNumber.Next = null;
                            newNumber.Prev = current;
                        }

                    }
                    current = current.Next;
                }

            }

        }
        //adding the element before a certain element
        public void AddBeforeElement(T a, T b)
        {
            Node<T> current = head;


            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, a))
                {

                    Node<T> newNode = new Node<T>(b);


                    if (current.Prev != null)
                    {

                        newNode.Prev = current.Prev;
                        current.Prev.Next = newNode;
                    }
                    else
                    {

                        head = newNode;
                    }

                    newNode.Next = current;
                    current.Prev = newNode;


                    break;
                }
                current = current.Next;
            }
        }



        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

    }

}


