//C# da sana va vaqtlar bilan ishlash uchun DateTime strukturasini o'z ichiga oladi.

//C# da sana va vaqtlar bilan ishlash uchun new kalit so'zodan foydalanib DateTime strukturasi ob'yektni yarating.
//Hozirgi vaqtni olish uchun

DateTime now = DateTime.Now;
Console.WriteLine(now);

//DateTime.Now -> hozirgi tizim vaqtini va sanani qaytaradi.
//now dega o'zgaruvchi xozirgi vaqt va sanani o'z ichiga oladi.

//Belgilangan sanani olish uchun

DateTime specificDate = new DateTime(2024, 8, 31);
Console.WriteLine(specificDate);

//DateTime sinifada operatsiyalar bajarish

//Kun, Oy, va Yil ni olish

DateTime date = new DateTime(2024, 8, 31);
int year = date.Year;
int month = date.Month;
int day = date.Day;

Console.WriteLine($"Yil: {year}, Oy: {month}, Kun: {day}.");

//Vaqt komponentlarini olish

DateTime time = new DateTime(2024, 7, 26, 18, 22, 0);
int hour = time.Hour;
int minute = time.Minute;
int second = time.Second;

Console.WriteLine($"Soat: {hour}, Minute: {minute}, Sekund: {second}.");

//Sanalarni qo'shish va ayirish
//kunga kun qo'shish

DateTime today = DateTime.Today;
DateTime tomorrow = today.AddDays(1);

Console.WriteLine($"Bugun: {today.ToShortDateString()}");
Console.WriteLine($"Ertaga: {tomorrow.ToShortDateString()}");
Console.WriteLine($"Ertaga: {tomorrow.ToLongDateString()}");

DateTime start = new DateTime(2024, 1, 1);
DateTime end = new DateTime(2024, 7, 26);

TimeSpan difference = end - start;
Console.WriteLine($"Farq: {difference.Days} kun");
//difference.Days - TimeSpan obyekti yordami kunlar farqini qaytaradi.