// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ConnectPrivilege : HardwiredObject {
		static ConnectPrivilege instance;

		static ConnectPrivilege() {
			instance = new ConnectPrivilege();
		}

		static public void Init() {
		}

		public static ConnectPrivilege Instance {
			get { return instance; }
		}

		protected ConnectPrivilege() : base(PowerObject.PowerObjectParent, "ConnectPrivilege", EnumeratedType.Instance) {
		}
	}
}
