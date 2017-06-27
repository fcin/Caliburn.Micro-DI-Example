using Caliburn.Micro;
using InjectingViewModels.ViewModels;
using InjectingViewModels.ViewModels.Printers;
using System;
using System.Collections.Generic;

namespace InjectingViewModels
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.PerRequest<ShellViewModel, ShellViewModel>();
            _container.PerRequest<IPrinterViewModel, PrinterViewModel>();
            /// Uncomment line below to see how you can change implementation of
            /// a whole interface with just a one line of code.
            //_container.PerRequest<IPrinterViewModel, ExtraPrinterViewModel>();
            base.Configure();
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.GetInstance(service, key);
            if (instance != null)
                return instance;

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

    }
}
