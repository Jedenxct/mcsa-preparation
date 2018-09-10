using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class Nose
    {
        public delegate void SneezeInProgressHandler(object sender, SneezeInProgressEventArgs e);

        public event SneezeInProgressHandler SneezeInProgress;

        public void Sneeze(string intensity)
        {
            OnSneezeInProgress(intensity);
        }

        private void OnSneezeInProgress(string intensity)
        {
            var del = SneezeInProgress as SneezeInProgressHandler;

            if(del != null)
            {
                del(this, new SneezeInProgressEventArgs() { Intensity = intensity });
            }
            
        } 
    }

    public class SneezeInProgressEventArgs : EventArgs
    {
        public string Intensity { get; set; }
    }
}
