using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using prog_avanzada_2_tp1.Pages.Enums;

namespace prog_avanzada_2_tp1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public int Numero1 { get; set; }

        [BindProperty]
        public int Numero2 { get; set; }

        public int? Resultado { get; set; }
        [BindProperty]
        public string? StringInput { get; set; }

        public DateTime fechaHoraActual = DateTime.Now;
        public string NombreDelDia { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.ObtenerFechaHoraActual();
            NombreDelDia = DiasDeSemanaHelper.Dia(1);
        }

        public void OnGetDatetime()
        {
            this.ObtenerFechaHoraActual();
        }

        public void OnPostSum()
        {
            Resultado = this.sumar(Numero1, Numero2);
        }

        public void OnPostCut()
        {
            if (CortarCadena(StringInput)){
                ViewData["StringResult"] = StringInput;
            }
        }

        /**
         * Suma 2 numeros enteros
         */
        public int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        /**
         * Obtiene los primeros 4 caracteres de un string, si el mismo tiene mas de 8 caracteres
         */
        public bool CortarCadena(string cadena)
        {
            if (!String.IsNullOrEmpty(cadena) && cadena.Length >= 8)
            {
                StringInput = cadena.Substring(0, 4); // Corta la cadena de 0 a 3 (4 caracteres)
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime ObtenerFechaHoraActual()
        {
            // Obtiene la fecha y hora actual del sistema
            this.fechaHoraActual = DateTime.Now;
            return this.fechaHoraActual;
        }
    }
}