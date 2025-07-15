using System.Windows;
using Prism.Ioc;
using Prism.Navigation.Regions;
using Prism.Unity;
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
        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion("RegionTextField1", typeof(TextFieldView1));
            regionManager.RegisterViewWithRegion("RegionTextField2", typeof(TextFieldView2));
            regionManager.RegisterViewWithRegion("RegionTextField3", typeof(TextFieldView3));
            regionManager.RegisterViewWithRegion("RegionTextField4", typeof(TextFieldView4));
            regionManager.RegisterViewWithRegion("RegionTextInput", typeof(TextInputView));
        }
    }
}
