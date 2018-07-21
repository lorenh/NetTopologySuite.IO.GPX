﻿using System.Xml;
using System.Xml.Linq;

namespace NetTopologySuite.IO
{
    public sealed class GpxPerson : ICanWriteToXmlWriter
    {
        public GpxPerson(string name, GpxEmail email, GpxWebLink link)
        {
            this.Name = name;
            this.Email = email;
            this.Link = link;
        }

        public static GpxPerson Load(XElement element)
        {
            if (element is null)
            {
                return null;
            }

            return new GpxPerson(
                name: element.GpxElement("name")?.Value,
                email: GpxEmail.Load(element.GpxElement("email")),
                link: GpxWebLink.Load(element.GpxElement("link")));
        }

        public void Save(XmlWriter writer)
        {
            writer.WriteOptionalElementValue("name", this.Name);
            writer.WriteOptionalElementValue("email", this.Email);
            writer.WriteOptionalElementValue("link", this.Link);
        }

        public string Name { get; }

        public GpxEmail Email { get; }

        public GpxWebLink Link { get; }

        public override string ToString() => Helpers.BuildString((nameof(this.Name), this.Name),
                                                                 (nameof(this.Email), this.Email),
                                                                 (nameof(this.Link), this.Link));
    }
}
