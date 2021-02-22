using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpts
{
    public class MasterDetailMainviewMasterMenuItem
    {
        public MasterDetailMainviewMasterMenuItem()
        {
            TargetType = typeof(MasterDetailMainviewMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}