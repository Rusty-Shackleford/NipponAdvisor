using DarkUI.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.DarkUIExt
{
    /// <summary>
    /// An extension of the DarkUI 'DarkToolWindow' class.
    /// </summary>
    public class DarkToolWindowExt : DarkToolWindow
    {
        // Create an event for passing Dishes around between Window Docks.
        public event EventHandler<DishChangedArgs> DishChanged;
        protected virtual void OnDishChanged(DishChangedArgs e)
        {
            DishChanged?.Invoke(this, e);
        }
        // Hack: So that Designer works - you still want to use the constructor though
        // to prevent the issue noted in the new Constructor summary!
        public DarkToolWindowExt() { }

        /// <summary>
        /// There is some bug with the dock area not being kept
        /// or used properly if set to "None", yet it is not a required
        /// field for creating the object.
        /// Using the "DefaultDockArea" will fix this, but to make
        /// this more explicit, I've added a constructor which requires
        /// a DefaultDockArea that is not "None".
        /// </summary>
        //[Obsolete("Designer only", true)]
        public DarkToolWindowExt(DarkDockArea defaultArea) : base()
        {
            if (defaultArea == DarkDockArea.None || defaultArea == 0)
            {
                DefaultDockArea = DarkDockArea.Document;
            } else
            {
                DefaultDockArea = defaultArea;
            }
        }
    }
}
