﻿/*
Copyright (c) 2012 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
#endregion

namespace Utilities.FileFormats.BlogML
{
    /// <summary>
    /// Category class
    /// </summary>
    public class Category
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Element">XML element with the category info</param>
        public Category(XElement Element)
        {
            Contract.Requires<ArgumentNullException>(Element != null, "Element");
            ID = Element.Attribute("id") != null ? Element.Attribute("id").Value : "";
            REF = Element.Attribute("ref") != null ? Element.Attribute("ref").Value : "";
            DateCreated = Element.Attribute("date-created") != null ? DateTime.Parse(Element.Attribute("date-created").Value, CultureInfo.InvariantCulture) : DateTime.Now;
            DateModified = Element.Attribute("date-modified") != null ? DateTime.Parse(Element.Attribute("date-modified").Value, CultureInfo.InvariantCulture) : DateTime.Now;
            ParentREF = Element.Attribute("parentref") != null ? Element.Attribute("parentref").Value : "";
            if (Element.Element("title") != null)
                Title = Element.Element("title").Value;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// ID of the category
        /// </summary>
        public virtual string ID { get; set; }

        /// <summary>
        /// Title of the cateogry (its name)
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Determines if this is a reference to a category
        /// </summary>
        public virtual string REF { get; set; }

        /// <summary>
        /// Parent ref
        /// </summary>
        public virtual string ParentREF { get; set; }

        /// <summary>
        /// Date createed
        /// </summary>
        public virtual DateTime DateCreated { get; set; }

        /// <summary>
        /// Date modified
        /// </summary>
        public virtual DateTime DateModified { get; set; }

        #endregion

        #region Overridden Functions

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The object as a string</returns>
        public override string ToString()
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<category ");
            if(string.IsNullOrEmpty(REF))
            {
                Builder.AppendFormat(CultureInfo.InvariantCulture, "id=\"{0}\" date-created=\"{1}\" date-modified=\"{2}\" approved=\"true\" parentref=\"{3}\">\n", ID, DateCreated.ToString("yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture), DateModified.ToString("yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture), ParentREF);
                Builder.AppendFormat(CultureInfo.InvariantCulture, "<title type=\"text\"><![CDATA[{0}]]></title>\n", Title);
                Builder.AppendLine("</category>");
            }
            else
            {
                Builder.AppendFormat(CultureInfo.InvariantCulture, "ref=\"{0}\" />\n", REF);
            }
            return Builder.ToString();
        }

        #endregion
    }
}