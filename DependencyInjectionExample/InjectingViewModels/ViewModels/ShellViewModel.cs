using Caliburn.Micro;
using InjectingViewModels.ViewModels.Printers;

namespace InjectingViewModels.ViewModels
{
    public class ShellViewModel : Screen
    {
        public IPrinterViewModel PrinterVm { get; set; }

        public ShellViewModel(IPrinterViewModel printerVm)
        {
            PrinterVm = printerVm;

            /// This will print text differently depending on which
            /// implementation was used.
            /// See more in Bootstrapper.
            PrinterVm.Print("Hello World!");
        }
    }
}
