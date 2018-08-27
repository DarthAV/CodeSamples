using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListNamespace
{
    public class LinkedList<T> : IEnumerable<Node<T>>, IEnumerator<Node<T>>
    {
        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }

        object IEnumerator.Current => currentNode;
        public Node<T> Current => currentNode; 

        private Node<T> currentNode;
        public void printAllNodes()
        {
            Node<T> current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }


        public void Add(T objectForAdding, bool front = true)
        {
            Node<T> newNode = new Node<T> { data = objectForAdding };
            if (head == null)
            {
                this.tail = newNode;
                this.head = newNode;
            }
            else
            {
                if (front == true)
                {
                    newNode.next = this.head;
                    this.head = newNode;

                }
                else
                {
                    this.tail.next = newNode;
                    this.tail = newNode;
                }
            }
        }

        public void Delete(T objectForDeleting)
        {
            Node<T> previousNode = null;
            Node<T> currentNode = this.head;

            while (currentNode != null)
            {
                if (!objectForDeleting.Equals(currentNode.data))
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }
                else if (objectForDeleting.Equals(currentNode.data))
                {
                    if (previousNode == null)
                    {
                        this.head = currentNode.next;
                        if (this.head == null)
                        {
                            this.tail = null;
                        }
                    }
                    else
                    {
                        previousNode.next = currentNode.next;

                        if (currentNode == this.tail)
                        {
                            previousNode = this.tail;
                        }
                    }

                    break;
                }
            }
            if (currentNode == null)
            {
                throw new Exception("Requested Node Does Not Exist.");
            }
        }

        public int GetNodeCount()
        {
            int count = 0;

            var node = head;

            while (node != null)
            {
                count++;
                node = node.next;
            }

            return count;
        }

        public LinkedList<T> Clone()
        {
            var clonedLinkList = new LinkedList<T>();

            var currentNode = this.head;
            while (currentNode != null)
            {
                clonedLinkList.Add(currentNode.data, front: false);

                currentNode = currentNode.next;
            }

            return clonedLinkList;
        }

        public bool MoveNext()
        {
            if (this.currentNode != null)
            {
                this.currentNode = this.currentNode.next;
            }
            else
            {
                this.currentNode = this.head;
            }

            if (this.currentNode == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            this.currentNode = null;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        IEnumerator<Node<T>> IEnumerable<Node<T>>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
