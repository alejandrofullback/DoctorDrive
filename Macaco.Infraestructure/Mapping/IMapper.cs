namespace Macaco.Infraestructure.Mapping
{
    public interface IMapper
    {
        TItem Map<TDomain, TItem>(TDomain domain) where TItem : class;
    }
}
