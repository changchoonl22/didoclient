using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ATermNCode.VO;
using Newtonsoft.Json.Linq;

namespace ATermNCode.Ctnl
{
    public partial class TermListControl : UserControl
    {
        public TermListControl()
        {
            InitializeComponent();
        }


        public void SetDataSource(IEnumerable<JArray> resultList)
        {
            bdsTerm.DataSource = resultList;
        }

        public void RefreshGrid()
        {
            dgvTerm.RefreshEdit();
        }

        internal void SetDataSource(JArray data)
        {
            throw new NotImplementedException();
        }
    }
}
