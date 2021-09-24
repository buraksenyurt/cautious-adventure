using AutoMapper;

namespace EasyMapping.Mappings
{
    /*
     * Nesneler çoğaldıkça sürekli CreateMap fonksiyon çağrısı eklememeliyiz.
     * Yeni bir nesne mi eklendi? AutoMapper bunu kolayca algılamalı.
     * Arayüzü PlayerModel,GameModel ve gelecek başka nesne varsa onlara uygulamak gerekiyor.
     */
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
