using System;
namespace HantahaAPI.Core.Interfaces
{
	public interface IUnitOfWork
	{
		Task CommitAsync();
		void Commit();
	}
}

