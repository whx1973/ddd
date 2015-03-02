using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianwork
{
	/// <summary>
	/// 聚合跟基类
	/// </summary>
	public class AggregateRoot : IAggregateRoot
	{
		#region Ctor

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public AggregateRoot() { }

		#endregion

		#region IEntity Members
		public virtual Guid ID
		{
			get;
			set;
		}
		#endregion

		#region IEquatable<IEntity> Members
		public virtual bool Equals(IEntity other)
		{
			if (object.ReferenceEquals(this, other)) return true;
			if ((object)other == null) return false;
			if (!(other is AggregateRoot)) return false;
			AggregateRoot otherAr = other as AggregateRoot;
			return this.ID.Equals(otherAr.ID);
			 
		}

		#endregion

		#region Public Methods

		public override int GetHashCode()
		{
			return this.ID.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;

			AggregateRoot ar = obj as AggregateRoot;

			if ((object)ar == null) return false;

			return this.Equals((IEntity)ar);
		}

		#endregion


	}
}
