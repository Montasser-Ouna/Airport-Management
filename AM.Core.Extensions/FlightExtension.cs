using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Extensions
{
    public static class FlightExtension
    {
        public static int GetDelay(this Flight flight)
        {
            return (flight.EffectiveArrival - flight.FlightDate)
                .Minutes - flight.EstimatedDuration;

        }
    }
}
