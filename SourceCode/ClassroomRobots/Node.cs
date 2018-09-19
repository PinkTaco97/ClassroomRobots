using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Nathan Robertson
 * Date: 05/09/2018
 */

namespace ClassroomRobots
{
    /// <summary>
    /// The Node Class.
    /// </summary>
    class Node
    {
        /// <summary>
        /// The Student the Node holds.
        /// </summary>
        public Student value;

        /// <summary>
        /// The Left Node.
        /// </summary>
        public Node left = null;

        /// <summary>
        /// The Right Node.
        /// </summary>
        public Node right = null;

        /// <summary>
        /// The binary tree the node belongs to.
        /// </summary>
        public Tree tree = null;

        /// <summary>
        /// This index in the sorted list.
        /// </summary>
        public int index;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public Node(Tree tree, Student value)
        {
            //Set the nodes tree.
            this.tree = tree;

            //Set the nodes value.
            this.value = value;
        }

        /// <summary>
        /// Try to add a node to the current node.
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(Node node)
        {
            //If the new node's value is less than the current node's value.
            if (String.Compare(node.value.name, this.value.name) < 0)
            {
                //If the current node dosnt have a left node.
                if (this.left == null)
                {
                    //Set the child to the new node.
                    this.left = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.left.AddNode(node);
                }
            }
            //If the new node's value is more than the current node's value.
            else if (String.Compare(node.value.name, this.value.name) > 0)
            {
                //If the current node dosnt have a right node.
                if (this.right == null)
                {
                    //Set the child to the new node.
                    this.right = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.right.AddNode(node);
                }
            }
        }

        /// <summary>
        /// Traverse throughout the Tree.
        /// </summary>
        public void Traverse()
        {
            //If the current node has a left child.
            if (this.left != null)
            {
                //Traverse the left node.
                this.left.Traverse();
            }

            //Add the current node to the sorted list.
            tree.sorted.Add(this);

            //If the current node has a right child.
            if (this.right != null)
            {
                //Traverse the right node.
                this.right.Traverse();
            }

            //Reached the end of the tree.
            tree.setIndex();
        }

        /// <summary>
        /// Searches the current node.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public Node Search(Student val)
        {
            //If the current node's value == the value we are searching for.
            if (this.value.name == val.name)
            {
                //Return the current node.
                return this;
            }
            //If the value is less than the current node's value.
            else if (String.Compare(val.name, this.value.name) < 0 && this.left != null)
            {
                //Search the current node's left child.
                return this.left.Search(val);
            }
            //If the value is more than the current node's value.
            else if (String.Compare(val.name, this.value.name) > 0 && this.right != null)
            {
                //Search the current node's right child.
                return this.right.Search(val);
            }
            return null;
        }
    }
}
