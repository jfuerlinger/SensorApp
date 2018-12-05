using System;
using System.Collections.Generic;
using System.Text;

namespace SensorApp
{
    public class Sensor
    {
        //public delegate void NewValueHandler(double value);

        public string Name { get;  }

        private List<double> _values;

        public event Action<double> NewValue; 

        public Sensor(string name)
        {
            Name = name;
            _values = new List<double>();
        }

        public void AddValue(double value)
        {
            _values.Add(value);
            
            // => Benachrichtigen 
            
            // Option 1
            //if (NewValue != null)
            //{
            //    NewValue(value);
            //}

            // Option 2
            NewValue?.Invoke(value);
        }
    }
}
