using Mapper;
using Mapper.ExampleClass;

var map = new Mapping();

var clienteDto = new ClientDTO()
{
    Name = "TesteNome",
    Email = "Email@email.com",
    Password = "Password",
    Phone = "123456789"
};

map.Map<ClientEntity>(clienteDto);

// var retorno = map.Map<ClientEntity>(clienteDto);
//
// Console.WriteLine($"Nome: {retorno.Name}");
// Console.WriteLine($"Email: {retorno.Email}");
// Console.WriteLine($"Password: {retorno.Password}");
// Console.WriteLine($"Telefone: {retorno.Phone}");