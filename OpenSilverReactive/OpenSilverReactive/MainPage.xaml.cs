using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverReactive
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
            Observable
                .Interval(TimeSpan.FromSeconds(1.0))
                .Timestamp()
                .Subscribe(RepeatAction);
        }

        private void RepeatAction(Timestamped<long> ts)
        {
            Console.WriteLine(ts.Timestamp);
            TextBlock1.Text += Environment.NewLine + ts.Timestamp;
        }
    }
}
