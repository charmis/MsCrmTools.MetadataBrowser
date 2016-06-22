﻿using Microsoft.Xrm.Sdk.Metadata;

namespace MsCrmTools.MetadataBrowser.AppCode.AttributeMd
{
    public class StringAttributeMetadataInfo : AttributeMetadataInfo
    {
        private readonly StringAttributeMetadata amd;

        public StringAttributeMetadataInfo(StringAttributeMetadata amd)
            : base(amd)
        {
            this.amd = amd;
        }

        public StringFormat Format
        {
            get { return amd.Format.Value; }
        }

        public string FormatName
        {
            get { return amd.FormatName != null ? amd.FormatName.Value : ""; }
        }

        public ImeMode ImeMode
        {
            get { return amd.ImeMode.Value; }
        }

        public int MaxLength
        {
            get { return amd.MaxLength.Value; }
        }

        public string FormulaDefinition { get { return amd.FormulaDefinition; } }

        public bool IsLocalizable
        {
            get { return amd.IsLocalizable.HasValue && amd.IsLocalizable.Value; }
        }

        public string YomiOf
        {
            get { return amd.YomiOf ; }
        }
    }
}