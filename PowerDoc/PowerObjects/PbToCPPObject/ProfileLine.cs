// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ProfileLine : HardwiredObject {
		static ProfileLine instance;

		static ProfileLine() {
			instance = new ProfileLine();
		}

		static public void Init() {
		}

		public static ProfileLine Instance {
			get { return instance; }
		}

		protected ProfileLine() : base(PowerObject.PowerObjectParent, "ProfileLine", PbToCPPObject.Instance) {
		}
	}
}
