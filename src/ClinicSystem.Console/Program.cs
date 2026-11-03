using ClinicSystem.Domain.ValueObjects;
using ClinicSystem.Domain.Entities;
using ClinicSystem.Domain.Enums;

namespace ClinicSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("João Guilherme Braz Oliveira", "santospintomelooo@gmail.com", new Phone("79996127874"), new Address("Rua Cabo Jordino", "18 do Forte", "Aracaju"), new Cpf("00000000000"), new DateTime(2008, 01, 29));

            Dentist dentist = new Dentist("Dugleise Braz Silva", "dugbraz@gmail.com", new Phone("79999359485"), new Address("Rua Cabo Jordino", "18 do Forte", "Aracaju"), new Cpf("00000000000"));

            Procedure procedure = new PreventiveProcedures("Limpeza", Specialty.General, new Money(100.00), 6);

            
        }
    }
}

