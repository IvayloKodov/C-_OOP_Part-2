﻿using System;

namespace Problem6.CustomEnumerationAttribute
{
    [AttributeUsage(AttributeTargets.Enum , AllowMultiple = true)]
    public class TypeAttribute :Attribute
    {
        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        public string Type { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            return $"Type = {Type}, Description = {Description}";
        }
    }
}