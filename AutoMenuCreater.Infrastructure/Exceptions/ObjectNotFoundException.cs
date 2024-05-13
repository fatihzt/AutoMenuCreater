using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Exceptions
{
	public class ObjectNotFoundException : Exception
	{
		public ObjectNotFoundException() : base() { }
		public ObjectNotFoundException(string message) : base(message) { }
		public ObjectNotFoundException(string message, params object[] args)
			: base(String.Format(CultureInfo.CurrentCulture, message, args))
		{
		}
	}
}
