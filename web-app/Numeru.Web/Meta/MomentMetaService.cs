namespace Numeru.Web
{
    public class MomentMetaService : IOpenGraph<MomentView>, IMetaDescription<MomentView>
    {
        private readonly string _description;

        public MomentMetaService()
        {
            this._description = "Многое зависит не от вас. Узнайте ответ на свой вопрос с помощью нумерологии момента.";
        }

        public OpenGraphViewModel Data()
        {
            return new OpenGraphViewModel
            {
                Description = this._description,
                Title = "Нумерология момента"
            };
        }

        public string Get()
        {
            return this._description;
        }
    }
}
