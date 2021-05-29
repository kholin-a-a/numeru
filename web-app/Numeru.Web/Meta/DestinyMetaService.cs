namespace Numeru.Web
{
    public class DestinyMetaService : IOpenGraph<DestinyView>, IMetaDescription<DestinyView>
    {
        private readonly string _description;

        public DestinyMetaService()
        {
            this._description = "В мире есть свои закономерности. Узнайте свое предназначение с помощью описания числа судьбы.";
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
            return "Нумерология числа судьбы";
        }
    }
}
