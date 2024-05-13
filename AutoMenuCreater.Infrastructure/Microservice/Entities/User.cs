using AutoMenuCreater.Core.Microservice.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Microservice.Entities
{
	public class User : IUser
	{
		private string userName;

		public User() { }

		public string GetUserName()
		{
			return String.IsNullOrWhiteSpace(userName) ? "Unknown User" : userName;
		}

		public void SetUserName(string userName)
		{
			this.userName = userName;
		}
	}

}
