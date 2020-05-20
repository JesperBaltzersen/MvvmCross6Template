using AddressBookUI;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApplication1.Core.ViewModels;
using System;
using UIKit;

namespace MvvmCrossApplication1.iOS.Views
{
    public static class Colors 
    {

        public static CGColor BaseColorCG => BaseColor.CGColor;

        public static UIColor BaseColor => UIColor.FromRGB(204, 229, 255);//UIColor.FromRGB(241, 243, 246);

        
    }

    //[MvxRootPresentation(WrapInNavigationController = true)]
    [Register(nameof(FirstView))]
    public class FirstView : MvxViewController<FirstViewModel>
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = Colors.BaseColor; // UIColor.FromRGB(241,243,246);

            var Label = new UILabel(new CGRect(150, 150, 200, 60))
            {
                Text = "hello",
                BackgroundColor = UIColor.Purple//UIColor.FromRGB(241, 243, 246),
            };
            //Label.Layer.MasksToBounds = false;
            //Label.Layer.ShadowColor = UIColor.FromRGB(223, 228, 238).CGColor;
            //Label.Layer.ShadowOffset = new CGSize(4, 4);
            //Label.Layer.ShadowOpacity = 1f;
            //Label.Layer.ShadowRadius = 4;

            //var showdowlayer = new CAShapeLayer()
            //{
            //    BackgroundColor =  UIColor.FromRGB(241, 243, 246).CGColor,//UIColor.Purple.CGColor,//UIColor.FromRGB(223, 228, 238).CGColor,
            //    ShadowColor = UIColor.White.CGColor,
            //    ShadowOffset = new CGSize(-4, -4),
            //    ShadowOpacity = 1f,
            //    ShadowRadius = 4
            //};
            //showdowlayer.Frame = Label.Bounds;
            //Label.Layer.AddSublayer(showdowlayer);
            Label.NeuMorphicView();

            View.Add(Label);

            var button = new UIButton(UIButtonType.Plain)
            {
                Frame = new CGRect(140, 250, 150, 60),
                //TranslatesAutoresizingMaskIntoConstraints = false
            };
            button.SetTitle("Button", UIControlState.Normal);

            var colorLayer = new CAShapeLayer()
            {
                BackgroundColor = UIColor.Purple.CGColor
            };
            colorLayer.Frame = new CGRect(button.Bounds.X + 4, button.Bounds.Y + 4, button.Bounds.Width - 8, button.Bounds.Height - 8);
            button.Layer.AddSublayer(colorLayer);

            button.NeuMorphicView();
            //button.Layer.BorderWidth = 1;
            //button.Layer.BorderColor = UIColor.Gray.ColorWithAlpha(0.5f).CGColor;
            

            View.Add(button);

            //button.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor).Active = true;
            //button.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor).Active = true;
            //button.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;
            //button.HeightAnchor.ConstraintEqualTo(button.IntrinsicContentSize.Height).Active = true;
           
        }
    }
    public static class Extensions
    {
        public static void NeuMorphicView(this UIView uIView)
        {
            uIView.Layer.MasksToBounds = false;
            uIView.Layer.ShadowColor = UIColor.FromRGB(223, 228, 238).CGColor;
            uIView.Layer.ShadowOffset = new CGSize(4, 4);
            uIView.Layer.ShadowOpacity = 1f;
            uIView.Layer.ShadowRadius = 4;

            var showdowlayer = new CAShapeLayer()
            {
                BackgroundColor = Colors.BaseColorCG,//UIColor.FromRGB(123, 123, 123).CGColor,// UIColor.FromRGB(241, 243, 246).CGColor,//UIColor.Purple.CGColor,//UIColor.FromRGB(223, 228, 238).CGColor,
                ShadowColor = UIColor.White.CGColor,
                ShadowOffset = new CGSize(-4, -4),
                ShadowOpacity = 1f,
                ShadowRadius = 4
            };
            showdowlayer.Frame = uIView.Bounds;
            uIView.Layer.AddSublayer(showdowlayer);
        }
    }
}
