using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Presenters;
using MvvmCrossApplication1.Core;
using UIKit;

namespace MvvmCrossApplication1.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
        }

        //public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
        //    : base(applicationDelegate, window)
        //{
        //}

        //public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
        //    : base(applicationDelegate, presenter)
        //{
        //}

        //protected override IMvxApplication CreateApp()
        //{
        //    return new Core.App();
        //}

        //protected override IMvxTrace CreateDebugTrace()
        //{
        //    return new DebugTrace();
        //}
    }
}
