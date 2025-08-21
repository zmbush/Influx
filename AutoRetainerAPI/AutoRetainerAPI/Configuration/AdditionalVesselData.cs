﻿using System;
using System.Reflection;

namespace AutoRetainerAPI.Configuration
{
    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    public class AdditionalVesselData
    {
        public int Level = 0;
        public int Part1 = 0;
        public int Part2 = 0;
        public int Part3 = 0;
        public int Part4 = 0;
        public uint NextLevelExp = 0;
        public uint CurrentExp = 0;

        public VesselBehavior VesselBehavior = VesselBehavior.Redeploy;
        public UnlockMode UnlockMode = UnlockMode.WhileLevelling;
        public string SelectedUnlockPlan = Guid.Empty.ToString();
        public string SelectedPointPlan = Guid.Empty.ToString();
        public byte[] Points = new byte[5];

        public int IndexOverride = 0;
    }
}
