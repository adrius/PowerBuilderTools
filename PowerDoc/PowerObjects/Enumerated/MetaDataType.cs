// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class MetaDataType : HardwiredObject {
		static MetaDataType instance;

		static MetaDataType() {
			instance = new MetaDataType();
		}

		static public void Init() {
		}

		public static MetaDataType Instance {
			get { return instance; }
		}

		protected MetaDataType() : base(PowerObject.PowerObjectParent, "MetaDataType", EnumeratedType.Instance) {
		}
	}
}
