using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_110
{
    class Program
    {
        class Node
        {
            public int number;
            public string name;
            public Node next;
        }
        class Queue
        {
            Node Richi, Fendrika;

            public Queue()
            {
                Richi = null;
                Fendrika = null;
            }
            public void addNumb()
            {
                int no;
                string nm;
                Console.WriteLine("Nomor Induk Murid:");
                no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nama Murid & Kelas Murid:");
                nm = Console.ReadLine();
                Node newnode = new Node();
                newnode.number = no;
                newnode.name = nm;;
                if (Richi == null || (no <= Richi.number))
                {
                    if ((Richi != null) && (no == Richi.number))
                    {
                        Console.WriteLine("Duplicate Number is not allowed");
                        return;
                    }
                    newnode.next = Richi;
                    newnode.next = Fendrika;
                    Richi = Fendrika = newnode;
                    return;
                }
                while ((Richi != null) && (no <= Richi.number)) ;
                {
                    if (no == Richi.number)
                    {
                        Console.WriteLine("Duplicate Number is not allow");
                        return;
                    }
                    Richi.next = newnode;
                    newnode = Richi;
                    return;
                }
            }
            public bool ListEmpty()
            {
                if (Richi == null)
                    return true;
                else
                    return false;
            }
            public void delNumb()
            {
                Node curr;
                curr = Richi;
                Console.WriteLine("Data yang terhapus: " + Richi.number + Richi.name);
                Richi = Richi.next;
            }
            public void displayNumb()
            {
                if (ListEmpty())
                {
                    Console.WriteLine("Belum ada data. ");
                }
                else
                {
                    Console.WriteLine("Data Murid: ");
                    Node currNode;
                    for (currNode = Richi; currNode != null; currNode = currNode.next)
                        Console.WriteLine(currNode.number + currNode.name);

                    Console.WriteLine();
                }
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Queue q = new Queue();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("a. Masukkan Data Murid");
                        Console.WriteLine("b. Hapus Data Murid");
                        Console.WriteLine("c. List Data Murid");
                        Console.WriteLine("d. Exit");
                        Console.WriteLine(" Pilih antara a-d: ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case 'a':
                                {
                                    q.addNumb();
                                }
                                break;
                            case 'b':
                                {
                                    if (q.ListEmpty())
                                    {
                                        Console.WriteLine("Belum ada data.");
                                        break;
                                    }
                                    q.delNumb();
                                }
                                break;
                            case 'c':
                                {
                                    q.displayNumb();
                                }
                                break;
                            case 'd':
                                return;
                            default:
                                {
                                    Console.WriteLine("\n Invalid Option ");
                                    break;
                                }

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n Check Again! . ");
                    }
                }
            }
        }
    }
}

//2. Queue,
//3. digunakan untuk menjalankan push dan penghapusan atau penambahan elementnya hanya dapat dilakukan pada posisi terakhir stack
//4.push.pop
//5. a.5
//5. b.Preorder