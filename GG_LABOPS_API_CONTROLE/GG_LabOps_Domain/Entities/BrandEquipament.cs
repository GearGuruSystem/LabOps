﻿namespace GG_LabOps_Domain.Entities
{
    public sealed class BrandEquipament : BaseEntity
    {
        public Equipament Equipament { get; set; }
        public string BrandName { get; set; }
    }
}
