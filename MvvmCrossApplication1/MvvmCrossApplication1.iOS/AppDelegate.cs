using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MvvmCrossApplication1.Core;

namespace MvvmCrossApplication1.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        //public override UIWindow Window
        //{
        //    get;
        //    set;
        //}

        //public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        //{
        //    Window = new UIWindow(UIScreen.MainScreen.Bounds);

        //    var setup = new Setup(this, Window);
        //    setup.Initialize();

        //    var startup = Mvx.Resolve<IMvxAppStart>();
        //    startup.Start();

        //    Window.MakeKeyAndVisible();

        //    return true;
        //}
    }
}
