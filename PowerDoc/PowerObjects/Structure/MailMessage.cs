// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class MailMessage : HardwiredObject {
		static MailMessage instance;

		static MailMessage() {
			instance = new MailMessage();
		}

		static public void Init() {
		}

		public static MailMessage Instance {
			get { return instance; }
		}

		protected MailMessage() : base(PowerObject.PowerObjectParent, "MailMessage", Structure.Instance) {
		}
	}
}
