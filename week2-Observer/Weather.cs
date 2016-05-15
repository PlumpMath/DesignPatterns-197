using System;
using System.Collections.Generic;

namespace week2_Observer
{
    public abstract class Weather
    {
        private string _metric;
        private double _temperature;
        private List<IForecaster> _forecasters = new List<IForecaster>();

        public Weather(string metric, double temperature)
        {
            this._metric = metric;
            this._temperature = temperature;
        }

        public void Attach(IForecaster forecaster)
        {
            _forecasters.Add(forecaster);
        }

        public void Detach(IForecaster forecaster)
        {
            _forecasters.Remove(forecaster);
        }

        public void Notify()
        {
            foreach (IForecaster forecaster in _forecasters)
            {
                forecaster.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the temperature
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    Notify();
                }
            }
        }

        // Gets the metric
        public string Metric
        {
            get { return _metric; }
        }
    }

    public class Eindhoven : Weather
    {
        public Eindhoven(string metric, double temperature) 
            : base(metric, temperature)
        {
        }
    }

    public class Amsterdam : Weather
    {
        public Amsterdam(string metric, double temperature) 
            : base(metric, temperature)
        {
        }
    }
}