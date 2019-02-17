using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Binary_Tree
    {
        public Binary_Tree()
        {
            Node root = new Node();
            Node temp = new Node();

            while (root == null)
            {
                root = new Node;
            }
        }

        public void insert(int data)
        {
            Node Node = new Node(data);

            if (data <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
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
            if (right != null)
            {
                right.printInOrder();
            }
        }


    }
}
