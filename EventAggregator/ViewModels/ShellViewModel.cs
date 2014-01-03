using System.Threading.Tasks;
using System.Windows.Media;
using Caliburn.Micro;

namespace EventAggregator
{
    public class ShellViewModel : PropertyChangedBase, IShell, IHandle<object>, IHandle<string>, IHandle<ColorEvent>
    {
        private readonly IColor _color;
        private readonly IEventAggregator _eventAggregator;
        public IColor ColorModel { get; private set; }

        public ShellViewModel(IColor colorModel, IEventAggregator eventAggregator)
        {
            ColorModel = colorModel;

            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

            _eventAggregator.Publish("Hello");

            // Example of running message on seperate thread
            _eventAggregator.Publish(new ColorEvent(new SolidColorBrush(Colors.LightGray)), action => Task.Factory.StartNew(action));
        }

        private SolidColorBrush _Color;

        public SolidColorBrush Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                NotifyOfPropertyChange(() => Color);
            }
        }

        public void Handle(string message)
        {
            var s = "This is the string";
        }

        public void Handle(object message)
        {
            var s = "This is the object string";
        }

        public void Handle(ColorEvent message)
        {
            Color = message.Color;
        }
    }
}