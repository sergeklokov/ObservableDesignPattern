using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableDesignPattern
{
    class Observable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

    }

    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Something happened to " + sender);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new Observable();
            Observer observer = new Observer();

            observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();

            Console.WriteLine("End of work, please press any key.");
            Console.ReadKey();
        }
    }
}
