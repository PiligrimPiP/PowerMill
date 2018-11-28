using Konstantin.PowerMill.Services;
//using Konstantin.PowerMill.View;

namespace Konstantin.PowerMill.Controller
{
    public partial class MainController : BaseController
    {
        #region Members
        private static IMainService _mainService;
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor - we must pass a service to the constructor
        /// </summary>
        private MainController()
        {
        }
        /// <summary>
        /// The controller needs a reference to the service layer to enable it 
        /// to make service calls
        /// </summary>
        /// <param name="mainservice"></param>

        public MainController(IMainService mainservice)
        {
            _mainService = mainservice;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Main entry point of the Controller.
        /// Called once (from App.xaml.cs) this will initialise the application
        /// </summary>
        public void StartStandalone()
        {
            
        }
        //public PluginPane StartPlugin()
        //{
            
        //}
        #endregion
    }
}
