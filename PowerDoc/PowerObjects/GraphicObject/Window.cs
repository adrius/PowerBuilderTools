// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Window : HardwiredObject {
		static Window instance;

		static Window() {
			instance = new Window();
		}

		static public void Init() {
		}

		public static Window Instance {
			get { return instance; }
		}

		protected Window() : base(PowerObject.PowerObjectParent, "Window", GraphicObject.Instance) {
		}
	}
}
