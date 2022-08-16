using _2022_SingleLinkedLists_VS2022.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_SingleLinkedLists_VS2022.CLinkedLists
{
    //Added internal
    internal class SLinkedList
    {
        //Head
        public CustomNode head;
        //Created new node
        CustomNode current;

        String data;
        int nodeCount;

        ///LIST TO DISPLAY NODES
        List<string> nextList;

        //Append means add to the end
        public void appendNode(string data)
        {
            //Null if its empty
            if (head == null)
            {
                //Set data in ()
                head = new CustomNode(data);

                nodeCount++;

                return;
            }

            current = head;

            //While Loop
            //We can only add when it is null
            //If there is an existing list, walk through
            //! means not equal to, as not equal to null
            while (current.Next != null)
            {
                current = current.Next;

            }

            //This will make a new Node
            current.Next = new CustomNode(data);

        }

        //
        public void prepend(string data)
        {

            if (head != null)
            {
                //
                head = new CustomNode(data);
                nodeCount++;
            }

            else
            {
                //Create a new head
                CustomNode newHead = new CustomNode(data);
                //
                nodeCount++;
                //pointer
                newHead.Next = head;
                head = newHead;
            }


        }


        ////ATTEMPT AT DISPLAY
        public int count()
        {
            return nodeCount++;
        }


        public List<string> showNext()
        {
            nextList = new List<string>();

            current = head;

            nextList.Add(current.data);


            while (current.Next != null)
            {
                nextList.Add(current.data);

                current = current.Next;
            }

            return nextList;
        }

        //Delete a node
        public void deleteWithData(string data)
        {
            //Check if the list exists
            if (head == null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;
            }

            //Head contains the data we need to delete is not head, we need to walk the list
            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            //If its not 

            //Set the head to current to walk the list
            current = head;

            while (current.Next != null)
            {

                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data " + data + " deleted");
                }

                //If the data does not match 
                current = current.Next;
            }



        }

        //Profanity Filter
        public void applyProfanitFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean ");
            }

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "*****");
                head.data = replaceString;
                MessageBox.Show(head.data);


            }


            //Walk the list
            //Applying the profanity filter
            current = head;

            while (current.Next != null)
            {
                current = current.Next;

                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);

                   

                }
            }

            MessageBox.Show("No Swear words in here");
        }
    }
}