namespace InjectingViewModelsWithFactory.ViewModels.Printers
{
    public interface IPrinterViewModel
    {
        string Text { get; set; }

        void Print(string message);
    }
}