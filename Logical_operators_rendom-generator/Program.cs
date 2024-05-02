using System;

class Logical_operators_rendom_generator
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Taste || ESC");

        do
        {
            // Generiere zwei zufällige boolesche Werte
            bool value1 = random.NextDouble() > 0.5;
            bool value2 = random.NextDouble() > 0.5;

            // Wähle zufällig einen logischen Operator
            int operatorChoice = random.Next(1, 4);
            bool result = false; // Default-Wert für 'result' da es sonst nicht unten gelesen werden kan des ergebnis ist nur im switch
            string explanation = "";

            switch (operatorChoice)
            {
                case 1: // AND
                    result = value1 && value2;
                    explanation = $"({value1} && {value2}) = {result}       < 'AND' liefert 'true' nur, wenn beide Werte 'true' sind >";
                    break;
                case 2: // OR
                    result = value1 || value2;
                    explanation = $"({value1} || {value2}) = {result}       < 'OR' liefert 'true', wenn mindestens einer der Werte 'true' ist >";
                    break;
                case 3: // NOT
                    result = !value1;
                    explanation = $"!{value1} = {result}                    < 'NOT' kehrt den Wert um, also";
                    break;
            }

            Console.WriteLine($"{explanation} Ergebnis: {result}");
            Console.WriteLine("\n");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
