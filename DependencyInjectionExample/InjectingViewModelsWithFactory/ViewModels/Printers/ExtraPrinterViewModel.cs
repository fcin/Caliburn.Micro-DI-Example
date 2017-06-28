using Caliburn.Micro;

namespace InjectingViewModelsWithFactory.ViewModels.Printers
{
    public class ExtraPrinterViewModel : PropertyChangedBase, IPrinterViewModel
    {
        public ExtraPrinterViewModel()
        {

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
