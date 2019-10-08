using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimioAPI;
using SimioAPI.Extensions;

namespace _1007FormB
{
    class UserAddIn : IDesignAddIn
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "1007_Form_B"; }
        }
        
        public string Description
        {
            get { return "나는 둘째 창에다 켜라! 닝겐아!"; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return null; }
        }

        FormB form;

        public void Execute(IDesignContext context)
        {
            if (context.ActiveModel != null)
            {
                form = new FormB();
                form.ShowDialog();

            }
        }

        #endregion
    }
}
