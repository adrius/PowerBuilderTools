// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ConnectionInfo : HardwiredObject {
		static ConnectionInfo instance;

		static ConnectionInfo() {
			instance = new ConnectionInfo();
		}

		static public void Init() {
		}

		public static ConnectionInfo Instance {
			get { return instance; }
		}

		protected ConnectionInfo() : base(PowerObject.PowerObjectParent, "ConnectionInfo", Structure.Instance) {
		}
	}
}
