// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class StgReadMode : HardwiredObject {
		static StgReadMode instance;

		static StgReadMode() {
			instance = new StgReadMode();
		}

		static public void Init() {
		}

		public static StgReadMode Instance {
			get { return instance; }
		}

		protected StgReadMode() : base(PowerObject.PowerObjectParent, "StgReadMode", EnumeratedType.Instance) {
		}
	}
}
