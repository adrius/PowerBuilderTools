// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ConnectObject : HardwiredObject {
		static ConnectObject instance;

		static ConnectObject() {
			instance = new ConnectObject();
		}

		static public void Init() {
		}

		public static ConnectObject Instance {
			get { return instance; }
		}

		protected ConnectObject() : base(PowerObject.PowerObjectParent, "ConnectObject", NonVisualObject.Instance) {
		}
	}
}
