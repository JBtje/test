using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IKernel Kernel { get; } = CreateKernel();

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<MainWindowVM>().ToSelf().InSingletonScope();
            kernel.Bind<TemplateVM>().ToSelf().InSingletonScope();
            return kernel;
        }
    }
}
