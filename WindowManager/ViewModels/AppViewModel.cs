using System.ComponentModel.Composition;
using System.Dynamic;
using System.Windows;
using Caliburn.Micro;

namespace WindowManager
{
    [Export(typeof(AppViewModel))]
    public class AppViewModel : PropertyChangedBase
    {
        private readonly IWindowManager _windowManager;

        [ImportingConstructor]
        public AppViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public void OpenWindow()
        {
            dynamic settings = new ExpandoObject();
            settings.WindowStartupLocation = WindowStartupLocation.Manual;
            
            _windowManager.ShowWindow(new AppViewModel(_windowManager), null, settings);
        }
    }
}