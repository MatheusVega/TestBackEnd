using System;
using System.Collections.Generic;
using System.Text;

namespace Site.Models
{
    public class CursoDisciplinaDTO
    {
        public int CursoCodigo { get; set; }
        public int DisciplinaCodigo { get; set; }

        public CursoDisciplinaDTO(int cursoCodigo, int disciplinaCodigo)
        {
            CursoCodigo = cursoCodigo;
            DisciplinaCodigo = disciplinaCodigo;
        }
    }
}
