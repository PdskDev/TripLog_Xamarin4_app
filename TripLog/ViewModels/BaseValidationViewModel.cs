using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TripLog.ViewModels
{
    public class BaseValidationViewModel: BaseViewModel, INotifyDataErrorInfo
    {
        readonly IDictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        public BaseValidationViewModel()
        {

        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public bool HasErrors => _errors?.Any(x => x.value?.Any() == true) == true;

        public IE
    }
}
