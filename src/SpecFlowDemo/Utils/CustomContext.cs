using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo.Utils
{
	public class CustomContext
	{
		private Dictionary<string, object> _container;

		public CustomContext()
		{
			_container = new Dictionary<string, object>();
		}

		public object GetValue(string key)
		{
			if (!_container.ContainsKey(key))
				throw new ArgumentException("There is no value with this key!");

			return _container[key];
		}

		public void SetValue(string key, object value)
		{
			if (_container.ContainsKey(key))
				_container[key] = value;
			else
				_container.Add(key, value);
		}
	}
}
