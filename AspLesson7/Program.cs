//Задание
//< form action = "/Home/Index " method = "post" >
//< label > First </ label >
//< input name = "first" />
//< br />
//< label > Second </ label >
//< input name = "second" />
//< br />
//< label > Count </ label >
//< input type = "number" name = "count" />
//< br />
//< button type = "submit" > Create </ button >
//</ form >
//Создайте представление и скопируйте в него код выше.
//Подготовьте соответствующий метод действия, который сможет получить значения из данной
//формы и отображать их в Output окно Visual Studio. Для решения задачи используйте привязку
//модели.
namespace AspLesson7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}");
            });

            app.Run();
        }
    }
}