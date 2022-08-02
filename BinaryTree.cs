using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Head { get; private set; }
        /// <summary>
        /// Добавить элемент в бинарное дерево
        /// </summary>
        /// <param name="Value">Значение (int)</param>
        public void Add(int Value)
        {
            //Случай 1: Если дерево пустое, создаём корневой узел.
            if (Head == null)
            {
                Head = new Node(Value);
            }
            //Если нет, ищем позицию для элемента
            else
            {
                Add(Head, Value);
            }
        }
        /// <summary>
        /// DFS Preorder обход в глубину c распечаткой
        /// </summary>
        public void DFS_Preorder()
        {
            //Если есть голова то можем делать DFS Preorder обход
            if (Head != null)
            {
                DFS_Preorder(Head);
                Console.Write("\n");
            }
            else 
            {
                return;
            }
        }
        /// <summary>
        /// Обход в ширину
        /// </summary>
        public void BFS()
        {
            //Если нет головного узла, то BFS не имеет смысла
            if (Head == null)
            {
                return;
            }
            //Если дерево не пустое
            else
            {
                //Будем делать обход в ширину классическим методом с помощью очереди
                //Создаём очередь и заносим в неё корень
                var queue = new Queue<Node>();
                queue.Enqueue(Head);

                //Пока очередь не пуста, будем вытягивать с неё элементы
                while(queue.Count > 0)
                {
                    //Вытягиваем элемент
                    Node CurrentNode = queue.Dequeue();
                    //Печатаем
                    Console.Write($"{CurrentNode.Value} - ");
                    //Заносим в очередь левый узел
                    if(CurrentNode.Left != null) queue.Enqueue(CurrentNode.Left);
                    //Заносим в очередь правый узел
                    if (CurrentNode.Right != null) queue.Enqueue(CurrentNode.Right);
                }
                Console.Write("\n");
            }
        }
        private void DFS_Preorder(Node CurrentNode)
        {
            Console.Write($"{CurrentNode.Value} - ");
            // Идём до конца влево
            if (CurrentNode.Left != null)
            {
                DFS_Preorder(CurrentNode.Left);
            }
            //Если левее не куда, то отступаем если есть вправо
            if (CurrentNode.Right != null)
            {
                DFS_Preorder(CurrentNode.Right);
            }
        }
        private void Add(Node CurrentNode, int Value)
        {
            //Если значение добавляемого элемента x меньше значения текущего узла,
            //спускаемся к левому поддереву.
            if (Value < CurrentNode.Value)
            {
                //Если его не существует, то создаем его и присваиваем значение x.
                if (CurrentNode.Left is null)
                {
                    CurrentNode.Left = new Node(Value);
                }
                //Если существует, то обозначим левое поддерево как текущий узел и повторим сначала.
                else
                {
                    Add(CurrentNode.Left, Value);
                }
            }
            //Если значение добавляемого элемента xx больше или равно значению текущего узла,
            //спускаемся к правому поддереву.
            else
            {
                //Если его не существует, то создаем его и присваиваем значение xx.
                if (CurrentNode.Right is null)
                {
                    CurrentNode.Right = new Node(Value);
                }
                //Если существует, то обозначим правое поддерево как текущий узел и повторим сначала.
                else
                {
                    Add(CurrentNode.Right, Value);
                }
            }
        }
    }
}
