// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ResultSet : HardwiredObject {
		static ResultSet instance;

		static ResultSet() {
			instance = new ResultSet();
		}

		static public void Init() {
		}

		public static ResultSet Instance {
			get { return instance; }
		}

		protected ResultSet() : base(PowerObject.PowerObjectParent, "ResultSet", NonVisualObject.Instance) {
		}
	}
}
