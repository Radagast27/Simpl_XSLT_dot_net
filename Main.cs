using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Simpl_XSLT_dot_net
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string getExtensibleStylesTransformString(string xml = null)
        {
               string input = @"<?xml version='1.0'?><Orders>
              <Order>
                <OrderId>1</OrderId>
                <PersonId>1</PersonId>
                <OrderDateTime>2018-03-27T00:00:00</OrderDateTime>
              </Order>
              <Order>
                <OrderId>2</OrderId>
                <PersonId>3</PersonId>
                <OrderDateTime>2018-01-01T00:00:00</OrderDateTime>
              </Order>
              <Order>
                <OrderId>3</OrderId>
                <PersonId>1</PersonId>
                <OrderDateTime>2015-02-02T00:00:00</OrderDateTime>
              </Order>
              <Order>
                <OrderId>4</OrderId>
                <PersonId>2</PersonId>
                <OrderDateTime>2017-03-01T00:00:00</OrderDateTime>
              </Order>
              <Order>
                <OrderId>5</OrderId>
                <PersonId>4</PersonId>
                <OrderDateTime>2018-01-01T00:00:00</OrderDateTime>
              </Order>
              <Order>
                <OrderId>6</OrderId>
                <PersonId>1</PersonId>
                <OrderDateTime>2018-06-07T00:00:00</OrderDateTime>
              </Order>
            </Orders>";


            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load("C:\\Xform\\OrderXform.xsl"); //load XSLT transform file into XslCompiledTransform

            using (StringWriter writer = new StringWriter())
            {
                // Make an XML reader out of the string
                XmlReader inputXmlReader;
                using (var inputReader = new StringReader(input))
                {
                    inputXmlReader = XmlReader.Create(inputReader);

                    // Apply the transformation to the reader and write it in our string writer
                    transform.Transform(inputXmlReader, null, writer);
                }            

                // Retrieve the output string from the string writer
                return writer.GetStringBuilder().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = getExtensibleStylesTransformString();
        }
    }
}
