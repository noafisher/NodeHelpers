using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    internal class Bus
    {
        private int busNum;
        private double price;
        private Node<Station> lst;

        public Bus(int busNum, double price, Node<Station> lst)
        {
            this.busNum = busNum;
            this.price = price;
            this.lst = lst;
        }
        public int getBusNum() { return busNum; }
        public double getPrice() { return price; }
        public Node<Station> getLst() {  return lst; }
        public void setBusNum(int busNum) { this.busNum = busNum; }
        public void SetPrice(double price) { this.price = price; }
        public void SetLst(Node<Station> lst) { this.lst = lst; }

    }
}