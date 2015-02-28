using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianwork.Repositories
{
	public interface IRepository<TAggregateRoot>
		where TAggregateRoot : class,IAggregateRoot
	{
		/// <summary>
		/// 获取RepositoryContext上下文的附加Repository的实例
		/// </summary>
		IRepositoryContext Context { get; }
	}
}
