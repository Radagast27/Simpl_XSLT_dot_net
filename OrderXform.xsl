<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">  	
<xsl:output method="text"/>
<xsl:template match="/"> 
<xsl:text>
HDR**20180403*432*WXYZ*12
ENV*RFD**~*543465346
</xsl:text>
<xsl:for-each select="/Orders/Order"> 
<xsl:value-of select="OrderId" />****<xsl:value-of select="OrderDateTime" /><xsl:text>MEM*SH1HYORDR**&#xd;</xsl:text>
</xsl:for-each>ENV*RFD**~*543465346*
FTR*SUN**~*EFG455323*		
</xsl:template>  
</xsl:stylesheet>