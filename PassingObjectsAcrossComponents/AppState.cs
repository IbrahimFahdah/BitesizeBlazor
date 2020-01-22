using PassingObjectsAcrossComponents.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingObjectsAcrossComponents
{
    public class AppState
    {
        public AppState()
        {
            obj = new ComplexObject();
            obj.OnChange += obj_OnChange;
        }

     
        public ComplexObject obj { get; private set; }

        public event Action OnChange;

        private void obj_OnChange(bool requireAppStateChange)
        {
            if(requireAppStateChange)
            {
                OnChange?.Invoke();
            }
        }

    }
}
