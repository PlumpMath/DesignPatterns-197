using System;
using System.Windows.Forms;

namespace week2_Observer
{
    public interface IForecaster
    {
        void Update(WeatherData weatherStation);
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

        public void Update(WeatherData weatherData)
        {
            _device.Text = "temp: " + weatherData.Temperature1 + Environment.NewLine
                           + "hum: " + weatherData.Humidity1 + Environment.NewLine
                           + "pres: " + weatherData.Pressure;
        }

    }
}