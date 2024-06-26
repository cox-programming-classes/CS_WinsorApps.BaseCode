﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinsorApps.Services.Global.Models
{
    public record struct CalendarEventRecord<T>(DateTime start, DateTime end,
        string summary, T details, UserRecord eventCreator, IEnumerable<LocationRecord> locations);

    public record struct LocationRecord(string id, string label, string type);

    public readonly record struct SchoolYear(string id, string label, ImmutableArray<TermRecord> terms, DateOnly startDate, DateOnly endDate, DateOnly seniorsLastDay);
}
