namespace NuevoCase.Data.Enums
{
    public enum Times
    {
        EverySecond = 1, //Görevi her saniye çalıştırır.
        EveryFiveSeconds = 2, //Görevi beş saniyede bir çalıştırır.
        EveryTenSeconds = 3, //Görevi on saniyede bir çalıştırır.
        EveryMinute = 4, //Görevi dakikada bir kez çalıştırır.
        EveryFiveMinutes = 5,//Görevi beş dakikada bir çalıştırır.
        EveryTenMinutes = 6, //Görevi on dakikada bir çalıştırır.
        Hourly = 7, //Görevi her saat çalıştırır.
        Daily = 8, //Görevi gece yarısında günde bir kez çalıştırır.
        Weekly = 9 //Görevi haftada bir kez çalıştırır.
    }
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}
