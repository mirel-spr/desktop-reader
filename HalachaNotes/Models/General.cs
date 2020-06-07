using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalachaNotes.Models
{
    class General
    {
        public void Instantiate()
        {

        }

        #region Properties
        public FontRendering currentRendering
        {
            get { return _currentRendering; }
            set { _currentRendering = value; }
        }
        #endregion

        #region Private Fields
        private FontRendering _currentRendering;
        #endregion
    }
}
