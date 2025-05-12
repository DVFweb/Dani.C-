using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dani.C_
{
    internal class Pessoa
    {
        //Propriedades
        private int Id { get; set; }
        private string _name { get; set; }
        private string _email { get; set; }
        private int _age { get; set; }
        private Address Endereco { get; set; }
        private DateTime _date { get; set; }
        private string _phone { get; set; } 
        private string _city { get; set; }

        //construtor
        public Pessoa(int id, string name, string email, int age, Address address, DateTime date, string phone, string city) 
        {
            Id = id;
            _name = name;
            _email = email;
            _age = age;
            Endereco = address;
            _date = date;
            _phone = phone;
            _city = city;
        }

        // metodo apresenta os dados
        public override string ToString() 
        {
            return $"Id: {Id}, Nome: {_name}, Email: {_email}, Idade: {_age}, Endereço: {Endereco}, Telefone: {_phone}, Cidade: {_city}, Data: {_date} ";
        }

      



    }
}
