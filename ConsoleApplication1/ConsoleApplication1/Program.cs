using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Model1 db = new Model1();
          //  List<StateModel> stateList = new List<StateModel>();
          //  List<DispatcherModel> dispatcherList = new List<DispatcherModel>();

            //Console.WriteLine("Въведете брой състояния:");
            //int numberState = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberState; i++)
            //{
            //    StateModel state = new StateModel();
            //    state.State = Console.ReadLine();
            //    stateList.Add(state);
            //}

            Console.WriteLine("Въведете брой преходи:");
            int numberTransition = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете състояние-преход-състояние: ");
            for (int i = 0; i < numberTransition; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                Dispatchers dispatcher = new Dispatchers();

                 //  var ifState = db.States.Any(x => x.State == input[0]);
                //if (!ifState)
                //{
                //    
                //}
                //else
                //{
                //    dispatcher.States.State =
                //        db.States.Where(x => x.State == input[0]).Select(l => l.State).FirstOrDefault();
                //}

                dispatcher.States.State = input[0];
                dispatcher.Trasitions.Trasition = input[1];
                dispatcher.States1.State = input[2];

                //dispatcher.CurrentState.State = input[0];
                //dispatcher.Transition.Trasition = input[1];
                //dispatcher.NextState.State = input[2];

                db.Dispatchers.Add(dispatcher);
                db.SaveChanges();
                // dispatcherList.Add(dispatcher);
            }

            
            
            //Console.WriteLine("Вие въведохте следните състояния: ");
            //for (int i = 0; i < stateList.Count - 1; i++)
            //{
            //    Console.Write(stateList[i].State + ", ");
            //}

            //Console.WriteLine(stateList[stateList.Count - 1].State);

            //Console.WriteLine("Вие въведохте състояние-преход-състояние: ");
            //for (int i = 0; i < dispatcherList.Count; i++)
            //{
            //    Console.WriteLine(dispatcherList[i].CurrentState.State + " -> " + dispatcherList[i].Transition.Trasition +
            //        " -> " + dispatcherList[i].NextState.State);
            //}
        }
    }
}