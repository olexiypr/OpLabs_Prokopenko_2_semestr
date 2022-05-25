using System;
using System.Collections.Generic;
using System.IO;

namespace laba6
{
    public class Tree
    {
        public Node root;
        private Node left;
        private Node right;
        public int count { get; private set;}
        public void Add(double data)
        {
            Node node = new Node(data);
            if (root==null)
            {
                root = node;
            }
            else
            {
                Node current = root, parent = null;
                while (current!=null)
                {
                    parent = current;
                    if (data>current.data)
                    {
                        current = current.right;
                    }
                    else
                    {
                        current = current.left;
                    }
                }

                if (parent.data>node.data)
                {
                    parent.left = node;
                }
                else
                {
                    parent.right = node;
                }
            }
            count++;
        }
        public void FindMax(ref Node current)
        {
            if (root==null)
            {
                throw new InvalidOperationException("Tree is empty");
            }
            current = root;
            while (current.right!=null)
            {
                current = current.right;
            }
        }

        public void FindMin(ref Node current)
        {
            if (root==null)
            {
                throw new InvalidOperationException("Tree is empty");
            }
            current =  root;
            while (current.left!=null)
            {
                current = current.left;
            }
        }

        public void PrintTree(Node node, int level)
        {
            if (node!=null)
            {
                PrintTree(node.left, level+1);
                for (int i = 0; i < level; i++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(node.data);
                PrintTree(node.right, level+1);
            }
        }
    }
}