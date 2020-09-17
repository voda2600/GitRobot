using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstcractClass
{
    public abstract class Vehicle
    {
        protected int maxSpeed,curSpeed;
        public abstract void SpeedUp();
        public abstract void SpeedDown();
        public abstract string Way();
        public Vehicle(int cs,int ms ) 
        {
            curSpeed = cs;
            maxSpeed = ms;
        }
        public override string ToString()
        {
            return "Скорость сейчас :"+curSpeed;
        }
    }
}
