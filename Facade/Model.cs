﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
   public class Camera
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the camera.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning off the camera.");
        }
        public void Rotate(int degrees)
        {
            Console.WriteLine("Rotating the camera by {0} degrees.",degrees);
        }
    }
   public class Light
   {
       public void TurnOn()
       {
           Console.WriteLine("Turning on the light.");
       }
       public void TurnOff()
       {
           Console.WriteLine("Turning off the light.");
       }
       public void ChangeBulb()
       {
           Console.WriteLine("changing the light-bulb.");
       }
   }
   public class Sensor
   {
       public void Activate()
       {
           Console.WriteLine("Activating the sensor.");
       }
       public void Deactivate()
       {
           Console.WriteLine("Deactivating the sensor");
       }
       public void Trigger()
       {
           Console.WriteLine("The sensor has triggered");
       }
   }
   public class Alarm
   {
       public void Activate()
       {
           Console.WriteLine("Activating the alarm.");
       }
       public void Deactivate()
       {
           Console.WriteLine("Deactivating the alarm.");
       }
       public void Ring()
       {
           Console.WriteLine("Ringing the alarm.");
       }
       public void StopRing()
       {
           Console.WriteLine("Stop the alarm.");
       }
   }

   public class SecurityFacade
   {
       private static Camera camera1, camera2;
       private static Light light1, light2,light3;
       private static Sensor sensor;
       private static Alarm alarm;

       static SecurityFacade()
       {
           camera1 = new Camera();
           camera2 = new Camera();
           light1 = new Light();
           light2 = new Light();
           light3 = new Light();
           sensor = new Sensor();
           alarm = new Alarm();
       }

       public void Activate()
       {
           camera1.TurnOn();
           camera2.TurnOn();
           light1.TurnOn();
           light2.TurnOn();
           light3.TurnOn();
           sensor.Activate();
           alarm.Activate();
       }
       public void Deactivate()
       {
           camera1.TurnOff();
           camera2.TurnOff();
           light1.TurnOff();
           light2.TurnOff();
           light3.TurnOff();
           sensor.Deactivate();
           alarm.Deactivate();
       }
   }

}
