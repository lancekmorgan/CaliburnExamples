using System.Windows.Media;
using Caliburn.Micro;

namespace EventAggregator
{
    public interface IColor
    {
    }
    public class ColorViewModel:IColor
    {
        private readonly IEventAggregator _eventAggregator;

        public ColorViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void Red()
        {
            _eventAggregator.Publish(new ColorEvent(new SolidColorBrush(Colors.Red)));
        }

        public void Green()
        {
            _eventAggregator.Publish(new ColorEvent(new SolidColorBrush(Colors.Green)));
        }

        public void Blue()
        {
            _eventAggregator.Publish(new ColorEvent(new SolidColorBrush(Colors.Blue)));
        }
    }
}
