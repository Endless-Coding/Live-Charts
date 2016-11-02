﻿//The MIT License(MIT)

//copyright(c) 2016 Alberto Rodriguez

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using Windows.Foundation;
using Windows.UI.Xaml.Media;

namespace LiveCharts.Uwp
{
    /// <summary>
    /// Interaction logic for HeatColorRange.xaml
    /// </summary>
    public partial class HeatColorRange
    {
        public HeatColorRange()
        {
            InitializeComponent();
        }

        public void UpdateFill(GradientStopCollection stops)
        {
            var brush = Background as LinearGradientBrush;
            if (brush == null || brush.GradientStops != stops)
            {
                Background = new LinearGradientBrush
                {
                    StartPoint = new Point(0, 0),
                    EndPoint = new Point(0, 1),
                    GradientStops = stops
                };
            }
        }

        public double SetMax(string value)
        {
            MaxVal.Text = value;
            MaxVal.UpdateLayout();
            return MaxVal.ActualWidth;
        }

        public double SetMin(string value)
        {
            MinVal.Text = value;
            MinVal.UpdateLayout();
            return MinVal.ActualWidth;
        }
    }
}