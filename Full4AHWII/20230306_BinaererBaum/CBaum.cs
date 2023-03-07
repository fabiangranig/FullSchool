using System;
using System.Collections.Generic;
using System.Text;

namespace _20230306_BinaererBaum
{
    class CBaum
    {
        //variables
        public CNode Wurzel;

        //construktor
        public CBaum()
        {
            this.Wurzel = null;
        }

        //Insert Element
        public void Insert(int Elem)
        {
            InsertBackend(ref this.Wurzel, Elem);
        }
        private void InsertBackend(ref CNode root, int Elem)
        {
            if(root == null)
            {
                root = new CNode(Elem);
                return;
            }

            if(Elem < root.Element)
            {
                InsertBackend(ref root.LTeil, Elem);
            }
            else
            {
                InsertBackend(ref root.RTeil, Elem);
            }
        }

        //ShowPreorder
        public void AnzeigenPreorder()
        {
            AnzeigenBackendPreorder(this.Wurzel);
        }
        private void AnzeigenBackendPreorder(CNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Element);
                AnzeigenBackendPreorder(root.LTeil);
                AnzeigenBackendPreorder(root.RTeil);
            }
        }

        //ShowInorder
        public void AnzeigenInorder()
        {
            AnzeigenBackendInorder(this.Wurzel);
        }
        private void AnzeigenBackendInorder(CNode root)
        {
            if(root != null)
            {
                AnzeigenBackendInorder(root.LTeil);
                Console.WriteLine(root.Element);
                AnzeigenBackendInorder(root.RTeil);
            }
        }

        //ShowPostorder
        public void AnzeigenPostorder()
        {
            AnzeigenBackendPostorder(this.Wurzel);
        }
        private void AnzeigenBackendPostorder(CNode root)
        {
            if (root != null)
            {
                AnzeigenBackendPostorder(root.LTeil);
                AnzeigenBackendPostorder(root.RTeil);
                Console.WriteLine(root.Element);
            }
        }

        //Search CNode
        public CNode Search(int searched)
        {
            return SearchBackend(this.Wurzel, searched);
        }
        private CNode SearchBackend(CNode tree, int searched)
        {
            if(tree == null)
            {
                return null;
            }

            if(tree.Element == searched)
            {
                return tree;
            }

            if(tree.Element > searched)
            {
                return SearchBackend(tree.LTeil, searched);
            }

            if (tree.Element < searched)
            {
                return SearchBackend(tree.RTeil, searched);
            }

            //When there is no solution found
            return null;
        }


        //InsertTree
        private void InsertTree(CNode root)
        {
            if (root != null)
            {
                Insert(root.Element);
                InsertTree(root.LTeil);
                InsertTree(root.RTeil);
            }
        }

        //Delete CNode slow
        public void Delete_slow(int Elem)
        {
            DeleteBackend_slow(ref this.Wurzel, Elem);
        }
        private void DeleteBackend_slow(ref CNode tree, int searched)
        {
            if (tree == null)
            {
                return;
            }

            if (tree.Element == searched)
            {
                CNode Left = tree.LTeil;
                CNode Right = tree.RTeil;

                tree = null;

                InsertTree(Left);
                InsertTree(Right);

                return;
            }

            if (tree.Element > searched)
            {
                DeleteBackend_slow(ref tree.LTeil, searched);
            }

            if (tree.Element < searched)
            {
                DeleteBackend_slow(ref tree.RTeil, searched);
            }
        }

        //Delete CNode
        public void Delete(int Elem)
        {
            DeleteBackend(ref this.Wurzel, Elem);
        }
        private void DeleteBackend(ref CNode tree, int Elem)
        {
            if (tree == null)
            {
                return;
            }

            if(tree.Element == Elem)
            {
                if(tree.LTeil == null)
                {
                    tree = tree.RTeil;
                }
                else if(tree.RTeil == null)
                {
                    tree = tree.LTeil;
                }
                else
                {
                    CNode minNode = tree.RTeil;
                    while(minNode.LTeil != null)
                    {
                        minNode = minNode.LTeil;
                    }
                    tree.Element = minNode.Element;
                    DeleteBackend(ref tree.RTeil, minNode.Element);
                }

                return;
            }

            if (tree.Element > Elem)
            {
                DeleteBackend(ref tree.LTeil, Elem);
            }

            if (tree.Element < Elem)
            {
                DeleteBackend(ref tree.RTeil, Elem);
            }
        }
    }
}