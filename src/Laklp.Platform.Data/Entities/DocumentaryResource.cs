using System;
using Laklp.Platform.Data.Entities.Enums;

namespace Laklp.Platform.Data.Entities
{
    public class DocumentaryResource : Traceable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Properties { get; set; }
        public DocumentaryResourceType DocumentaryResourceType { get; set; }
        public string Extension { get; set; }
        public string S3Key { get; set; }
        public string S3Bucket { get; set; }
        public string S3Path { get; set; }
        public string S3Region { get; set; }
        public bool IsEnabled { get; set; }
    }
}