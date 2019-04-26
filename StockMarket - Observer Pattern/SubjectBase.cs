using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket___Observer_Pattern
{
	public abstract class SubjectBase
	{
        private List<IObserver> myObservers;

        public SubjectBase()
        {
            myObservers = new List<IObserver>();
        }

		public void Attach(IObserver o)
		{
            Console.WriteLine("Adding observer");
            myObservers.Add(o);
		}

		public void Detach(IObserver o)
		{
            myObservers.Remove(o);
		}

		protected void Notify()
		{
			foreach (IObserver o in myObservers)
            {
                Console.WriteLine("Updating observer.");
                o.UpdateObservers();
            }
		}
	}
}
