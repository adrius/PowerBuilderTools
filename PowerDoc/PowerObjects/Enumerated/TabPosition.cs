// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TabPosition : HardwiredObject {
		static TabPosition instance;

		static TabPosition() {
			instance = new TabPosition();
		}

		static public void Init() {
		}

		public static TabPosition Instance {
			get { return instance; }
		}

		protected TabPosition() : base(PowerObject.PowerObjectParent, "TabPosition", EnumeratedType.Instance) {
		}
	}
}
