// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class InkMode : HardwiredObject {
		static InkMode instance;

		static InkMode() {
			instance = new InkMode();
		}

		static public void Init() {
		}

		public static InkMode Instance {
			get { return instance; }
		}

		protected InkMode() : base(PowerObject.PowerObjectParent, "InkMode", EnumeratedType.Instance) {
		}
	}
}
