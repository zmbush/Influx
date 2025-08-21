﻿using Lumina.Excel.Sheets;
using System;
using System.Reflection;

namespace AutoRetainerAPI.Configuration
{
    [Serializable]
    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    public class PlannedVenture
    {
        [NonSerialized] public string GUID = Guid.NewGuid().ToString();
        public uint ID;
        public int Num = 1;

        public PlannedVenture(uint iD, int num)
        {
            ID = iD;
            Num = num;
        }
        public PlannedVenture(uint iD)
        {
            ID = iD;
        }
        public PlannedVenture(RetainerTask task, int num)
        {
            ID = task.RowId;
            Num = num;
        }
        public PlannedVenture(RetainerTask task)
        {
            ID = task.RowId;
        }
        public PlannedVenture()
        {
        }
    }
}
