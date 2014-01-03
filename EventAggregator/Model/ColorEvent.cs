using System.Windows.Media;

namespace EventAggregator
{
    public class ColorEvent
    {
        public ColorEvent(SolidColorBrush color)
        {
            Color = color;
        }

        public SolidColorBrush Color { get; private set; }
    }
}
