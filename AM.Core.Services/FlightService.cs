using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class FlightService
    {
        public IList<Flight> Flights { get; set; }
        public IList<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            // linqIntegre

            //return (from f in Flights 
            //       where f.Destination == destination
            //       select f.FlightDate).ToList();
            return Flights.Where(f => f.Destination.ToString() == destination) //Methoded'extention
                .Select(f => f.FlightDate).ToList();

        }
        public void GetFlights(string filterType, string filterValue)
        {
            PropertyInfo p;
            foreach (PropertyInfo prop in typeof(Flight).GetProperties())
            {

                if (prop.Name == filterType)
                {
                    p = prop;
                }

            }
            List<Flight> listflight = new List<Flight>();
            foreach (Flight f in listflight)
            {

                if (f.Destination == filterValue)
                {

                    listflight.Add(f);
                }
                Console.WriteLine(listflight);
            }
        }
        public void ShowFlightDetails(Plane plane)
        {
            var result = from f in Flights
                         where f.MyPlane.PlaneId == plane.PlaneId
                         select new { f.Destination, f.FlightDate }; //type anonyme
            foreach (var item in result)
            {
                Console.WriteLine("destination : " + item.Destination +
                    "date :" + item.FlightDate);
            }
        }
        public int GetWeeklyFlightNumber(DateTime date)
        {
            return (from f in Flights
                    where f.FlightDate >= date
                    && f.FlightDate < date.AddDays(7)
                    select f)
                    .Count(); //type anonyme

        }
        public double GetDurationAverage(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                .Average(f => f.EstimatedDuration);
        }

        public IList<Flight> SortFlights()
        {
            return (from f in Flights
                    orderby f.EstimatedDuration descending
                    select f).ToList();
        }

        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return (from p in flight.Passengers
                    orderby p.Age descending //orderby p.BirthDate
                    select p).Take(3).ToList();
            //  return null;

        }
        public void ShowGroupedFlights()
        {
            var result = from f in Flights
                         group f by f.Destination;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var f in group)
                {
                    Console.WriteLine(f);
                }
            }
        }

        //TP2.Q13.b
        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {

            //return Flights.Select(f => f.Passengers.MaxBy(p => meth(p)))
            //  .MaxBy(p => meth(p));
            return Flights.SelectMany(f => f.Passengers).MaxBy(p => meth(p));
            //Select Many puts the list of lists in a single list 
        }
    }



    }
