using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebdocOrder.Controls
{
    public partial class TodoControl : UserControl
    {
        public TodoControl()
        {
            InitializeComponent();
        }

        public Todo Data { get; set; }

        public TodoControl(Todo _t) : this()
        {
            Data = _t;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            lData.Text = Data.Comment;
            lSender.Text = Data.SendDate.ToString();
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
