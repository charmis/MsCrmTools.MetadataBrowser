﻿using Microsoft.Xrm.Sdk.Metadata;

namespace MsCrmTools.MetadataBrowser.AppCode.AttributeMd
{
    public class DateTimeAttributeMetadataInfo : AttributeMetadataInfo
    {
        private readonly DateTimeAttributeMetadata amd;

        public DateTimeAttributeMetadataInfo(DateTimeAttributeMetadata amd)
            : base(amd)
        {
            this.amd = amd;
        }

        public DateTimeFormat Format
        {
            get { return amd.Format.Value; }
        }

        public ImeMode ImeMode
        {
            get { return amd.ImeMode.Value; }
        }

        public bool CanChangeDateTimeBehavior { get { return amd.CanChangeDateTimeBehavior.Value; } }
        public string DateTimeBehavior { get { return amd.DateTimeBehavior.Value; } }
        public string FormulaDefinition { get { return amd.FormulaDefinition; } }
    }
}