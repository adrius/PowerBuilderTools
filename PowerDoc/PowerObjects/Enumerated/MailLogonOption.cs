// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class MailLogonOption : HardwiredObject {
		static MailLogonOption instance;

		static MailLogonOption() {
			instance = new MailLogonOption();
		}

		static public void Init() {
		}

		public static MailLogonOption Instance {
			get { return instance; }
		}

		protected MailLogonOption() : base(PowerObject.PowerObjectParent, "MailLogonOption", EnumeratedType.Instance) {
		}
	}
}
