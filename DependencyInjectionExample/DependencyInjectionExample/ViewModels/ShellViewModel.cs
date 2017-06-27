using Caliburn.Micro;

namespace DependencyInjectionExample.ViewModels
{
    public class ShellViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IService _service;

        public ShellViewModel(IEventAggregator eventAggregator, IService service)
        {
            _eventAggregator = eventAggregator;
            _service = service;

            _service.Method();
        }
    }
}
