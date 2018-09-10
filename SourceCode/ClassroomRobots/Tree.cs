﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobots
{
    class Tree
    {
        //The root of the tree
        public Node root = null;

        //List of values that the tree holds.
        public List<Node> sorted = new List<Node>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Tree()
        {
            //Set the root to null.
            this.root = null;
        }

        /// <summary>
        /// Add a value to the tree.
        /// </summary>
        /// <param name="val"></param>
        public void AddValue(Student val)
        {
            //Create a new node.
            Node node = new Node(this, val);

            //If there isnt a root node.
            if (this.root == null)
            {
                //Set the new node as the root node.
                this.root = node;
            }
            else
            {
                //Try to add the new node to the root.
                this.root.AddNode(node);
            }
        }

        /// <summary>
        /// Traverse through the tree.
        /// </summary>
        public void Traverse()
        {
            //Clear the list.
            sorted.Clear();

            //Traverse the root.
            root.Traverse();
        }

        /// <summary>
        /// Search through the tree.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public Node Search(Student val)
        {
            //Start the search at the root.
            Node found = root.Search(val);

            //Return what we found.
            return found;
        }

        /// <summary>
        /// Print the sorted list to the console.
        /// </summary>
        public void Print()
        {
            //Go through each node in the sorted array.
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i].value.name + ",");
            }
        }
    }
}
