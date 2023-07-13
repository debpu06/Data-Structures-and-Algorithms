
using System;
using Structures.Tree;

namespace Algorithms.Tree
{
    public static class Tree
    {
        //Get depth of a given leaf node of the tree
        public static int GetDepth<T>(this ITree<ILeafNode<T>> tree, ILeafNode<T> node)
        {
            if(tree.IsRoot(node))
                return 0;
            else
                return 1 + tree.GetDepth(tree.GetParent(node));
        }

        //Get the height of a tree
        public static int GetHeight<T>(this ITree<ILeafNode<T>> tree) {
            if(tree.IsEmpty())
                return 0;

            return tree.GetRoot().GetHeight();
        }

        private static int GetHeight<T>(this ILeafNode<T> node) {
            if(!node.HasChildren())
                return 0;
            
            int height = 0;
            foreach(var leaf in node.GetChildren()) {
                height = Math.Max(height, leaf.GetHeight());
            }
            return height + 1;
        }

        //Pre order traverse the tree and return the value of the node's toString as comma separated list
        public static string PreOrder<T>(this ITree<ILeafNode<T>> tree, ILeafNode<T> node) {
            string value = node.GetValue().ToString();

            foreach(ILeafNode<T> leaf in node.GetChildren()) {
                value += " ," + tree.PreOrder(leaf);
            }

            return value;
        }

        //Post order traverse the tree and return the value of the node's toString as comma separated list
        public static string PostOrder<T>(this ITree<ILeafNode<T>> tree, ILeafNode<T> node) {
            string value = string.Empty;

            foreach(ILeafNode<T> leaf in node.GetChildren()) {
                value += tree.PostOrder(leaf) + ", ";
            }

            return value += node.GetValue().ToString();
        }
    }
}