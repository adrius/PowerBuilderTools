// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class VProgressBar : HardwiredObject {
		static VProgressBar instance;

		static VProgressBar() {
			instance = new VProgressBar();
		}

		static public void Init() {
		}

		public static VProgressBar Instance {
			get { return instance; }
		}

		protected VProgressBar() : base(PowerObject.PowerObjectParent, "VProgressBar", DragObject.Instance) {
		}
	}
}
