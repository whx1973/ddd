using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianwork
{
	public interface IUnitOfWork
	{
		/// <summary>
		/// 获取<see cref="System.Boolean"/>值,该值表示IUnitOfWork
		/// 是否支持Microsoft 分布式事务处理协调器 (MS DTC)。
		/// </summary>
		bool DTCompatible { get; }
		/// <summary>
		/// 获取 <see cref="System.Boolean"/> 值
		/// 该值表示IUnitOfWork是否成功提交
		/// </summary>
		bool Committed { get; }

		/// <summary>
		/// 提交事物
		/// </summary>
		void Commit();
		/// <summary>
		/// 回滚事物
		/// </summary>
		void Rollback();
	}
}
