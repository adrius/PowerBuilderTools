// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class RuntimeError : HardwiredObject {
		static RuntimeError instance;

		static RuntimeError() {
			instance = new RuntimeError();
		}

		static public void Init() {
		}

		public static RuntimeError Instance {
			get { return instance; }
		}

		protected RuntimeError() : base(PowerObject.PowerObjectParent, "RuntimeError", Throwable.Instance) {
		}
	}
}