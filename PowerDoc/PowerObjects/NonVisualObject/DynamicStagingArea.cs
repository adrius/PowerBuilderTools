// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class DynamicStagingArea : HardwiredObject {
		static DynamicStagingArea instance;

		static DynamicStagingArea() {
			instance = new DynamicStagingArea();
		}

		static public void Init() {
		}

		public static DynamicStagingArea Instance {
			get { return instance; }
		}

		protected DynamicStagingArea() : base(PowerObject.PowerObjectParent, "DynamicStagingArea", NonVisualObject.Instance) {
		}
	}
}
