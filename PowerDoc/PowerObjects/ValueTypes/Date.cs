// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Date : HardwiredObject {
		static Date instance;

		static Date() {
			instance = new Date();
		}

		static public void Init() {
		}

		public static Date Instance {
			get { return instance; }
		}

		protected Date() : base(PowerObject.PowerObjectParent, "Date", PowerObject.PowerObjectInstance) {
		}
	}
}