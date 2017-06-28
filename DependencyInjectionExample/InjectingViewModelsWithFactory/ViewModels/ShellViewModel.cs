using Caliburn.Micro;
using InjectingViewModelsWithFactory.ViewModels.Printers;

namespace InjectingViewModels.ViewModels
{
    public class ShellViewModel : Screen
    {
        public IPrinterViewModel PrinterVm { get; set; }

        public ShellViewModel(IPrinterViewModelFactory printerVmFactory)
        {
            // Gets printer viewmodel depending on specified parameter.
            PrinterVm = printerVmFactory.Get("default");
            
            PrinterVm.Print("Hello World!");
        }
    }
}
