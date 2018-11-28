using Konstantin.PowerMill.Messanger;
using Konstantin.PowerMill.ViewModel;

namespace Konstantin.PowerMill.Controller
{
    /// <summary>
    /// The base controller class.
    /// </summary>
    public abstract class BaseController : IController
    {
        /// <summary>
        /// Retain a reference to the single instance of the Messenger class for convenience
        /// as it means we can use Controller.Messenger.blah rather than Controller.Messenger.Instance.blah
        /// In a large system this also allows us to use multiple Messengers (e.g. for different parts of a system
        /// that have no need to communicate between them) by making a single change here to return a different Messenger 
        /// </summary>
        public Messenger Messenger
        {
            get
            {
                return Messenger.Instance;
            }
        }
    }
}
