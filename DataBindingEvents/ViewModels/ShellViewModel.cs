using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace DataBindingEvents
{
    [Export(typeof(ShellViewModel))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
                NotifyOfPropertyChange(() => CanIncrementCount);
                NotifyOfPropertyChange(() => CanDecrementCount);
            }
        }

        public bool CanIncrementCount
        {
            get { return Count < 100; }
        }

        public bool CanDecrementCount
        {
            get { return Count > 0; }
        }

        public void IncrementCount(int delta)
        {
            Count += delta;
        }

        public void DecrementCount(int delta)
        {
            Count -= delta;
        }

    }
}