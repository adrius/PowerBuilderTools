// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Object : HardwiredObject {
		static Object instance;

		static Object() {
			instance = new Object();
		}

		static public void Init() {
		}

		public static Object Instance {
			get { return instance; }
		}

		protected Object() : base(PowerObject.PowerObjectParent, "Object", EnumeratedType.Instance) {
		}
	}
}
