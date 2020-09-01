﻿using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Serilog;
using System;

namespace CasaDoCodigo
{
    //DB 1): Startup
    #region Startup
    //Em Startup configuramos o Entity Framework
    //para usar o banco de dados 
    #endregion
    public class Startup
    {
        private readonly ILoggerFactory _loggerFactory;

        public Startup(ILoggerFactory loggerFactory,
            IConfiguration configuration)
        {
            _loggerFactory = loggerFactory;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();

            string connectionString = Configuration.GetConnectionString("Default");

            //DB 2): Configuração EF+Sql Server
            #region Configuração EF+Sql Server
            //O banco de dados SQL Server
            //armazena dados do e-commerce
            //(produtos, pedidos, cadastro, etc.)
            //vide SQL Server Object Explorer 
            #endregion
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connectionString)
            );

            //DB 3): Identity + SQLite
            #region SQLite
            //1.Relacional
            //2.Usa linguagem SQL 
            //3.pequeno
            //4.rápido
            //5.independente
            //6.confiável
            //7.cheio de recursos.
            //8.mais usado no mundo 
            //https://www.sqlite.org/index.html
            #endregion

            //DB 4): EF + SQLite?
            #region EF com outros bancos
            //O Entity Framework pode trabalhar com
            //diversos bancos de dados
            //https://docs.microsoft.com/pt-br/ef/core/providers/index
            #endregion

            services.AddTransient<IDataService, DataService>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IHttpHelper, HttpHelper>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<ICadastroRepository, CadastroRepository>();
            services.AddTransient<IRelatorioHelper, RelatorioHelper>();

            //Para permitir o login externo com a conta da microfot
            //Configurar: https://portal.azure.com/#blade/Microsoft_AAD_RegisteredApps/ApplicationsListBlade
            //Configurando o Provedor Externo Microsoft pelo Azure: https://cursos.alura.com.br/course/aspnet-core-identity/task/57095
            services.AddAuthentication()
                .AddMicrosoftAccount(option =>
                {
                    option.ClientId = Configuration["ExternalLogin:Microsoft:ClienteId"];
                    option.ClientSecret = Configuration["ExternalLogin:Microsoft:ClientSecret"];
                })
                .AddGoogle(option => {
                    option.ClientId = Configuration["ExternalLogin:Google:ClienteId"];
                    option.ClientSecret = Configuration["ExternalLogin:Google:ClientSecret"];
                });

            services.AddHttpClient<IRelatorioHelper, RelatorioHelper>();
        }

        // Este método é chamado pelo runtime.
        // Use este método para configurar o pipeline de requisições HTTP.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            _loggerFactory.AddSerilog();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            //INTEGRACAO 1) adicionar componente Identity
            //ASP.NET Core utiliza o padrão "Cadeia de Responsabilidade (Chain of Responsibility)"
            //https://pt.wikipedia.org/wiki/Chain_of_Responsibility

            app.UseAuthentication();

            //O ASP.NET Core Identity é como se fosse um middleware - um componente intermedipario que vai entrar ni pipeline da aplicação
            //um componente que vai tratar a requisição e direcionar essa requisição para o próximo componente do pipeline ou fazer algum desvio para solicitar login ou novo cadastro
            
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Pedido}/{action=BuscaProdutos}/{codigo?}");
            });

            var dataService = serviceProvider.GetRequiredService<IDataService>();
            dataService.InicializaDBAsync(serviceProvider).Wait();
        }
    }
}
