using System;
using Newtonsoft.Json;

namespace _38.FacebookApi
{
    //Ejemplo de acceso a la API de facebook.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 38 Acceso a la API de facebook ----------");

            //token.
            string fbtoken= "EAAQVfUscfC0BAJIPJtQyyHT865i8p3HEqkVWCR6P5jDBAZB1MtZCWpPma34s3iPk4ZB43ZA7YZBznOkZBNAnIKGeGFn5op5rkTknfpAv9YwZBjqSfIhniq1mPhNYuZBhgXaNbtdzVbK1p31IbGcO5PFSZCKRGbpQ2bx7MoPjRZBM7LRSFduQdMIOTgblfQAUYHuyUDoWd2ZBV3t2wZDZD";
            string fbfields= "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb=new FacebookApi(fbtoken);

            string resultado= fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(res);

        }
    }
}
