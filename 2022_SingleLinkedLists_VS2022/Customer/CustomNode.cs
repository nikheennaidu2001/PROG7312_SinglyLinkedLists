using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is the node class we created
//We cant call it Node class because VS has a built in Node class and it will get confused
namespace _2022_SingleLinkedLists_VS2022.Customer
{
    //Added internal
    internal class CustomNode
    {
        //Created 
        public CustomNode Next;
        //String data
        public string data;

        //Empty constructor
        public CustomNode()
        {

        }

        //Another constructor
        public CustomNode(string data)
        {
            this.data = data;
        }

    }
}

