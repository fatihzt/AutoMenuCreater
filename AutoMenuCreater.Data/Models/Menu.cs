﻿using AutoMenuCreater.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Models
{
	public class Menu : AuditedEntity
	{
        public string Name { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
		public string Icon { get; set; }

    }
}
