namespace Macaco.Infraestructure.Mapping
{
    public class AutoMapperService : IMapper
    {
        public TItem Map<TDomain, TItem>(TDomain domain) where TItem : class
        {
            return AutoMapper.Mapper.Map<TDomain, TItem>(domain);
        }
    }
}
