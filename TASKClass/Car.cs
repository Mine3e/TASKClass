using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKClass
{
    internal class Car
    {
        private static int _id = 1000;
        public int Id { get; set; }

        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }
        public Car(int id, string name, int speed, string carCode)
        {
            _id++;
            Id = _id;
            Name = name;
            Speed = speed;
            carCode = name.Substring(0, 2).ToUpper();
            carCode += (id + 1000).ToString();
            CarCode = carCode;
            

        }

    }
}