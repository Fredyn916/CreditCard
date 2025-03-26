using DAO;
using DAO.Interfaces;
using Services;
using Services.Interfaces;

namespace API.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
        builder.Services.AddScoped<IContaRepository, ContaRepository>();
        builder.Services.AddScoped<ICartaoRepository, CartaoRepository>();
        builder.Services.AddScoped<IFaturaRepository, FaturaRepository>();
        builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();

        builder.Services.AddScoped<IClienteService, ClienteService>();
        builder.Services.AddScoped<IContaService, ContaService>();
        builder.Services.AddScoped<ICartaoService, CartaoService>();
        builder.Services.AddScoped<IFaturaService, FaturaService>();
        builder.Services.AddScoped<ITransacaoService, TransacaoService>();
    }
}