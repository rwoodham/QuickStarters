#region Using Statements
using System.Linq;
using MangomacoProject.Services;
using MangomacoProject.Scenes;
using WaveEngine.Common;
using WaveEngine.Components;
using WaveEngine.Framework.Services;
using WaveEngine.Components.Transitions;
using System;
#endregion

namespace MangomacoProject
{
    /// <summary>
    /// Game class
    /// </summary>
    public class Game : WaveEngine.Framework.Game
    {
        /// <summary>
        /// Initializes the game according to the passed application (thus adapter).
        /// The adapter implementation depends on the while-running platform.
        /// Such method acts as the bridge between the game and the final hardware.
        /// </summary>
        /// <param name="application">The application (adapter).</param>
        public override void Initialize(IApplication application)
        {
            base.Initialize(application);

            WaveServices.RegisterService(new SimpleSoundService());
            WaveServices.RegisterService(new LevelInfoService());            

            // ViewportManager is used to automatically adapt resolution to fit screen size
            ViewportManager vm = WaveServices.ViewportManager;
            vm.Activate(1280, 720, ViewportManager.StretchMode.UniformToFill);

            ScreenContext screenContext = new ScreenContext("MainScene", new MainScene());
            WaveServices.ScreenContextManager.To(screenContext);
        }       
    }
}