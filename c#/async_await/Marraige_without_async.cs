using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class Marraige_without_async
    {

        static void Main(string[] args)
        {
            Marraige_without_async m1 = new Marraige_without_async();
            m1.attend();
            m1.invite();
            m1.printing();
            m1.place();
            m1.Date();
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
