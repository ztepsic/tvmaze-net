﻿using System;
using TvMaze.Domain;

namespace TvMaze {
    /// <summary>
    /// Schedule interface
    /// </summary>
    public interface ISchedule {
        /// <summary>
        /// Gets schedule that air in a given country on a given date.
        /// Episodes are returned in the order in which they are aired, and full information about
        /// the episode and the corresponding show is included
        /// </summary>
        /// <param name="countryCode">Country for which schedule is requestd. An ISO 3166-1 code of the country; defaults to US</param>
        /// <param name="date">Date for which schedule is requested. Defaults to the current day</param>
        /// <returns>Schedule</returns>
        Schedule GetSchedule(string countryCode = null, DateTime? date = null);

        /// <summary>
        /// Gets the full schedule - a list of all future episodes know to TvMaze,
        /// regardless of their country.
        /// </summary>
        /// <returns>Full schedule</returns>
        Schedule GetFullSchedule();
    }
}
