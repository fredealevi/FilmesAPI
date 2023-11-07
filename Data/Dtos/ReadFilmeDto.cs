﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class ReadFilmeDto
{
    public int Id { get; set; }
    public string Titulo { get; set; }

    public string Genero { get; set; }

    public int Duracao { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    public ICollection<ReadSessaoDto> Sessao { get; set; }
}
