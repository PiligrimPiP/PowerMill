using System;
using System.Collections.ObjectModel;
using Konstantin.PowerMill.Messanger;

namespace Konstantin.PowerMill.ViewModel
{
    /// <summary>
    /// A base class for all view models.
    /// Makes ViewModels be Observable. Any ViewModel has assosiated View.
    /// Any ViewModel get a reference to CurrentMachine
    /// </summary>
    public class BaseViewModel : ObservableObject
    {
        #region Constructor
        // <summary>
        /// Parameterless Constructor required for support of DesignTime versions of View Models
        /// </summary>
        public BaseViewModel()
        {
        }

        /// <summary>
        /// A view model needs a controller reference
        /// </summary>
        /// <param name="controller"></param>
        public BaseViewModel(IController controller)
        {
            Controller = controller;
        }
        #endregion

        #region Controller
        /// <summary>
        /// Если ViewModel хоть что-то выполняет, у нее должен быть контроллер
        /// </summary>
        protected IController Controller { get; set; }
        #endregion

        #region Abstract methods
        // : Каждая ViewModel должна оповещать MainController об измененияхз 

        #endregion
    }
}
