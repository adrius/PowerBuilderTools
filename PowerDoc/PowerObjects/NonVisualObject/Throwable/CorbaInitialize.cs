// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CorbaInitialize : HardwiredObject {
		static CorbaInitialize instance;

		static CorbaInitialize() {
			instance = new CorbaInitialize();
		}

		static public void Init() {
		}

		public static CorbaInitialize Instance {
			get { return instance; }
		}

		protected CorbaInitialize() : base(PowerObject.PowerObjectParent, "CorbaInitialize", CorbaSystemException.Instance) {
		}
	}
}
