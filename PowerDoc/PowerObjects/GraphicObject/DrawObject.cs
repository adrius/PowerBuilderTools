// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class DrawObject : HardwiredObject {
		static DrawObject instance;

		static DrawObject() {
			instance = new DrawObject();
		}

		static public void Init() {
		}

		public static DrawObject Instance {
			get { return instance; }
		}

		protected DrawObject() : base(PowerObject.PowerObjectParent, "DrawObject", WindowObject.Instance) {
		}
	}
}
