// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ListViewItem : HardwiredObject {
		static ListViewItem instance;

		static ListViewItem() {
			instance = new ListViewItem();
		}

		static public void Init() {
		}

		public static ListViewItem Instance {
			get { return instance; }
		}

		protected ListViewItem() : base(PowerObject.PowerObjectParent, "ListViewItem", Structure.Instance) {
		}
	}
}
