using System;
using System.Collections.Generic;
using System.Threading;

namespace Event
{
    public class Delay
    {
        private List<Soldier> _soldiers = new List<Soldier> { };

        // initialize delegate (handler) and event
        public delegate void AddingFinishedHandler(object sender, EventArgs e);
        public event AddingFinishedHandler AddingFinished;

        public delegate void AddSoldierHandler(object sender, AddSoldierEventArgs e);
        public event AddSoldierHandler AddSoldier;

        public Delay()
        {
            // assign handlers to event
            AddingFinished += new AddingFinishedHandler(OnAddingFinished);
            AddSoldier += new AddSoldierHandler(OnAddSoldier);
        }

        // when calling action, it delegates the handler to this
        private void OnAddingFinished(object sender, EventArgs e)
        {
            foreach (var soldier in _soldiers)
            {
                Console.WriteLine($"{soldier.Name} Age: {soldier.Age}");
            }
        }

        // and this
        private void OnAddSoldier(object sender, AddSoldierEventArgs e)
        {
            _soldiers.Add(new Soldier(e.Name, e.Age));
        }

        // dispatching the actions
        public void Run()
        {
            AddSoldier(this, new AddSoldierEventArgs() { Name = "Josef", Age = 28 });
            AddSoldier(this, new AddSoldierEventArgs() { Name = "Otto", Age = 19 });
            AddingFinished(this, EventArgs.Empty);
        }
    }

    public class Soldier
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Soldier(string name, int age)
        {
            Age = age; 
            Name = name;
        }
    }

    // standardized object to store complex event args
    public class AddSoldierEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
