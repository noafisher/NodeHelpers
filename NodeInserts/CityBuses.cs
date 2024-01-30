using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    internal class CityBuses
    {
        private string cityName;
        private Node<Bus> BusLines;

        public CityBuses(string cityName, Node<Bus> busLines)
        {
            this.cityName = cityName;
            BusLines = busLines;
        }

        public string GetCityName() { return cityName; }
        public Node<Bus> GetBusLines() {  return BusLines; }

        public void SetCityName(string CityName) { this.cityName = CityName; }
        public void SetBusLines(Node<Bus> node) { BusLines = node; }    

    }
}
