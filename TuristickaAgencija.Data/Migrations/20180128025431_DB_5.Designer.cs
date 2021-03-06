﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TuristickaAgencija.Data.DAL;

namespace TuristickaAgencija.Data.Migrations
{
    [DbContext(typeof(TuristickaAgencijaDB))]
    [Migration("20180128025431_DB_5")]
    partial class DB_5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("KontinentId");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DrzavaId");

                    b.HasIndex("KontinentId");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("RegijaId");

                    b.HasKey("GradId");

                    b.HasIndex("RegijaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Grupa", b =>
                {
                    b.Property<int>("GrupaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MaxBrojTurista");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("GrupaId");

                    b.ToTable("Grupe");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Jezik", b =>
                {
                    b.Property<int>("JezikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivJezika")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("JezikId");

                    b.ToTable("Jezici");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.KontakPodaci", b =>
                {
                    b.Property<int>("KontaktId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(80);

                    b.Property<int>("KorisnikId");

                    b.Property<string>("Telefon")
                        .HasMaxLength(30);

                    b.HasKey("KontaktId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("KontaktPodaci");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Kontinent", b =>
                {
                    b.Property<int>("KontinentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("KontinentId");

                    b.ToTable("Kontinenti");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<DateTime>("DatumZadnjePrijave");

                    b.Property<int>("GradId");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<bool>("isAktivan");

                    b.Property<bool>("isPromjenoLozinku");

                    b.HasKey("KorisnikId");

                    b.HasIndex("GradId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.KreditnaKartica", b =>
                {
                    b.Property<int>("KarticaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojKartice")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<int>("GodinaIsteka");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("MjesecIsteka");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("KarticaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("KreditneKartice");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Licenca", b =>
                {
                    b.Property<int>("LicencaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumStjecanja");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SerijskiBrojLicence")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<int>("VodicId");

                    b.HasKey("LicencaId");

                    b.HasIndex("VodicId");

                    b.ToTable("Licence");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Plata", b =>
                {
                    b.Property<int>("PlataId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DatumIsplate");

                    b.Property<bool>("Isplaceno");

                    b.Property<double>("Iznos");

                    b.Property<int>("ZaposlenikId");

                    b.HasKey("PlataId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Plate");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Ponuda", b =>
                {
                    b.Property<int>("PonudaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<DateTime>("DatumPocetka");

                    b.Property<DateTime>("DatumZavrsetka");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("isAktivna");

                    b.HasKey("PonudaId");

                    b.ToTable("Ponude");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.PrevoznoSredstvo", b =>
                {
                    b.Property<int>("PrevoznoSredstvoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("PrevoznoSredstvoId");

                    b.ToTable("PrevoznaSredstva");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.PutovanjaGrupe", b =>
                {
                    b.Property<int>("PutovanjeGrupeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumPutovanja");

                    b.Property<int>("GrupaId");

                    b.Property<int>("RezervacijaId");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("PutovanjeGrupeId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("RezervacijaId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("PutovanjaGrupe");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Putovanje", b =>
                {
                    b.Property<int>("PutovanjeId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cijena");

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<DateTime>("DatumPolaska");

                    b.Property<DateTime>("DatumPovratka");

                    b.Property<int>("GradId");

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.Property<int?>("PonudaId");

                    b.Property<int?>("Popust");

                    b.Property<int>("PrevoznoSredstvoId");

                    b.Property<bool>("isAktivno");

                    b.HasKey("PutovanjeId");

                    b.HasIndex("GradId");

                    b.HasIndex("PonudaId");

                    b.HasIndex("PrevoznoSredstvoId");

                    b.ToTable("Putovanja");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.PutovanjeSmjestaj", b =>
                {
                    b.Property<int>("PutovanjeSmjestajId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PutovanjeId");

                    b.Property<int>("SmjestajId");

                    b.HasKey("PutovanjeSmjestajId");

                    b.HasIndex("PutovanjeId");

                    b.HasIndex("SmjestajId");

                    b.ToTable("PutvanjaSmjestaji");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Recenzija", b =>
                {
                    b.Property<int>("RecenzijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKomentara");

                    b.Property<string>("Komentar")
                        .HasMaxLength(500);

                    b.Property<int?>("Ocjena");

                    b.Property<int>("RezervacijaId");

                    b.HasKey("RecenzijaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Regija", b =>
                {
                    b.Property<int>("RegijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RegijaId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Regije");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRezervacije");

                    b.Property<int>("PutovanjeId");

                    b.Property<int?>("PutovanjeSmjestajId");

                    b.Property<int>("StanjeId");

                    b.Property<int>("TuristId");

                    b.Property<double>("UkupanIznos");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("PutovanjeId");

                    b.HasIndex("PutovanjeSmjestajId");

                    b.HasIndex("StanjeId");

                    b.HasIndex("TuristId");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Smjestaj", b =>
                {
                    b.Property<int>("SmjestajId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojZvjezdica");

                    b.Property<int>("GradId");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.Property<double>("StandardnaCijena");

                    b.Property<string>("WebStranica")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("isAktivan");

                    b.HasKey("SmjestajId");

                    b.HasIndex("GradId");

                    b.ToTable("Smjestaji");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Stanje", b =>
                {
                    b.Property<int>("StanjeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StanjeRezervacije");

                    b.HasKey("StanjeId");

                    b.ToTable("Stanja");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("StatusId");

                    b.ToTable("Statusi");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.StepenTurista", b =>
                {
                    b.Property<int>("StepenTuristaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Stepen");

                    b.HasKey("StepenTuristaId");

                    b.ToTable("StepeniTurista");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.StepenVodica", b =>
                {
                    b.Property<int>("StepenVodicaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Stepen");

                    b.HasKey("StepenVodicaId");

                    b.ToTable("StepeniVodica");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Turist", b =>
                {
                    b.Property<int>("TuristId");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("StepenTuristaId");

                    b.HasKey("TuristId");

                    b.HasIndex("StepenTuristaId");

                    b.ToTable("Turisti");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.VodicJezik", b =>
                {
                    b.Property<int>("VodicJezikId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JezikId");

                    b.Property<string>("Stepen")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("ZaposlenikId");

                    b.HasKey("VodicJezikId");

                    b.HasIndex("JezikId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("VodiciJezici");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumZahtjeva");

                    b.Property<string>("Razlog")
                        .IsRequired();

                    b.Property<int>("StatusId");

                    b.Property<int?>("ZaposlenikRadnikId");

                    b.Property<int>("ZaposlenikVodicId");

                    b.HasKey("ZahtjevId");

                    b.HasIndex("StatusId");

                    b.HasIndex("ZaposlenikRadnikId");

                    b.HasIndex("ZaposlenikVodicId");

                    b.ToTable("Zahtjevi");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikId");

                    b.Property<DateTime>("DatumZaposljavanja");

                    b.Property<bool>("IsVodic");

                    b.Property<int>("MjeseciIskustva");

                    b.Property<int?>("StepenVodicaId");

                    b.HasKey("ZaposlenikId");

                    b.HasIndex("StepenVodicaId");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.ZaposlenikIzmjenaPutovanja", b =>
                {
                    b.Property<int>("IzmjenaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<int>("PutvanjeId");

                    b.Property<int>("ZaposlenikId");

                    b.HasKey("IzmjenaId");

                    b.HasIndex("PutvanjeId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("IzmjenePutovanja");
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Drzava", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Kontinent", "Kontinent")
                        .WithMany()
                        .HasForeignKey("KontinentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Grad", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Regija", "Regija")
                        .WithMany()
                        .HasForeignKey("RegijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.KontakPodaci", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Korisnik", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.KreditnaKartica", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Licenca", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "Vodic")
                        .WithMany()
                        .HasForeignKey("VodicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Plata", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.PutovanjaGrupe", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Grupa", "Grupa")
                        .WithMany()
                        .HasForeignKey("GrupaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Putovanje", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TuristickaAgencija.Data.Models.Ponuda", "Ponuda")
                        .WithMany()
                        .HasForeignKey("PonudaId");

                    b.HasOne("TuristickaAgencija.Data.Models.PrevoznoSredstvo", "PrevnoznoSredstvo")
                        .WithMany()
                        .HasForeignKey("PrevoznoSredstvoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.PutovanjeSmjestaj", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Putovanje", "Putovanje")
                        .WithMany()
                        .HasForeignKey("PutovanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Smjestaj", "Smjestaj")
                        .WithMany()
                        .HasForeignKey("SmjestajId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Recenzija", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Regija", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Rezervacija", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Putovanje", "Putovanje")
                        .WithMany()
                        .HasForeignKey("PutovanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.PutovanjeSmjestaj", "PutovanjeSmjestaj")
                        .WithMany()
                        .HasForeignKey("PutovanjeSmjestajId");

                    b.HasOne("TuristickaAgencija.Data.Models.Stanje", "Stanje")
                        .WithMany()
                        .HasForeignKey("StanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Turist", "Turist")
                        .WithMany()
                        .HasForeignKey("TuristId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Smjestaj", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Turist", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.StepenTurista", "StepenTurista")
                        .WithMany()
                        .HasForeignKey("StepenTuristaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("TuristId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.VodicJezik", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Jezik", "Jezik")
                        .WithMany()
                        .HasForeignKey("JezikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Zahtjev", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "ZaposlenikRadnik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikRadnikId");

                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "ZaposlenikVodic")
                        .WithMany()
                        .HasForeignKey("ZaposlenikVodicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.Zaposlenik", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.StepenVodica", "StepenVodica")
                        .WithMany()
                        .HasForeignKey("StepenVodicaId");

                    b.HasOne("TuristickaAgencija.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuristickaAgencija.Data.Models.ZaposlenikIzmjenaPutovanja", b =>
                {
                    b.HasOne("TuristickaAgencija.Data.Models.Putovanje", "Putovanje")
                        .WithMany()
                        .HasForeignKey("PutvanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuristickaAgencija.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
