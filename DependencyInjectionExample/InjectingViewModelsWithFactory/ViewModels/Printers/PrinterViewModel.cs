using Caliburn.Micro;

namespace InjectingViewModelsWithFactory.ViewModels.Printers
{
    public class PrinterViewModel : PropertyChangedBase, IPrinterViewModel
    {
        private readonly IEventAggregator _eventAggregator;

        /*
         * Requires IEventAggregator just to show how you can create
         * classes that require additional services.
         */
        public PrinterViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                if (_text == value)
                    return;
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        public void Print(string message)
        {
            Text = message;
        }
    }
}
