// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CpuTypes : HardwiredObject {
		static CpuTypes instance;

		static CpuTypes() {
			instance = new CpuTypes();
		}

		static public void Init() {
		}

		public static CpuTypes Instance {
			get { return instance; }
		}

		protected CpuTypes() : base(PowerObject.PowerObjectParent, "CpuTypes", EnumeratedType.Instance) {
		}
	}
}
