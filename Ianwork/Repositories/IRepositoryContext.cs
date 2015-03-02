using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianwork.Repositories
{
	public interface IRepositoryContext:IUnitOfWork
	{
		/// <summary>
		/// 获取RepositoryContext的唯一标识
		/// </summary>
		Guid ID { get; }

		/// <summary>
		/// 注册新增的对象到RepositoryContext上下文
		/// </summary>
		/// <param name="obj"></param>
		void RegisterNew(object obj);
		/// <summary>
		/// 注册修改的对象到RepositoryContext上下文
		/// </summary>
		/// <param name="obj"></param>
		void RegisterModified(object obj);

		/// <summary>
		/// 注册删除的对象到RepositoryContext上下文
		/// </summary>
		/// <param name="obj"></param>
		void RegisterDeleted(object obj);
	}
}
