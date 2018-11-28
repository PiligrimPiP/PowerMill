using Konstantin.PowerMill.Messanger;

namespace Konstantin.PowerMill.ViewModel
{
    public interface IController
    {
        Messenger Messenger
        {
            get;
        }
    }
}