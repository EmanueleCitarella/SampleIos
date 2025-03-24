namespace iOSExampleApplication;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Window = new UIWindow(UIScreen.MainScreen.Bounds);
        UIStoryboard storyboard = UIStoryboard.FromName("LaunchScreen", null);
        UIViewController initialViewController = storyboard.InstantiateInitialViewController();
        Window.RootViewController = initialViewController;
        Window.MakeKeyAndVisible();
        
        return true;
    }
}