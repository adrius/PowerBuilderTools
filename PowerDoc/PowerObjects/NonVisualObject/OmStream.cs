// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class OmStream : HardwiredObject {
		static OmStream instance;

		static OmStream() {
			instance = new OmStream();
		}

		static public void Init() {
		}

		public static OmStream Instance {
			get { return instance; }
		}

		protected OmStream() : base(PowerObject.PowerObjectParent, "OmStream", NonVisualObject.Instance) {
		}
	}
}
