// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ErrorLogging : HardwiredObject {
		static ErrorLogging instance;

		static ErrorLogging() {
			instance = new ErrorLogging();
		}

		static public void Init() {
		}

		public static ErrorLogging Instance {
			get { return instance; }
		}

		protected ErrorLogging() : base(PowerObject.PowerObjectParent, "ErrorLogging", Service.Instance) {
		}
	}
}
