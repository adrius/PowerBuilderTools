// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class AccessibleRole : HardwiredObject {
		static AccessibleRole instance;

		static AccessibleRole() {
			instance = new AccessibleRole();
		}

		static public void Init() {
		}

		public static AccessibleRole Instance {
			get { return instance; }
		}

		protected AccessibleRole() : base(PowerObject.PowerObjectParent, "AccessibleRole", EnumeratedType.Instance) {
		}
	}
}
