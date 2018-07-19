using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{


    interface vehicle1
    {
        void engine();
        void steering();
        void tyres();
        void lights();
        void seats();
        void accelator();
        void breaking();
        void fueltank();
    }
   

    abstract class car : vehicle1
    {
        public abstract void engine();
        public abstract void steering();
        public abstract void tyres();
        public abstract void lights();
        public abstract void seats();
        public abstract void accelator();
        public abstract void breaking();
        public abstract void fueltank();


        //extra features
        public virtual void musicsystem()
        {
            Console.WriteLine("music system");
        }
        public virtual void Ac()
        {
            Console.WriteLine("air conditioner");
        }
        public virtual void airbags()
        {
            Console.WriteLine("6 airbags");
        }
        public virtual void videoplayer()
        {
            Console.WriteLine("video player");
        }
        public virtual void openroof()
        {
            Console.WriteLine("openroof");
        }
    }
    class maruthi_suzuki : car
    {
        public override void accelator()
        {
            Console.WriteLine("accelator");
        }

        public override void breaking()
        {
            Console.WriteLine("breaking");
        }

        public override void engine()
        {
            Console.WriteLine("engine");
        }

        public override void fueltank()
        {
            Console.WriteLine("fueltank");
        }

        public override void lights()
        {
            Console.WriteLine("lights");
        }

        public override void seats()
        {
            Console.WriteLine("seats");
        }

        public override void steering()
        {
            Console.WriteLine("steering");
        }

        public override void tyres()
        {
            Console.WriteLine("tyres");
        }
    }
    class bmw : car
    {
        public override void accelator()
        {
            Console.WriteLine("accelator");
        }

        public override void breaking()
        {
            Console.WriteLine("breaking");
        }

        public override void engine()
        {
            Console.WriteLine("engine");
        }

        public override void fueltank()
        {
            Console.WriteLine("fueltank");
        }

        public override void lights()
        {
            Console.WriteLine("lights");
        }

        public override void seats()
        {
            Console.WriteLine("seats");
        }

        public override void steering()
        {
            Console.WriteLine("power steering");
        }

        public override void tyres()
        {
            Console.WriteLine("tyres");
        }
        //extra
        public void secondary_camera()
        {
            Console.WriteLine("secondary camera");
        }
        public void auto_gear()
        {
            Console.WriteLine("gearshift");
        }
        public void sensors()
        {
            Console.WriteLine("sensores");
        }

    }
    class vehicle
    {

        static void Main(string[] args)
        {
            maruthi_suzuki alto800 = new maruthi_suzuki();
            alto800.accelator();//basic
            alto800.breaking();//baisc
            alto800.engine();//basic
            alto800.fueltank();//basic
            alto800.lights();//basic
            alto800.seats();//basic
            alto800.steering();//basic
            alto800.tyres();//basic
           
            maruthi_suzuki swift = new maruthi_suzuki();
            swift.accelator();
            swift.breaking();
            swift.engine();
            swift.fueltank();
            swift.lights();
            swift.seats();
            swift.steering();
            swift.tyres();
            swift.Ac();//additional
            swift.airbags();//additional

           



            bmw M760Li = new bmw();
            
            M760Li.accelator();
           
            M760Li.auto_gear();
            M760Li.breaking();
            M760Li.engine();
            M760Li.fueltank();
            M760Li.lights();
            M760Li.steering();
            M760Li.seats();


            //additional featuress
            M760Li.sensors(); 
            M760Li.Ac();
            M760Li.openroof();
            M760Li.videoplayer();
            M760Li.airbags();
            M760Li.musicsystem();
            M760Li.secondary_camera();

            
        }
    }
    
}
