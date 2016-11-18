using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS_Linked_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // First create a node class. This class would instantiate a node 
        // when we want to add a new node to our linked list.
        public class Node
        {
            public object data; //to store the data of the node
            public Node link; //the reference(link) of the node
            public Node(object data) //constructor
            {
                this.data = data;
            }
        }

        /*The second class that we create is the LinkedList class. 
        The main purpose of this class is to set the references/links of the nodes.
        We also include all methods that manipulate the nodes and their links in this class.*/
        public class LinkedList
        {
            Node head; //the first node of the linked list
            Node current; //the last added node
            // The Add method
            public void Add(Node node1) //add a new node
            {
                if (head == null)
                {
                    head = node1; //head is pointed to the newly added node
                    current = head; //current is pointed to the newly added node
                }
                else
                {
                    current.link = node1; //a link is made to the newly added node
                    current = current.link; //current is updated
                }
            }
            // The Print method
            public String Print() //print all nodes in the linked list
            {
                Node PrintNode = head;
                String output = "";
                while (PrintNode != null)
                {
                    output += PrintNode.data + "\r\n";
                    PrintNode = PrintNode.link;
                }
                return output;
            }
        }
            private void btnExecute_Click(object sender, EventArgs e)
        {
            LinkedList list = new LinkedList();

            //add new nodes
            list.Add(new Node("Apple"));
            list.Add(new Node("Orange"));
            list.Add(new Node("Pears"));
            list.Add(new Node("Grapes"));
            list.Add(new Node("Strawberry"));

            //print nodes
            txtOutput.Text = list.Print();
        }
    }
}
