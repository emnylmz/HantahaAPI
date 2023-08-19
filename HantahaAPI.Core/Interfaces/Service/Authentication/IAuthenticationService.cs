using System;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IAuthenticationService
	{
		string Login(User user);	
	}
}

