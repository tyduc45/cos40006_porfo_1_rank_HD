using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VisibilityManager
    {
        private bool _visible = false;

        public VisibilityManager(bool v) {
            _visible = v;
        }

        public void visibilityToggle()
        {
            _visible = !_visible;
        }

        public bool currentVisibility() { return _visible; }
    }
}
