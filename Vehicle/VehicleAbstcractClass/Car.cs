using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstcractClass
{
    class Car : Vehicle
    {
        public Car(int cs,int ms):base(cs,ms)
        {

        }
        public override void SpeedDown()
        {

            curSpeed = curSpeed - 5;
            
        }

        public override void SpeedUp()
        {
            curSpeed = curSpeed + 5;
            if (maxSpeed <= curSpeed)
                curSpeed = maxSpeed;
        }

        public override string Way()
        {
            return "Свободная поездка";
        }
    }
}
