using System;

namespace MonoGame.InteractiveTests {

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class InteractiveTestAttribute : Attribute {
		public InteractiveTestAttribute (string name, string category)
		{
			_name = name;
			_category = category;
		}

		public InteractiveTestAttribute (string name)
			: this(name, null)
		{
		}

		public InteractiveTestAttribute ()
			: this(null, null)
		{
		}

		private readonly string _name;
		public string Name {
			get { return _name; }
		}

		private readonly string _category;
		public string Category {
			get { return _category; }
		}
	}
}

