// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class OleTXNoObject : HardwiredObject {
		static OleTXNoObject instance;

		static OleTXNoObject() {
			instance = new OleTXNoObject();
		}

		static public void Init() {
		}

		public static OleTXNoObject Instance {
			get { return instance; }
		}

		protected OleTXNoObject() : base(PowerObject.PowerObjectParent, "OleTXNoObject", OleObject.Instance) {
		}
	}
}
