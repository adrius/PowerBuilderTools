// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class InkEdit : HardwiredObject {
		static InkEdit instance;

		static InkEdit() {
			instance = new InkEdit();
		}

		static public void Init() {
		}

		public static InkEdit Instance {
			get { return instance; }
		}

		protected InkEdit() : base(PowerObject.PowerObjectParent, "InkEdit", DragObject.Instance) {
		}
	}
}