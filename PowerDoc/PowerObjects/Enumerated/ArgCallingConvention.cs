// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ArgCallingConvention : HardwiredObject {
		static ArgCallingConvention instance;

		static ArgCallingConvention() {
			instance = new ArgCallingConvention();
		}

		static public void Init() {
		}

		public static ArgCallingConvention Instance {
			get { return instance; }
		}

		protected ArgCallingConvention() : base(PowerObject.PowerObjectParent, "ArgCallingConvention", EnumeratedType.Instance) {
		}
	}
}
