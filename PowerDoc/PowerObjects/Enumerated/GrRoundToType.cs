// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GrRoundToType : HardwiredObject {
		static GrRoundToType instance;

		static GrRoundToType() {
			instance = new GrRoundToType();
		}

		static public void Init() {
		}

		public static GrRoundToType Instance {
			get { return instance; }
		}

		protected GrRoundToType() : base(PowerObject.PowerObjectParent, "GrRoundToType", EnumeratedType.Instance) {
		}
	}
}
