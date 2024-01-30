using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    internal class Station
    {
        private string street;
        private int num;
        
        public Station(string street, int num)
        {
            this.street = street;
            this.num = num;
        }

        public string GetStreet()

        {
             return street;
        }

        public int GetNum()
        {
            return num;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }

        public bool Equal(Station other)
        {
            if (this.street == other.street && this.num == other.num) return true;

            return false;
        }

    }
}
