using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Marriage
    {
        
        static void Main(string[] args)
        {
            Marriage m1 = new Marriage();
            m1.attend();
            Console.ReadKey();
        }
        public async void attend()
        {            
            await invite();
            Console.WriteLine("5.invite got and attended");
        }
        public async Task invite()
        {           
            await printing();
            Console.WriteLine("4.cards got printed");
        }
        public async Task printing()
        {            
            await place();
            Console.WriteLine("3.place decided");
        }
        public async Task place()
        {           
            await Date();
            Console.WriteLine("2.date confirmed");
        }
        public async Task Date()
        {
            await Task.Delay(0);
            Console.WriteLine("1.start");
        }

    }
}
