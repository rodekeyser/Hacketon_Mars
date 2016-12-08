using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using hacketonApp.Annotations;
using hacketonApp.Model;
using LiveCharts;
using LiveCharts.Configurations;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace hacketonApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Temperature : UserControl,INotifyPropertyChanged
    {
        private double _axisMax;
        private double _axisMin;

        public Temperature()
        {
            this.InitializeComponent();

            var mapper = Mappers.Xy<Data>()
               .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
               .Y(model => model.Temperature);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Data>(mapper);


            //the values property will store our values array
            ChartValues = new ChartValues<Data>();

            //lets set how to display the X Labels
            DateTimeFormatter = value => new DateTime((long)(value)).ToString("mm:ss");

            AxisStep = TimeSpan.FromSeconds(1).Ticks;
            SetAxisLimits(DateTime.Now);

            //The next code simulates data changes every 300 ms
            Timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(300)
            };
            Timer.Tick += TimerOnTick;
            IsDataInjectionRunning = false;
            R = new Random();

            DataContext = this;
        }

        public ChartValues<Data> ChartValues { get; set; }
        public Func<double, string> DateTimeFormatter { get; set; }

        public double AxisStep { get; set; }

        public double AxisMax
        {
            get { return _axisMax; }
            set
            {
                _axisMax = value;
                OnPropertyChanged("AxisMax");
            }
        }
        public double AxisMin
        {
            get { return _axisMin; }
            set
            {
                _axisMin = value;
                OnPropertyChanged("AxisMin");
            }
        }

        public DispatcherTimer Timer { get; set; }
        public bool IsDataInjectionRunning { get; set; }
        public Random R { get; set; }

        private void RunDataOnClick(object sender, RoutedEventArgs e)
        {
            if (IsDataInjectionRunning)
            {
                Timer.Stop();
                IsDataInjectionRunning = false;
            }
            else
            {
                Timer.Start();
                IsDataInjectionRunning = true;
            }
        }

        private void TimerOnTick(object sender, object eventArgs)
        {
            var now = DateTime.Now;

            ChartValues.Add(new Data
            {
                Temperature = R.Next(0, 10),
                DateTime = now,

            });

            SetAxisLimits(now);

            //lets only use the last 30 values
            if (ChartValues.Count > 30) ChartValues.RemoveAt(0);
        }

        private void SetAxisLimits(DateTime now)
        {
            AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            AxisMin = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }







        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
