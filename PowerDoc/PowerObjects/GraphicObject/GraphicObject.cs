// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GraphicObject : HardwiredObject {
		static GraphicObject instance;

		static GraphicObject() {
			instance = new GraphicObject();
		}

		static public void Init() {
		}

		public static GraphicObject Instance {
			get { return instance; }
		}

		protected GraphicObject() : base(PowerObject.PowerObjectParent, "GraphicObject", PowerObject.PowerObjectInstance) {
		}
	}
}
