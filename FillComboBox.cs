using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanTam_231230895_LTTQ
{
    internal class FillComboBox
    {
        public void FillCombox(ComboBox cb, DataTable dt, string displayMember, string valueMember)
        {
            cb.DataSource = dt;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
        }
    }
}
