// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CorbaNoResponse : HardwiredObject {
		static CorbaNoResponse instance;

		static CorbaNoResponse() {
			instance = new CorbaNoResponse();
		}

		static public void Init() {
		}

		public static CorbaNoResponse Instance {
			get { return instance; }
		}

		protected CorbaNoResponse() : base(PowerObject.PowerObjectParent, "CorbaNoResponse", CorbaSystemException.Instance) {
		}
	}
}
