using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstcractClass
{
    class Plane:Vehicle
    {
        public string CityFrom {  get; set; }
        public string CityTo {  get; set; }
        public Plane(int a, int b, string cityFrom, string cityTo) : base(a, b)
        {
            CityFrom = cityFrom;
            CityTo = CityTo;
        }
        public override void SpeedDown()
        {
            curSpeed = curSpeed - 20;
        }

        public override void SpeedUp()
        {
            curSpeed = curSpeed + 20;
            if (maxSpeed <= curSpeed)
                curSpeed = maxSpeed;
        }

        public override string Way()
        {
            return "из " + CityFrom + " в " + CityTo;
        }
    }
}
