// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Encoding : HardwiredObject {
		static Encoding instance;

		static Encoding() {
			instance = new Encoding();
		}

		static public void Init() {
		}

		public static Encoding Instance {
			get { return instance; }
		}

		protected Encoding() : base(PowerObject.PowerObjectParent, "Encoding", EnumeratedType.Instance) {
		}
	}
}
