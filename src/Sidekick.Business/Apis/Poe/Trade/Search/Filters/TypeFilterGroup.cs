namespace Sidekick.Business.Apis.Poe.Trade.Search.Filters
{
    public class TypeFilterGroup
    {
        public bool Disabled { get; set; }
        public TypeFilter Filters { get; set; } = new TypeFilter();
    }
}
