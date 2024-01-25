using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    internal class Domino
    {

        private int rightNum;
        private int leftNum;

        public Domino(int rightNum, int leftNum)
        {
            this.rightNum = rightNum;
            this.leftNum = leftNum;
        }

        public int GetRightNum() { return rightNum; }
        public int GetLeftNum() { return leftNum; }

        public void SetRightNum(int rightNum) {  this.rightNum = rightNum; }
        public void SetLeftNum(int leftNum) { this.leftNum = leftNum; }

        public bool IsExisted(Domino domino, int num)
        {
            if (num == this.leftNum || num== this.rightNum)
                return true;

            return false;
        }

    }
}
