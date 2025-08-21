﻿using ECommons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration
{
    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    public class SubmarinePointPlan
    {
        public string GUID = Guid.NewGuid().ToString();
        public string Name = string.Empty;
        public List<uint> Points = new();
        public bool Delete = false;

        public bool ShouldSerializeDelete() => false;

        public void CopyFrom(SubmarinePointPlan other)
        {
            this.Name = other.Name;
            this.Points = other.Points.JSONClone();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
