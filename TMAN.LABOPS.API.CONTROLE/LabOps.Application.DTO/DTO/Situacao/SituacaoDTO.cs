﻿namespace LabOps.Application.DTO.DTO.Situacao
{
    public class SituacaoDTO
    {
        public int IDSituacao { get; set; }
        public string Descricao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}