// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Transaction : HardwiredObject {
		static Transaction instance;

		static Transaction() {
			instance = new Transaction();
		}

		static public void Init() {
		}

		public static Transaction Instance {
			get { return instance; }
		}

		protected Transaction() : base(PowerObject.PowerObjectParent, "Transaction", NonVisualObject.Instance) {
		}
	}
}
