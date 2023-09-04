namespace prog_avanzada_2_tp1.Pages.Enums
{
    public enum DiasDeSemana
    {
        Domingo = 1,
        Lunes = 2,
        Martes = 3,
        Miercoles = 4,
        Jueves = 5,
        Viernes = 6,
        Sabado = 7,

        
    }
    public static class DiasDeSemanaHelper
    {
        public static string Dia(int diaDeLaSemana)
        {
            string nombreDelDia = "Número de día no válido";

            if (Enum.IsDefined(typeof(DiasDeSemana), diaDeLaSemana))
            {
                var dia = (DiasDeSemana)diaDeLaSemana;
                nombreDelDia = dia.ToString();
            }

            return nombreDelDia;
        }
    }
}
