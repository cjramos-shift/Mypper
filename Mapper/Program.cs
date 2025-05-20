using System.Text.Json;
using Mapper;
using Mapper.ExampleClass;

var map = new Mapping();

var clienteDto = new ClientDTO()
{
    Id = Guid.NewGuid().ToString(),
    Name = "TesteNome",
    Email = "Email@email.com",
    Password = "Password",
    Phone = "123456789"
};

var retorno = map.Map<ClientEntity>(clienteDto);

Console.WriteLine(JsonSerializer.Serialize(retorno));