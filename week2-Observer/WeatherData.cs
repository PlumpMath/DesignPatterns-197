using System.Collections.Generic;
using System.IO;

namespace week2_Observer
{
    public interface IWeatherData
    {
        void RegisterWeatherData(IForecaster o);
        void RemoveWeatherData(IForecaster o);
        void Notify();
        float Humidity1 { get; set; }
        float Pressure { get; set; }
        float Temperature1 { get; set; }
    }

    public class WeatherData : IWeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private List<IForecaster> _forecasters;

        public WeatherData()
        {
            _forecasters = new List<IForecaster>();
        }

        public float Temperature1
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

        public float Humidity1
        {
            get { return _humidity; }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    Notify();
                }

            }
        }

        public float Pressure
        {
            get { return _pressure; }
            set
            {
                if (_pressure != value)
                {
                    _pressure = value;
                    Notify();
                }

            }
        }

        public void RegisterWeatherData(IForecaster o)
        {
            _forecasters.Add(o);
        }

        public void RemoveWeatherData(IForecaster o)
        {
            _forecasters.Remove(o);
        }

        public void Notify()
        {
            foreach (var x in _forecasters)
            {
                x.Update(this);
            }
        }
    }
}