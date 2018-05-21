using System.Web.Http;
using Swashbuckle.Application;

namespace OnlineGames
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "OnlineGames");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                        
                    });
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\Swagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
