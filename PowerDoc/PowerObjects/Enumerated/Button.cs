// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Button : HardwiredObject {
		static Button instance;

		static Button() {
			instance = new Button();
		}

		static public void Init() {
		}

		public static Button Instance {
			get { return instance; }
		}

		protected Button() : base(PowerObject.PowerObjectParent, "Button", EnumeratedType.Instance) {
		}
	}
}
