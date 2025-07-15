using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using PrismTextInputProject.Views;

namespace PrismTextInputProject
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TextFieldView1>();
            containerRegistry.RegisterForNavigation<TextFieldView2>();
            containerRegistry.RegisterForNavigation<TextFieldView3>();
            containerRegistry.RegisterForNavigation<TextFieldView4>();
            containerRegistry.RegisterForNavigation<TextInputView>();
        }
    }
}
