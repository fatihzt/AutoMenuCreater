using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Dto.Request.Menu
{
    public class MenuSaveDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
