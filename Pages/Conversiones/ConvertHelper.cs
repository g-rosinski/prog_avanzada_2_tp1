namespace prog_avanzada_2_tp1.Pages.Conversiones
{
    public class ConvertHelper
    {
        public static void BooleanParse()
        {
            bool resultado1 = Convert.ToBoolean(true); // Devuelve true
            bool resultado2 = Convert.ToBoolean(false); // Devuelve false
            bool resultado3 = Convert.ToBoolean(1);     // Devuelve true
            bool resultado4 = Convert.ToBoolean(0);     // Devuelve false

            bool boolParse1 = bool.Parse("true");  // Devuelve true
            bool boolParse2 = bool.Parse("False"); // Devuelve false

            bool tryParseResult1;
            bool.TryParse("true", out tryParseResult1);  // Devuelve true y establece resultado1 en true

            bool tryParseResult2;
            bool.TryParse("False", out tryParseResult2); // Devuelve true y establece resultado2 en false

            bool tryParseResult3;
            bool.TryParse("no valido", out tryParseResult3); // Devuelve false y deja resultado3 en false

        }

        public static void IntegerParse()
        {
            // a tendrá el valor 344. La parte decimal .4 se trunca.
            int a = (int)344.4;

            // a tendrá el valor 10.0 como un decimal.
            decimal b = 10;

            // Si a es menor o igual a 32,767 (el valor máximo para un short), entonces b tendrá el mismo valor que a
            int c = 443444;

            short d = (short)c;
        }
        public enum Colores
        {
            Blanco,
            Azul,
            Negro
        }

        public static void ColoresEjercicio()
        {
            Colores color = Colores.Azul; // Puedes cambiar el color aquí

            switch (color)
            {
                case Colores.Blanco:
                    Console.WriteLine("El color es Blanco.");
                    break;

                case Colores.Azul:
                    Console.WriteLine("El color es Azul.");
                    break;

                case Colores.Negro:
                    Console.WriteLine("El color es Negro.");
                    break;

                default:
                    Console.WriteLine("Color desconocido.");
                    break;
            }
        }

        public static void MayorA10()
        {
            int a = 15; // Puedes cambiar el valor de 'a' aquí

            if (a > 10)
            {
                Console.WriteLine("El valor es mayor que 10.");
            }
        }

        public static void WhileEjercicio()
        {
            int a = 0; // Inicializamos 'a' en 0

            while (a <= 50) // Mientras 'a' sea menor o igual a 50
            {
                Console.WriteLine("El valor de 'a' es: " + a); // Muestra el valor actual de 'a'
                a += 5; // Incrementa 'a' en 5 en cada ciclo
            }

            Console.WriteLine("El ciclo ha finalizado."); // Mensaje cuando el ciclo termina
        }
    }
}
