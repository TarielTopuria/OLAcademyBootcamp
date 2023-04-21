using OLAcademyBootcamp.Exercises;

/*
პირველი დავალება
იუზერის და პაროლის განსაზღვრა ხდება ობიექტის შექმნისას კონსტრუქტორში არგუმენტების გადაცემით,
credentialsChecker() მეთოდი კი უზრუნველყოფს კონსოლიდან შეყვანილი ინფორმაციისა და არგუმენტად გადაცემული მნიშვნელობების შედარებას.
*/

ExerciseOne exerciseOne = new ExerciseOne("TatoTopuria", "Tato123");
Console.WriteLine(exerciseOne.credentialsChecker());

/*
მეორე დავალება
მეორე დავალებაში გამოვიყენე სტატიკური მეთოდი, შესაბამისად ობიექტის შექმნა საჭირო არ არის.
*/

Console.WriteLine(ExerciseTwo.decimalToBinary());

/*
მესამე დავალება
მესამე დავალებაში ExerciseThree კლასში დავამატე მხოლოდ ორი სტატიკური მეთოდი, რომელსაც ორი ან სამი პარამეტრი გადაეცემა არგუმენტად
ასევე, გამოვიყენე documentation comment, რათა აღმეწერა მეთოდი.
*/

Console.WriteLine($"Area = {ExerciseThree.multiplicationMethod(15.5, 23.1)}");
Console.WriteLine($"Volume = {ExerciseThree.multiplicationMethod(6.5, 13.6, 10)}");