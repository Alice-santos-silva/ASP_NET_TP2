using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebAppTP2.Pages
{
    public class DefaultModel : PageModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public void OnGet()
        {
            // Criando uma lista de pessoas
            Pessoas = new List<Pessoa>
            {
                new Pessoa("João", 30, "123.456.789-00"),
                new Pessoa("Maria", 25, "987.654.321-00")
            };
        }
    }
}
