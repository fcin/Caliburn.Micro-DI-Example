namespace InjectingViewModelsWithFactory.ViewModels.Printers
{
    public interface IPrinterViewModelFactory
    {
        IPrinterViewModel Get(string name);
    }
}
