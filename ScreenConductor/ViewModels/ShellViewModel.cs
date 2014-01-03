using Caliburn.Micro;
using ScreenConductor.ViewModels;

namespace ScreenConductor
{
    public class ShellViewModel : Conductor<object>, IShell
    {
        public void ShowRedScreen()
        {
            ActivateItem(new RedViewModel());
        }

        public void ShowGreenScreen()
        {
            ActivateItem(new GreenViewModel());
        }

        public void ShowBlueScreen()
        {
            ActivateItem(new BlueViewModel());
        }
    }
}