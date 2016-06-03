using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebdocOrder.Controls
{
    public class TodoRepeater : FlowLayoutPanel
    {
        private List<Todo> _DataSource;
        public List<Todo> DataSource
        {
            get
            {
                return _DataSource;
            }
            set
            {
                _DataSource = value;
                if (_DataSource!=null)
                GenerateControls();
            }
        }
       
        private void GenerateControls()
        {
            Controls.Clear();
            foreach (Todo t in _DataSource)
            {
                this.Controls.Add(new TodoControl(t));
            }
        }
    }
}
