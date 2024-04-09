
using _03.Telephony.Core.Interfaces;
using _03.Telephony.IO;
using _03.Telephony.IO.Interfaces;

namespace _03.Telephony.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] phoneNumbers = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<ICallable> callers = new List<ICallable>();

            SmartPhone smarthphone = new SmartPhone();
            ICallable Stationary = new StationaryPhone();


            callers.Add(smarthphone); callers.Add(Stationary);


            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    callers.ForEach(x => writer.WriteLine(x.Call(phoneNumber)));
                }
                catch (ArgumentException e)
                {
                    writer.WriteLine(e.Message);
                }

            }

            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLine(smarthphone.Browse(url));
                }
                catch (ArgumentException e)
                {
                    writer.WriteLine(e.Message);
                }

            }




        }
    }
}
