# Simpl_XSLT_dot_net

Short blog post with instructions: https://kpitsimpl.blogspot.com/2018/04/t-sql-for-xml-and-net-for-xslt.html

**Keys for turning SQL to XML and transforming with .NET:**

**1). Get your SQL data** (assuming you are using SQL Server) **into XML format** via T-SQL FOR XML or the like on alternate db server.

2). **Load XSL transform file** (OrderXform.xsl) **into a new XslCompiledTransform object (transform)**

3). Using a StringWriter (writer), StringReader (inputReader) and XmlReader (inputXmlReader), **read the inputReader XML string into
inputXmlReader and apply the XSL transformation** to the transform object via: transform.Transform(inputXmlReader, args, writer); //(or another override of Transform())

4). **Return the result and write the bits** (to application memory as Label Text for a demo/walktrough like this, to domain network location, to non-domain customer ftp, etc.).

