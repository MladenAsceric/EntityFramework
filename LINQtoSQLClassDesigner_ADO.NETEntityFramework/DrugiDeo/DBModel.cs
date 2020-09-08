namespace DrugiDeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class DBModel : DbContext
    {
        // Your context has been configured to use a 'DBModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DrugiDeo.DBModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBModel' 
        // connection string in the application configuration file.
        public DBModel()
            : base("name=DBModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Klijent> Klijenti { get; set; }
        public virtual DbSet<Servis> Servisi { get; set; }
    }

    [Table("Klijenti", Schema = "dbo")]
    public class Klijent
    {
        [Key]
        [Required]
        public int KlijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Naziv klijenta je obavezan.")]
        [MaxLength(40)]
        public string NazivKlijenta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Registarski broj je obavezan.")]
        [MaxLength(20)]
        public string RegistarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Kontakt je obavezan.")]
        [MaxLength(40)]
        public string Kontakt { get; set; }

        [MaxLength(200)]
        public string DodatniKomentar { get; set; }

        public virtual ICollection<Servis> Servisi { get; set; }
    }

    [Table("Servisi", Schema = "dbo")]
    public class Servis
    {
        [Key]
        [Required]
        public int ServisID { get; set; }

        [Required]
        [ForeignKey("Klijent")]
        public int KlijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Datum je obavezan.")]
        public DateTime DatumServisa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Opis usluge je obavezan.")]
        [MaxLength(400)]
        public string OpisUsluge { get; set; }

        public Klijent Klijent { get; set; }
    }
        
}