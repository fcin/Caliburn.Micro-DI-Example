using Caliburn.Micro;
using System;

namespace InjectingViewModelsWithFactory.ViewModels.Printers
{
    /// <summary>
    /// Responsible for creating instances of IPrinterViewModel
    /// </summary>
    public class PrinterViewModelFactory : IPrinterViewModelFactory
    {
        private readonly IEventAggregator _eventAggregator;

        public PrinterViewModelFactory(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        /// <summary>
        /// Creates an instance of IPrinterViewModel depending on specified type
        /// </summary>
        /// <param name="name">Name of expected instance</param>
        /// <returns>Instance of IPrinterViewModel</returns>
        public IPrinterViewModel Get(string name)
        {
            if (name == "default" || string.IsNullOrEmpty(name)) {
                return new PrinterViewModel(_eventAggregator);
            }
            else if (name == "extra") {
                return new ExtraPrinterViewModel();
            }

            throw new ArgumentException("Could not find instance of IPrinterViewModel specified by parameter name.");
        }
    }
}
