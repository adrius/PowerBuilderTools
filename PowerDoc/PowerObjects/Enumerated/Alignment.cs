// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Alignment : HardwiredObject {
		static Alignment instance;

		static Alignment() {
			instance = new Alignment();
		}

		static public void Init() {
		}

		public static Alignment Instance {
			get { return instance; }
		}

		protected Alignment() : base(PowerObject.PowerObjectParent, "Alignment", EnumeratedType.Instance) {
		}
	}
}
