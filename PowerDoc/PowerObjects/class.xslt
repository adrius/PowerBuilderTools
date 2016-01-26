<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="text" encoding="windows-1250"/>

<xsl:template match="class">// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class <xsl:value-of select="name"/> : HardwiredObject {
		static <xsl:value-of select="name"/> instance;

		static <xsl:value-of select="name"/>() {
			instance = new <xsl:value-of select="name"/>();
		}

		static public void Init() {
		}

		public static <xsl:value-of select="name"/> Instance {
			get { return instance; }
		}

		protected <xsl:value-of select="name"/>() : base(PowerObject.PowerObjectParent, "<xsl:value-of select="name"/>", <xsl:value-of select="superclass"/>.<xsl:choose><xsl:when test="string(superclass)!='PowerObject'">Instance</xsl:when><xsl:when test="string(superclass)='PowerObject'">PowerObjectInstance</xsl:when></xsl:choose>) {<xsl:if test="count(alias) > 0">
			Hardwired.AddClassAlias("<xsl:value-of select="alias"/>", this);</xsl:if>
		}
	}
}
</xsl:template>

</xsl:stylesheet>