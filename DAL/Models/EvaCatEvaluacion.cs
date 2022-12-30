using System;
using System.Collections.Generic;

namespace eva2DWSATG.Models;

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string DescEvaluacion { get; set; } = null!;

    public virtual ICollection<EvaTchNotasEvaluación> EvaTchNotasEvaluacións { get; } = new List<EvaTchNotasEvaluación>();
}
