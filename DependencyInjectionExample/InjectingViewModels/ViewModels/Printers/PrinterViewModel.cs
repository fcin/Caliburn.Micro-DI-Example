using Caliburn.Micro;

namespace InjectingViewModels.ViewModels.Printers
{
    public class PrinterViewModel : PropertyChangedBase, IPrinterViewModel
    {
        public PrinterViewModel()
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
