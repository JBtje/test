using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MainWindowVM : ViewModelBase
    {
        public MainWindowVM(TemplateVM tvm) {
            
            // Uncommenting this line makes the GridHeightt 100. However, while it is commented, the height is 10 (default value) and not 450 as set in the XAML of MainWindow
            //tvm.GridHeight = 100;
        }
    }
}
