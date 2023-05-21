// See https://aka.ms/new-console-template for more information
//using System.Numerics;
using AM.Core.Domain;

Console.WriteLine("Hello, World!");
//TP1 . Question7
//Plane plane= new Plane();
//plane.Capacity = 100;
//plane.ManufactureDate = new DateTime(2000, 1, 1);
//plane.PlaneType = planeType.Boing;


//TP1. Question 8  (on utilise ce methode quand il y a des proprietes obligatoires)
//Plane plane2 = new Plane(planeType.Boing, 100, new DateTime(2000, 1, 1));


////TP1 Question 9 construire le constructore et l'initialiser (initialiseur d'objet) - plus dynamique
//Plane plane3 = new Plane()
//{
//    Capacity= 100,
//    ManufactureDate= new DateTime(2000, 1, 1),
//    MyPlaneType= PlaneType.BOING
//};

///tp1 question 12.b
//Passenger passanger2 =new Passenger();
//Passenger staff2= new Staff();
//Passenger traveller2 = new Traveller();
//Console.WriteLine(passanger2.GetPassengerType());
//Console.WriteLine(staff2.GetPassengerType());
//Console.WriteLine(traveller2.GetPassengerType());


////tp1 question 13.c
//Passenger passenger3=new Passenger();
////int calculatedAge = 5;
////passenger3.GetAge(new DateTime(2000,1,1), ref calculatedAge);
////Console.WriteLine(calculatedAge);
//passenger3.BirthDate = new DateTime(2000, 1, 1);
////passenger3.GetAge(passenger3);
//Console.WriteLine(passenger3.Age);
////TP2.Q13.c 
//GetScore meth1 = delegate (Passenger p)
//{
//    return p.Flights.Count;
//};
//GetScore meth2 = delegate (Passenger p)
//{
//    return p.Flights.Where(f => f.Destination == "Tunisie" || f.Departure == "Tunisie")
//    .Count();
//};
//Passenger pSenior1 =flightService.GetSeniorPassenger(meth1);
//Passenger pSenior2 = flightService.GetSeniorPassenger(meth2);
////TP2.Q14
//Flight flight= new Flight();
//flight.GetDelay();


//tp3 Q8
//Plane p = new Plane()
//{
//  Capacity = 200,
// ManufactureDate = new DateTime(2000, 01, 01),
//PlaneType = planeType.Airbus
//};

//Reservation r = new Reservation()
//{
//    Price= 100,
//    Seat= "coté fenetre",
//    VIP= true,
//    MyPassenger= p,
//    MyFlight= f
//};

//TP5 Q10

//Plane pl = new Plane()
//{
//    Capacity= 100,
//    ManufactureDate= new DateTime(1999,1,1),
//    MyPlaneType=PlaneType.Airbus
//};

//Flight fl = new Flight()
//{
//    Destination = "Paris",
//    Departure = "Tunis",
//    FlightDate = new DateTime(2022, 1, 1),
//    EffectiveArrival = new DateTime(2022, 1, 2),
//    EstimatedDuration = 120,
//    MyPlane= pl

//};

//ctxt.Add(fl); //exec du code en mémoire
//ctxt.Add(pl);
//ctxt.SaveChanges();
//Console.WriteLine(fl);
//Console.WriteLine(fl.MyPlane);

//tp5 q11
Flight flightFromDB = (Flight)ctxt.Find(typeof(Flight), 2); //extraire de la bd
Console.WriteLine(flightFromDB);
Console.WriteLine(flightFromDB.MyPlane);


