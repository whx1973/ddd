using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianwork
{
	/// <summary>
	/// 表示实现此接口的类为领域实体类
	/// </summary>
	public interface IEntity : IEquatable<IEntity>
	{
		/// <summary>
		/// 获取或设置entity的标识
		/// </summary>
		Guid ID { get; set; }
	}
}
