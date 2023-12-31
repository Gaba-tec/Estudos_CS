﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
	internal class Musica
	{
		[JsonPropertyName("song")]
        public string? Nome { get; set; }

		[JsonPropertyName("artist")]
        public string? Artista  { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }


        public void ExibirMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
			Console.WriteLine($"Música: {Nome}");
			Console.WriteLine($"Duração em segundos: {Duracao}");
			Console.WriteLine($"Gênero musical: {Genero}");
		}
    }
}
