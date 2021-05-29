namespace Numeru.Web
{
    public class MomentMetaService : IOpenGraph<MomentView>, IMetaDescription<MomentView>
    {
        private readonly string _description;

        public MomentMetaService()
        {
            this._description = "Многое зависит не от вас. Узнайте ответ на свой вопрос с помощью нумерологии момента.";
        }

        public string Description()
        {
            return this._description;
        }

        public string Get()
        {
            return this._description;
        }

        public string Title()
        {
            return "Нумерология момента";
        }
    }
}
