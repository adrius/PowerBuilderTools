// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class PdfMethod : HardwiredObject {
		static PdfMethod instance;

		static PdfMethod() {
			instance = new PdfMethod();
		}

		static public void Init() {
		}

		public static PdfMethod Instance {
			get { return instance; }
		}

		protected PdfMethod() : base(PowerObject.PowerObjectParent, "PdfMethod", EnumeratedType.Instance) {
		}
	}
}