using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstcractClass
{
    class Ship : Vehicle
    {
        public string CityFrom;
        public string CityTo;
        public Ship(int a,int b, string cityFrom, string cityTo) :base(a,b)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
        }
        public override void SpeedDown()
        {
            curSpeed = curSpeed - 1;
        }

        public override void SpeedUp()
        {
            curSpeed = curSpeed + 1;
            if (maxSpeed <= curSpeed)
                curSpeed = maxSpeed;
        }

        public override string Way()
        {
            return "из "+CityFrom+" в "+CityTo;
        }
    }
}
