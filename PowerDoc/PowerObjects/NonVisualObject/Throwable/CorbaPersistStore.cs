// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CorbaPersistStore : HardwiredObject {
		static CorbaPersistStore instance;

		static CorbaPersistStore() {
			instance = new CorbaPersistStore();
		}

		static public void Init() {
		}

		public static CorbaPersistStore Instance {
			get { return instance; }
		}

		protected CorbaPersistStore() : base(PowerObject.PowerObjectParent, "CorbaPersistStore", CorbaSystemException.Instance) {
		}
	}
}
