﻿namespace ProEventos.API.DTO
{
    public class EventoDTO
    {
        public long Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImageUrl { get; set; }
    }
}
