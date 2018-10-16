using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamisk_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Fukt<T>
        {
            class Node
            {
                T data;
                Node next;
                public Node(T d)
                {
                    data = d;
                    next = null;
                }
            }
            class LänkadLista
            {
                Node head;
            }
            protected T[] listning;
            protected int swagger;
            protected int längd;
            protected int antal;

            public void Värden()
            {
                swagger = 30;
                antal = 0;
                längd = 30;
                listning = new T[längd];
            }

            protected void Förstora(int storlek)
            {
                if (storlek < 1) return;

                T[] temp = new T[längd + storlek];

                for (int i = 0; i < antal; i++) temp[i] = listning[i];

                listning = temp;
                längd += storlek;
            }

            protected void Förminska()
            {
                T[] temp = new T[antal];

                for (int i = 0; i < antal; i++) temp[i] = listning[i];

                listning = temp;
                längd = antal;
            }

            public void LäggTill(T e)
            {
                if (antal + 1 > längd) Förstora(1 + swagger);

                listning[antal++] = e;
            }

            public T TaBort(int index)
            {
                T temp = listning[index];

                for (int i = index; i < antal - 1; i++)
                {
                    listning[i] = listning[i + 1];
                }

                antal--;
                if (längd - antal > swagger) Förminska();

                return temp;
            }

        }
    }
}