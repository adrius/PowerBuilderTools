// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CommandButton : HardwiredObject {
		static CommandButton instance;

		static CommandButton() {
			instance = new CommandButton();
		}

		static public void Init() {
		}

		public static CommandButton Instance {
			get { return instance; }
		}

		protected CommandButton() : base(PowerObject.PowerObjectParent, "CommandButton", DragObject.Instance) {
		}
	}
}
