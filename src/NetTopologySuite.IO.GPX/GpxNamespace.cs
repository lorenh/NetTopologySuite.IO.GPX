namespace NetTopologySuite.IO
{
    /// <summary>
    /// Represents an XML namespace.
    /// </summary>
    public sealed class GpxNamespace
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GpxNamespace" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="namespaceUri">The namespace URI.</param>
        public GpxNamespace(string prefix, string namespaceUri)
        {
            this.Prefix = prefix;
            this.NamespaceUri = namespaceUri;
        }

        /// <summary>
        /// Gets the prefix.
        /// </summary>
        public string Prefix { get; }

        /// <summary>
        /// Gets the namespace URI.
        /// </summary>
        public string NamespaceUri { get; }
    }
}
