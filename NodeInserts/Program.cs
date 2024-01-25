using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        //
        public static bool IsThere(Node<ShabatRecievers> node, int day, int month, int year)
        {
            Node <ShabatRecievers> p = node;
            while (p != null)
            {
                if (p.GetValue().GetYear() == year && p.GetValue().GetMonth()==month && p.GetValue().GetDay() == day)
                    return true;

                p = p.GetNext();
            }

            return false;
        }

        public static void DeleteThisPerson(Node<ShabatRecievers> node, string name)
        {
            Node<ShabatRecievers> p = node;

            if (p == null)
                return;

            while (p.GetNext().GetValue().GetParent1() != name || p.GetNext().GetValue().GetParent2() != name)
            {
                p = p.GetNext();
            }

            p.SetNext(p.GetNext().GetNext());
        }

        public static int HowManyPossible(Node<Domino> lst, Domino D)
        {
            Node<Domino> p = lst;
            int counter = 0;
            while (p != null)
            {
                if (p.GetValue().GetLeftNum() == D.GetRightNum() || p.GetValue().GetRightNum() == D.GetLeftNum())
                { 
                    counter++;
                    p = p.GetNext();
                }

                else
                    p = p.GetNext();
            }

            return counter;
        }

        public static string Winner(Node<Participate> lst )
        {
            string winnerName = "";
            double max = 0; 
            Node<Participate> p = lst;  
            while (p != null)
            {
                if (p.GetValue().Decrease() > max)
                {
                    max = p.GetValue().Decrease();
                    winnerName = p.GetValue().GetName();
                }

                p= p.GetNext();
            }
            return winnerName;
        }
        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }

    }
}