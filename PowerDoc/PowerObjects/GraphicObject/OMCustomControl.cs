// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class OMCustomControl : HardwiredObject {
		static OMCustomControl instance;

		static OMCustomControl() {
			instance = new OMCustomControl();
		}

		static public void Init() {
		}

		public static OMCustomControl Instance {
			get { return instance; }
		}

		protected OMCustomControl() : base(PowerObject.PowerObjectParent, "OMCustomControl", OMControl.Instance) {
		}
	}
}
