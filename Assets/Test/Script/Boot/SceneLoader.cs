using Agate.MVC.Base;

namespace Test.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene { get { return "Splash";} }
    }
}
