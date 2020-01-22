using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingObjectsAcrossComponents.Model
{
    public class ComplexObject
    {
        private string _propertyA;
        private string _propertyB;

        public string PropertyA
        {
            get => _propertyA;
            set
            {
                _propertyA = value;
                NotifyStateChanged(false);
            }
        }
        public string PropertyB
        {
            get => _propertyB;
            set
            {
                _propertyB = value;
                NotifyStateChanged(true);
            }
        }

        public string PropertyC => PropertyA + PropertyB;

        public event Action<bool> OnChange;

        private void NotifyStateChanged(bool requireAppStateChange) => OnChange?.Invoke(requireAppStateChange);

    }
}
