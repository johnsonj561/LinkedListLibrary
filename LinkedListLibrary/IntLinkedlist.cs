using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary {
    class IntLinkedlist {

        /// <summary>
        /// Constructor creates and empty linked list for integers
        /// </summary>
        public IntLinkedlist() {
            head = tail = null;
            this.size = 0;
        }

        /// <summary>
        /// Append Node to the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void insert(int value) {
            IntNode newNode = new IntNode(value);
            size++;
            //if this is the first element
            if(head == null) {
                Console.WriteLine("\n1st Node Created\nValue = " + value);
                head = tail = newNode;
                return;
            }
            else {
                Console.WriteLine("\nNode Created\nValue = " + value);
                tail.nextNode = newNode;
                newNode.prevNode = tail;
                tail = newNode;

            }
        }

        
        /// <summary>
        /// Remove the Node found at given index of linked list by removing reference to Node
        /// Garbage collector will remove Node from memory once de-referenced
        /// </summary>
        /// <param name="index"></param>
        public void remove(int index) {
            //if index is head, need to update head
            if(index == 0) {
                head = head.nextNode;
                size--;
                Console.WriteLine("\nIntLinkedList.remove() -> Index = " + index + " = head Removed Successfully");
            }
            //else if inde is tail, need to udpate tail
            else if(index == (size - 1)) {
                tail = tail.prevNode;
                size--;
                Console.WriteLine("\nIntLinkedList.remove() -> Index = " + index + " = tail Removed Successfully");
            }
            //else we are eremoving Node from the center of the Linked list
            else if(index > 0 && index < size) {
                //iterate through array until we find correct index
                IntNode current = head;
                for(int i = 0; i < index; i++) {
                    current = current.nextNode;
                }
                current.prevNode.nextNode = current.nextNode;
                current.nextNode.prevNode = current.prevNode;
                size--;
                Console.WriteLine("\nIntLinkedList.remove() -> Index = " + index + " Removed Successfully");
            }
            else {
                Console.WriteLine("\nError removing node at index " + index + "\nNode out of bounds");
            }
        }


        /// <summary>
        /// Print List's Node Addresses and Values to Console
        /// </summary>
        public void print() {
            IntNode current = head;
            Console.WriteLine("\n\nPrinting Linked List");
            Console.WriteLine("Head -> " + head.value);
            Console.WriteLine("Tail -> " + tail.value);
            Console.WriteLine("Size = " + size + "\n\nList Elements\n---------");

            //while current node is not null, print and increment
            while (current != null) {
                Console.WriteLine("\nValue: " + current.value);
                current = current.nextNode;
            }
        }


        /// <summary>
        /// Calculates average of all Linked List elements
        /// </summary>
        /// <returns>Double average</returns>
        public double getAverage() {
            //sum elements of linked list
            IntNode current = head;
            double sum = 0;
            while (current != null) {
                sum += current.value;
                current = current.nextNode;
            }
            return Math.Round(sum/size, 2);  
        }


        /// <summary>
        /// Finds maximum value of LinkedList
        /// </summary>
        /// /// <returns>int Max value</returns>
        public int getMax() {
            IntNode current = head;
            int max = 0;
            while(current != null) {
                if(current.value > max) {
                    max = current.value;
                }
                current = current.nextNode;
            }
            return max;
        }


        /// <summary>
        /// Finds minimum value of LinkedList
        /// </summary>
        /// <returns>int Min value</returns>
        public int getMin() {
            IntNode current = head;
            int min = Int32.MaxValue;
            while (current != null) {
                if (current.value < min) {
                    min = current.value;
                }
                current = current.nextNode;
            }
            return min;
        }


        public IntNode head { get; set; }
        public IntNode tail { get; set; }
        public int size { get; private set; }

    }
}
