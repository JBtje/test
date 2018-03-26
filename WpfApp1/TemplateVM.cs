using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TemplateVM : ViewModelBase
    {
        public int _GridHeight = 10;
        public int GridHeight
        {
            get => _GridHeight;
            set
            {
                _GridHeight = value;
                NotifyPropertyChanged(nameof(GridHeight));
            }
        }

        public TemplateVM()
        {
        }
    }
}
