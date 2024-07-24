﻿namespace LabOps.Application.DTO.DTO.Situacao
{
    public record SituacaoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}