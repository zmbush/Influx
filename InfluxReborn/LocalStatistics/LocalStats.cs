﻿using System.Collections.Generic;

namespace InfluxReborn.LocalStatistics;

public sealed record LocalStats
{
    public ulong ContentId { get; init; }
    public byte GrandCompany { get; init; }
    public byte GcRank { get; init; }
    public bool SquadronUnlocked { get; init; }
    public byte MaxLevel { get; init; } = 90;
    public IList<short> ClassJobLevels { get; init; } = new List<short>();
    public byte StartingTown { get; init; }
    public int MsqCount { get; set; } = -1;
    public string? MsqName { get; set; }
    public uint MsqGenre { get; set; }
    public int Gil { get; set; }
    public int MGP { get; set; }
}
