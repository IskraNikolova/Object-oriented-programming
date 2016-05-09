namespace Blobs.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Data : IData
    {
        private readonly ICollection<IBlob> blobs = new List<IBlob>();

        public IEnumerable<IBlob> Blobs => this.blobs;

        public void AddBlobs(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentException(nameof(blob));
            }
            this.blobs.Add(blob);
        }
    }
}
