<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:wix="http://schemas.microsoft.com/wix/2006/wi"
    exclude-result-prefixes="wix">

    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="wix:Component[wix:File]">
        <xsl:variable name="source" select="wix:File/@Source" />
        
        <xsl:variable name="lowerSource" select="translate($source, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz')" />
        
        <xsl:if test="
            substring($lowerSource, string-length($lowerSource) - 3) = '.dll' or
            substring($lowerSource, string-length($lowerSource) - 3) = '.exe' or
            substring($lowerSource, string-length($lowerSource) - 6) = '.config'
        ">
            <xsl:copy>
                <xsl:apply-templates select="@*|node()"/>
            </xsl:copy>
        </xsl:if>
    </xsl:template>

</xsl:stylesheet>