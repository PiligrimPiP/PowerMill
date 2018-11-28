using System.Windows.Input;

namespace Konstantin.PowerMill.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Обозреваемые свойства описаны в Observable properties
        /// и связаны с приватными переменными.
        /// (сначала объявляются приватные переменные, 
        /// потом задаются обозреваемые свойства)
        /// 
        /// Обозреваемые команды описаны в Relay Commands
        /// и связаны с Command Handlers
        /// (сначала описываются получатели команд - Handlers,
        /// потом описваются Relay Commands)
        /// </summary>
        #region Members
        private string _observable_property;
        #endregion 

        #region Constructor
        private MainViewModel()
        {
        }
        public MainViewModel(IMainController controller) : base(controller)
        {

        }
        #endregion

        #region Override abstract methods
        #endregion

        #region Observable Properties
        public string Observable_property
        {
            get => _observable_property;
            set
            {
                _observable_property = value;
                RaisePropertyChanged("Observable property");
            }
        }
        #endregion

        #region Commands
            #region Command Relays
            private RelayCommand _userDoSomethingCommand;
            public ICommand UserOpenP21FileCommand
            {
                get
                {
                    return _userDoSomethingCommand ?? (_userDoSomethingCommand =
                        new RelayCommand(() => ObeyUserDoSomethingCommand()));
                }
            }
            #endregion
            #region Command Handlers
            private void ObeyUserDoSomethingCommand()
            {
                // Что должно произойти при событии.
                Observable_property = "Changed";
            }
            #endregion
        #endregion

        #region IMainController
        private IMainController MainController
        {
            get => (IMainController) Controller;
        }
        #endregion

        #region Private methods

        #endregion
    }
}
