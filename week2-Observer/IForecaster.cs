using System;
using System.Windows.Forms;

namespace week2_Observer
{
    public interface IForecaster
    {
        void Update(IWeatherData weatherStation);
    }

    public class Forecaster : IForecaster
    {
        private Label _device;

        public Forecaster(Label device)
        {
            _device = device;
            Attached = true;
        }

        public bool Attached { get; set; }

        public void Update(IWeatherData weatherData)
        {
            WeatherData temp = (WeatherData) weatherData;
            _device.Text = "temp: " + temp.Temperature1 + Environment.NewLine
                           + "hum: " + temp.Humidity1 + Environment.NewLine
                           + "pres: " + temp.Pressure;
        }

    }
}