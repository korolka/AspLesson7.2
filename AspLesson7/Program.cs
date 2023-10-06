//�������
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
//�������� ������������� � ���������� � ���� ��� ����.
//����������� ��������������� ����� ��������, ������� ������ �������� �������� �� ������
//����� � ���������� �� � Output ���� Visual Studio. ��� ������� ������ ����������� ��������
//������.
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