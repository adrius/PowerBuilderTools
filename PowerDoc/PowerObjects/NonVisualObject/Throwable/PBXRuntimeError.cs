// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class PBXRuntimeError : HardwiredObject {
		static PBXRuntimeError instance;

		static PBXRuntimeError() {
			instance = new PBXRuntimeError();
		}

		static public void Init() {
		}

		public static PBXRuntimeError Instance {
			get { return instance; }
		}

		protected PBXRuntimeError() : base(PowerObject.PowerObjectParent, "PBXRuntimeError", RuntimeError.Instance) {
		}
	}
}
