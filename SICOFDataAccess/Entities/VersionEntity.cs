using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SICOFDataAccess.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFDataAccess.Entities
{
    public class VersionEntity: BaseEntity
    {
        //[Key] Todo: Instalar Nugets para Annotation Entity Framework
        public Guid Id { get; set; }
        public string NombrePlataforma { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string NumeroVersion { get; set; }
        public string Ambiente { get; set; }
        public string RamaOrigen { get; set; }
        public string Descripcion { get; set; }
             
    }


    public class VersionEntityMap
    {
        public VersionEntityMap(EntityTypeBuilder<VersionEntity> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Version");

            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.NombrePlataforma).HasColumnName("Nombre_Plataforma").HasMaxLength(255);
            entityTypeBuilder.Property(x => x.FechaPublicacion).HasColumnName("Fecha_Publicacion");
            entityTypeBuilder.Property(x => x.NumeroVersion).HasColumnName("Numero_Version").HasMaxLength(20);
            entityTypeBuilder.Property(x => x.Ambiente).HasMaxLength(20);
            entityTypeBuilder.Property(x => x.RamaOrigen).HasColumnName("Rama_Origen").HasMaxLength(20);
            entityTypeBuilder.Property(x => x.Descripcion).HasMaxLength(1500);


        }

    }
}
