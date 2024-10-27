Console.WriteLine("Описания планет Солнечной системы"); 

var planetVenus = new
{
    Name = "Венера",
    SequenceNumber = 2,
    LengthEquator = "6 051 км",
    PreviousPlanet = 0,
};

var planetEarth = new
{
    Name = "Земля",
    SequenceNumber = 3,
    LengthEquator = "40 075 км",
    PreviousPlanet = planetVenus,
};

var planetMars = new
{
    Name = "Марс",
    SequenceNumber = 4,
    LengthEquator = "21 326 км",
    PreviousPlanet = planetEarth,
};

var planetVenusAgain = new
{
    Name = "Венера",
    SequenceNumber = 2,
    LengthEquator = "6 051 км",
    PreviousPlanet = planetMars,
};

Console.WriteLine("\r\nАнонимный тип объекта Венера: " + planetVenus);
Console.WriteLine("Планета эквивалентна Венере? " + planetVenus.Equals(planetVenus));

Console.WriteLine("\r\nАнонимный тип объекта Земля: " + planetEarth);
Console.WriteLine("Планета эквивалентна Венере? " + planetVenus.Equals(planetEarth));

Console.WriteLine("\r\nАнонимный тип объекта Марс: " + planetMars);
Console.WriteLine("Планета эквивалентна Венере? " + planetVenus.Equals(planetMars));

Console.WriteLine("\r\nАнонимный тип объекта Венера: " + planetVenusAgain);
Console.WriteLine("Планета эквивалентна Венере? " + planetVenus.Equals(planetVenusAgain));