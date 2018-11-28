using Konstantin.PowerMill.ViewModel;

namespace Konstantin.PowerMill.Controller
{
    public partial class MainController : IMainController
    {
        #region Members
        #endregion

        #region IMainController Implementation
        public void DemoProperty()
        {
            Messenger.NotifyColleagues(Messanger.MessageTypes.TEST_MESSAGE);
        }
        #endregion

        #region Private methods
        #endregion
    }
}
