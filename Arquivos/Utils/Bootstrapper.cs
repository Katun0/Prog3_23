using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Mauricio Roberto",
                LastName = "Gonzatto",
                CPF = "000.000.000-00",
                Email = "mauricio.gonzatto@unoesc.edu.br"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000.000-01",
                    Email = "eduardo.blank@unoesc.edu.br"                    
                }
            );

             DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Timóteo",
                    CPF = "000.000.000-02",
                    Email = "aguinaldo@unoesc.edu.br"                    
                }
            );            

        }

        public static void ChargeAnimals()
        {
            var a1 = new Animal{
                Id = 1,
                AnimalName = "Millo",
                Specie = "Cachorro",
                Race = "Pug",
                Color = "Branco"
            };
            DataSet.Animals.Add(a1);

            DataSet.Animals.Add(
                new Animal{
                    Id = 2,
                    AnimalName = "Bill",
                    Specie = "Cachorro",
                    Race = "Pug",
                    Color = "Preto"                    
                }
            );

             DataSet.Animals.Add(
                new Animal{
                    Id = 3,
                    AnimalName = "Clara",
                    Specie = "Gato",
                    Race = "Vira-Lata",
                    Color = "Branca"                    
                }
            );            
        }

        public static void ChargeDoctors()
        {
            var d1 = new Doctor{
                Id = 1,
                Name = "Paulo",
                Speciality = "Clinico Geral"
            };
            DataSet.Doctors.Add(d1);

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 2,
                    Name = "Billy",
                    Speciality = "Ortopedista"                    
                }
            );

             DataSet.Doctors.Add(
                new Doctor{
                    Id = 3,
                    Name = "Mary",
                    Speciality = "Infectologista"                    
                }
            );            

        }

        public static void ChargeClinics()
        {
            var c1 = new Clinic{
                Id = 1,
                ClinicName = "Clinica Peixe Seco",
                CNPJ = "00.000.000/0001-00",
                Phone = "35663555",
                Owner = "Aderbaldo"
            };
            DataSet.Clinics.Add(c1);

            DataSet.Clinics.Add(
                new Clinic{
                    Id = 2,
                    ClinicName = "Clinica Pinguim Ajoelhado",
                    CNPJ = "00.000.000/0001-01",
                    Phone = "35513556",
                    Owner = "Mariana"                    
                }
            );

             DataSet.Clinics.Add(
                new Clinic{
                    Id = 3,
                    ClinicName = "Clinica do Xang",
                    CNPJ = "00.000.000/0001-02",
                    Phone = "35663888",
                    Owner = "Xang"                    
                }
            );            

        }
    }
}