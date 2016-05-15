using System;
using System.Windows.Forms;

namespace week2_Observer
{
    public interface IForecaster
    {
        void Update(Weather weather);
    }

    public class Forecaster : IForecaster
    {
        private Label _device;

        public Forecaster(Label device)
        {
            _device = device;
            Attached = true;
        }

        public Weather Weather { get; set; }

        public bool Attached { get; set; }

        public void Update(Weather weather)
        {
            _device.Text =  weather.GetType().Name + Environment.NewLine +weather.Temperature + " " + weather.Metric;
        }


    }
}