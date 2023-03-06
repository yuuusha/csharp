using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class Node : IComparable
    {
        public char inf;
        public int freq;
        public int height;
        public string code;
        public Node left;
        public Node right;

        public Node(char ch, int fr, int ht = 0)
        {
            inf = ch;
            freq = fr;
            height = ht;
            code = "";
            left = null;
            right = null;
        }

        public Node(char ch, int fr, int ht, Node l, Node r) : this(ch, fr, ht)
        {
            left = l;
            right = r;
        } 

        public static Node Concatenation(Node A, Node B)
        {
            Node newNode = new Node('\0', A.freq + B.freq, Math.Max(A.height, B.height)+1, A, B);
            return newNode;
        }

        public int CompareTo(object a)
        {
            Node A = a as Node;
            if (freq != A.freq)
                return freq.CompareTo(A.freq);
            return height.CompareTo(A.height);
            
        }

        public static void Preorder(Node r) //прямой обход дерева
        {
            if (r != null)
            {
                Console.Write("{0}({1}):{2} |", r.inf, r.freq, r.code);
                Preorder(r.left);
                Preorder(r.right);
            }
        }

        public static void FormCode(Node r, string str)
        {
            if (r != null)
            {
                FormCode(r.left, str+"0");
                FormCode(r.right, str+"1");

                if (r.inf != '\0')
                {
                    r.code = str.ToString();
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader IN = new StreamReader("input_h.txt", Encoding.GetEncoding(1251)))
            {
                string s = IN.ReadToEnd();
                Dictionary<char, int> alphabet = new Dictionary<char, int>();

                foreach (char x in s)
                {
                    if (alphabet.ContainsKey(x))
                        alphabet[x] += 1;
                    else
                        alphabet.Add(x, 1);
                }

                //foreach (var x in alphabet)
                //{
                //    Console.WriteLine("{0}({1}) ", x.Key, x.Value);
                //}

                List<Node> set = new List<Node>();

                foreach (var x in alphabet)
                {
                    set.Add(new Node(x.Key, x.Value, 0));
                }
                set.Sort();

                //foreach (var x in set)
                //{
                //    Console.WriteLine("{0}({1}) ", x.inf, x.freq);
                //}

                while (set.Count > 1)
                {
                    Node tmp = Node.Concatenation(set[0], set[1]);
                    set.RemoveAt(0);
                    set.RemoveAt(0);
                    set.Add(tmp);
                    set.Sort();
                }

                string ss = "";
                Node.FormCode(set[0], ss);

                Node.Preorder(set[0]);
                
            }
        }
    }
}
