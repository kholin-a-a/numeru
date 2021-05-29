namespace Numeru.Web
{
    public class MomentMetaService : IOpenGraph<MomentView>
    {
        public OpenGraphViewModel Data()
        {
            return new OpenGraphViewModel
            {
                Description = "Многое зависит не от вас. Узнайте ответ на свой вопрос с помощью нумерологии момента.",
                Title = "Нумерология момента"
            };
        }
    }
}
