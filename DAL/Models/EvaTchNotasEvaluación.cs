using System;
using System.Collections.Generic;

namespace eva2DWSATG.Models;

public partial class EvaTchNotasEvaluación
{
    public string? MdUuid { get; set; }

    public DateTime? MdFch { get; set; }

    public string? CodAlumno { get; set; }

    public int? NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;

    public long IdNotaEvaluacion { get; set; }

    public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
}
