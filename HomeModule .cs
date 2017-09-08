
using Nancy;

namespace webapi
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", p => HttpStatusCode.OK);
            Get("/sayhi", args => "Hello World. This is pretty cool!");
            Get("/home/{name}", args =>
                Response.AsJson(new Person() { Name = args.name })
            );
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
