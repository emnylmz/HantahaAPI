using System;
using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Interfaces
{
	public interface IAuthenticationService
	{
		string Login(User user);	
	}
}

