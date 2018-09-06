using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;


namespace Parser2.Models
{
    public static class SampleData
    {
        public static void Initialize(LaptopContext context)
        {
            if (!context.Laptops.Any())
            {
                context.Laptops.AddRange(
                    new Laptop
                    {
                        Name = "Lenova",
                        Image = "https://www.google.com.ua/imgres?imgurl=https%3A%2F%2Fwww.lenovo.com%2Fmedias%2Flenovo-laptop-lenovo-v330-15-hero.png%3Fcontext%3DbWFzdGVyfHJvb3R8NzA2MTd8aW1hZ2UvcG5nfGg5ZS9oYmIvOTU4MTAyNDE4MjMwMi5wbmd8ZTc2NTlmMDAxOWExNmUzYWI2NDE2N2I0YTkzNmMyY2RhOWZlMDA2ZTY5MDY0MTE4ZjgyYmNkZTcwMzI2OTQzZQ&imgrefurl=https%3A%2F%2Fwww.lenovo.com%2Fua%2Fuk%2Flaptops%2Flenovo%2Fv-series%2FV330-15%2Fp%2F88LG80V0912&docid=xhyCXc4dmy0QcM&tbnid=X-PD7WdjSaazyM%3A&vet=10ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA..i&w=725&h=515&bih=697&biw=1304&q=lenovo&ved=0ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA&iact=mrc&uact=8",
                        Price = 6000
                    },
                    new Laptop
                    {
                        Name = "Lenova",
                        Image = "https://www.google.com.ua/imgres?imgurl=https%3A%2F%2Fwww.lenovo.com%2Fmedias%2Flenovo-laptop-lenovo-v330-15-hero.png%3Fcontext%3DbWFzdGVyfHJvb3R8NzA2MTd8aW1hZ2UvcG5nfGg5ZS9oYmIvOTU4MTAyNDE4MjMwMi5wbmd8ZTc2NTlmMDAxOWExNmUzYWI2NDE2N2I0YTkzNmMyY2RhOWZlMDA2ZTY5MDY0MTE4ZjgyYmNkZTcwMzI2OTQzZQ&imgrefurl=https%3A%2F%2Fwww.lenovo.com%2Fua%2Fuk%2Flaptops%2Flenovo%2Fv-series%2FV330-15%2Fp%2F88LG80V0912&docid=xhyCXc4dmy0QcM&tbnid=X-PD7WdjSaazyM%3A&vet=10ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA..i&w=725&h=515&bih=697&biw=1304&q=lenovo&ved=0ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA&iact=mrc&uact=8",
                        Price = 15500
                    },
                    new Laptop
                    {
                        Name = "Lenova",
                        Image = "https://www.google.com.ua/imgres?imgurl=https%3A%2F%2Fwww.lenovo.com%2Fmedias%2Flenovo-laptop-lenovo-v330-15-hero.png%3Fcontext%3DbWFzdGVyfHJvb3R8NzA2MTd8aW1hZ2UvcG5nfGg5ZS9oYmIvOTU4MTAyNDE4MjMwMi5wbmd8ZTc2NTlmMDAxOWExNmUzYWI2NDE2N2I0YTkzNmMyY2RhOWZlMDA2ZTY5MDY0MTE4ZjgyYmNkZTcwMzI2OTQzZQ&imgrefurl=https%3A%2F%2Fwww.lenovo.com%2Fua%2Fuk%2Flaptops%2Flenovo%2Fv-series%2FV330-15%2Fp%2F88LG80V0912&docid=xhyCXc4dmy0QcM&tbnid=X-PD7WdjSaazyM%3A&vet=10ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA..i&w=725&h=515&bih=697&biw=1304&q=lenovo&ved=0ahUKEwipm-ecl6fdAhWHkCwKHWD-CrsQMwg2KAAwAA&iact=mrc&uact=8",
                        Price = 50000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
