using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Картинка бинарного дерева https://razilov-code.ru/wp-content/uploads/2018/10/tree1.svg
            BinaryTree tree = new BinaryTree();

            //Заполняем дерево
            tree.Add(33);
            tree.Add(5);
            tree.Add(35);
            tree.Add(1);
            tree.Add(20);
            tree.Add(99);
            tree.Add(17);
            tree.Add(18);
            tree.Add(19);
            tree.Add(31);
            tree.Add(4);

            //Обход в глубину DFS Preorder.
            tree.DFS_Preorder();
            //Обход в ширину.
            tree.BFS();
        }
    }
}
