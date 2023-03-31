using NUnit.Framework.Internal.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListLab
{
    internal class LinkedList
    {
        public Node Head { get; set; }  

        public LinkedList()
        {
            Head = null;
        }

        public ulong Count { get; set; }    

        public void AddFirst(string value)
        {
            //Create new node
            Node newNode= new Node();

            //set value of new node
            newNode.Value = value;

            //get the node at the head
            Node head = this.Head;

            //set the next of new node to node at head
            newNode.Next = head; 

            //set the head to the newNode
            this.Head = newNode;

            //Increment the size
            this.Count = Count + 1;


        }

        public void AddLast(string value)
        {
            //Create new node
            Node newNode= new Node();

            //Add value to new node
            newNode.Value = value;

            //get the node at the head
            Node head = this.Head;

            //loop and move the head until the node.next is NULL
            //check if the linked list is empty or not
            if(head == null)
            {
                this.Head = newNode;
                this.Count = this.Count + 1;
            }
            else
            {//if not empty, go through list

               // Node currentNode = new Node();
                //get current node at head
                Node currentNode = this.Head;

                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
                //increment size
                this.Count = this.Count + 1; 
            }

            


        }

        public void RemoveFirst()
        {
            //Get the node at the head
            Node head = this.Head;

            //check to see if list is empty or not
            if(this.Head != null)
            {
                //only one item in the list
                if(head.Next == null)
                {
                    this.Head = null;
                    this.Count = this.Count - 1;
                }
                else
                {
                    //get the head node
                    Node currentNode = this.Head;   

                    //set the head to reference the next node
                    this.Head = this.Head.Next;

                    //set the next of the former head node to null
                    currentNode.Next = null;

                    //decrement the counter
                    Count = Count - 1;  

                }
            }
         
        }

        public void RemoveLast()
        {
            //check if empty list or not
            if(this.Head != null)
            {
                //if only one item in the list
                if(this.Head.Next == null)
                {
                    this.Head = null;
                    this.Count = this.Count-1;
                }
                else //traverse the list
                {
                    Node currentNode = this.Head;

                    //second last in the list where the current node has a next but no next of next node.
                    while(currentNode.Next.Next!= null)
                    {
                        currentNode = currentNode.Next;

                    }

                    //set the second last node next to null
                    currentNode.Next = null;

                    //Decrement count
                    this.Count = this.Count - 1;  
                }

            }

        }

        public string GetValue(int index)
        {
            string value;

            Node currentNode = this.Head;

            for(int i = 0; i < index ; i++)
            {   
 
                currentNode = currentNode.Next;
                
            }

            /*
            //traverse through the list of nodes
            for(Node currentNode = this.Head; currentNode != null; currentNode= currentNode.Next)
            {
                if()
            }
            */
            
            return currentNode.Value;
        }
    }
}
 

