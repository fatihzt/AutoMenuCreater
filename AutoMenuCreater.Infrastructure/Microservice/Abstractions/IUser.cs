using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Microservice.Abstractions
{
	public interface IUser
	{
		string GetUserName();
		void SetUserName(string userName);
	}
}
