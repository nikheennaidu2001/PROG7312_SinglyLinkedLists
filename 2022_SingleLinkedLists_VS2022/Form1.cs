using _2022_SingleLinkedLists_VS2022.CLinkedLists;

namespace _2022_SingleLinkedLists_VS2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            //// CREATED MT OWN
            //int countedNodes = 0;
            ////
            //List<string> nodeValues;

            SLinkedList slinkedList = new SLinkedList();
            slinkedList.appendNode("I am Head");
            slinkedList.appendNode("I am the Second Node");
            slinkedList.appendNode("I am the Third Node");

            slinkedList.prepend("I am head");
            slinkedList.prepend("Mhahaha I am head now");
            slinkedList.prepend("Look at me, I am captain now");

            //Delete node
            //slinkedList.deleteWithData("I am the Second Node");
            slinkedList.applyProfanitFilter("am");


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}