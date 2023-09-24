using System;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IAuthenticationService
	{
		AuthenticationResponse Login(User user);	
		void LogOut();	
	}
}

