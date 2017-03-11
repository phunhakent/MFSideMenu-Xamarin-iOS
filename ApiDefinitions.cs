using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MFSideMenu
{
	// @interface MFSideMenuShadow : NSObject
	[BaseType (typeof(NSObject))]
	interface MFSideMenuShadow
	{
		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) UIView * shadowedView;
		[Export ("shadowedView", ArgumentSemantic.Assign)]
		UIView ShadowedView { get; set; }

		// +(MFSideMenuShadow *)shadowWithView:(UIView *)shadowedView;
		[Static]
		[Export ("shadowWithView:")]
		MFSideMenuShadow ShadowWithView (UIView shadowedView);

		// +(MFSideMenuShadow *)shadowWithColor:(UIColor *)color radius:(CGFloat)radius opacity:(CGFloat)opacity;
		[Static]
		[Export ("shadowWithColor:radius:opacity:")]
		MFSideMenuShadow ShadowWithColor (UIColor color, nfloat radius, nfloat opacity);

		// -(void)draw;
		[Export ("draw")]
		void Draw ();

		// -(void)shadowedViewWillRotate;
		[Export ("shadowedViewWillRotate")]
		void ShadowedViewWillRotate ();

		// -(void)shadowedViewDidRotate;
		[Export ("shadowedViewDidRotate")]
		void ShadowedViewDidRotate ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MFSideMenuStateNotificationEvent;
		[Field ("MFSideMenuStateNotificationEvent", "__Internal")]
		NSString MFSideMenuStateNotificationEvent { get; }
	}

	// @interface MFSideMenuContainerViewController : UIViewController <UIGestureRecognizerDelegate>
	[BaseType (typeof(UIViewController))]
	interface MFSideMenuContainerViewController : IUIGestureRecognizerDelegate
	{
		// +(MFSideMenuContainerViewController *)containerWithCenterViewController:(id)centerViewController leftMenuViewController:(id)leftMenuViewController rightMenuViewController:(id)rightMenuViewController;
		[Static]
		[Export ("containerWithCenterViewController:leftMenuViewController:rightMenuViewController:")]
		MFSideMenuContainerViewController ContainerWithCenterViewController (NSObject centerViewController, NSObject leftMenuViewController, NSObject rightMenuViewController);

		// @property (nonatomic, strong) id centerViewController;
		[Export ("centerViewController", ArgumentSemantic.Strong)]
		NSObject CenterViewController { get; set; }

		// @property (nonatomic, strong) UIViewController * leftMenuViewController;
		[Export ("leftMenuViewController", ArgumentSemantic.Strong)]
		UIViewController LeftMenuViewController { get; set; }

		// @property (nonatomic, strong) UIViewController * rightMenuViewController;
		[Export ("rightMenuViewController", ArgumentSemantic.Strong)]
		UIViewController RightMenuViewController { get; set; }

		// @property (assign, nonatomic) MFSideMenuState menuState;
		[Export ("menuState", ArgumentSemantic.Assign)]
		MFSideMenuState MenuState { get; set; }

		// @property (assign, nonatomic) MFSideMenuPanMode panMode;
		[Export ("panMode", ArgumentSemantic.Assign)]
		MFSideMenuPanMode PanMode { get; set; }

		// @property (assign, nonatomic) CGFloat menuAnimationDefaultDuration;
		[Export ("menuAnimationDefaultDuration")]
		nfloat MenuAnimationDefaultDuration { get; set; }

		// @property (assign, nonatomic) CGFloat menuAnimationMaxDuration;
		[Export ("menuAnimationMaxDuration")]
		nfloat MenuAnimationMaxDuration { get; set; }

		// @property (assign, nonatomic) CGFloat menuWidth;
		[Export ("menuWidth")]
		nfloat MenuWidth { get; set; }

		// @property (assign, nonatomic) CGFloat leftMenuWidth;
		[Export ("leftMenuWidth")]
		nfloat LeftMenuWidth { get; set; }

		// @property (assign, nonatomic) CGFloat rightMenuWidth;
		[Export ("rightMenuWidth")]
		nfloat RightMenuWidth { get; set; }

		// @property (nonatomic, strong) MFSideMenuShadow * shadow;
		[Export ("shadow", ArgumentSemantic.Strong)]
		MFSideMenuShadow Shadow { get; set; }

		// @property (assign, nonatomic) BOOL menuSlideAnimationEnabled;
		[Export ("menuSlideAnimationEnabled")]
		bool MenuSlideAnimationEnabled { get; set; }

		// @property (assign, nonatomic) CGFloat menuSlideAnimationFactor;
		[Export ("menuSlideAnimationFactor")]
		nfloat MenuSlideAnimationFactor { get; set; }

		// -(void)toggleLeftSideMenuCompletion:(void (^)(void))completion;
		[Export ("toggleLeftSideMenuCompletion:")]
		void ToggleLeftSideMenuCompletion (Action completion);

		// -(void)toggleRightSideMenuCompletion:(void (^)(void))completion;
		[Export ("toggleRightSideMenuCompletion:")]
		void ToggleRightSideMenuCompletion (Action completion);

		// -(void)setMenuState:(MFSideMenuState)menuState completion:(void (^)(void))completion;
		[Export ("setMenuState:completion:")]
		void SetMenuState (MFSideMenuState menuState, Action completion);

		// -(void)setMenuWidth:(CGFloat)menuWidth animated:(BOOL)animated;
		[Export ("setMenuWidth:animated:")]
		void SetMenuWidth (nfloat menuWidth, bool animated);

		// -(void)setLeftMenuWidth:(CGFloat)leftMenuWidth animated:(BOOL)animated;
		[Export ("setLeftMenuWidth:animated:")]
		void SetLeftMenuWidth (nfloat leftMenuWidth, bool animated);

		// -(void)setRightMenuWidth:(CGFloat)rightMenuWidth animated:(BOOL)animated;
		[Export ("setRightMenuWidth:animated:")]
		void SetRightMenuWidth (nfloat rightMenuWidth, bool animated);

		// -(UIPanGestureRecognizer *)panGestureRecognizer;
		[Export ("panGestureRecognizer")]
		[Verify (MethodToProperty)]
		UIPanGestureRecognizer PanGestureRecognizer { get; }
	}

	// @interface MFSideMenuAdditions (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_MFSideMenuAdditions
	{
		// @property (readonly, retain, nonatomic) MFSideMenuContainerViewController * menuContainerViewController;
		[Export ("menuContainerViewController", ArgumentSemantic.Retain)]
		MFSideMenuContainerViewController MenuContainerViewController { get; }
	}
}
