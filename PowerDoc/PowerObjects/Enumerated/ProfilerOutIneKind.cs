// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ProfilerOutIneKind : HardwiredObject {
		static ProfilerOutIneKind instance;

		static ProfilerOutIneKind() {
			instance = new ProfilerOutIneKind();
		}

		static public void Init() {
		}

		public static ProfilerOutIneKind Instance {
			get { return instance; }
		}

		protected ProfilerOutIneKind() : base(PowerObject.PowerObjectParent, "ProfilerOutIneKind", EnumeratedType.Instance) {
		}
	}
}
