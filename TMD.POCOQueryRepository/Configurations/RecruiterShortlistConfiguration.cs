using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RecruiterShortlistConfiguration : EntityTypeConfiguration<RecruiterShortlist>
    {
        public RecruiterShortlistConfiguration()
        {
            ToTable("RecruiterShortlists");
            //Property(d => d.SimpleSearchInputs.Categories).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
