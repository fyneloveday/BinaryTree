using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Binary_Tree
    {
        Node insert(Node root, int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }

            Node current;
            current = root;
            while (root != null)
            {
                if (data <= current.data)
                {
                    if (Node.leftchild == null)
                    {
                        Node.leftChild = new Node(data);
                    }
                    else
                    {
                        left.insert(value);
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = new Node(value);
                    }
                    else
                    {
                        right.insert(value);
                    }
                }
            }

           
        }

        public bool contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }


        public void printInOrder()
        {
            if (left != null)
            {
                left.printInOrder();
            }
            System.Out.printIn(data);
            if (Node.rightChild != null)
            {
                right.printInOrder();
            }
        }

        }
    }
}
