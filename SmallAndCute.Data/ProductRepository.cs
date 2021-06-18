using Catalog.Domain;
using Catalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallAndCute.Data
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _products = new List<Product> {
            new Product {
                Id = Guid.NewGuid(),
                Title = "Наши 12 Месяцев (пастель)",
                Description = @"В упаковке 12 наклеек с цифрами в пастельных розово-пудровых оттенках для милых фото вашего малыша. 
                                Размер наклеек: общий диаметр 4,5см, диаметр клеевой части 4,2мм.    
                                Материал: 
                                вариант 1: бумага с легким глянцем плотностью 135г/м2 (более ""толстенькая""). 
                                вариант 2: бумага с большим глянцем плотностью 115г/м2 (менее ""толстенькая"").
                                Оригинальная упаковка-конверт размером 8,2*6,2см из бумаги плотностью 160г/м2.",
                Price = 15
            },
            new Product {
                Id = Guid.NewGuid(),
                Title = "Стикеры \"Мурлотики\"",
                Description = @"Домашнии Мурлотики на милых 15 стикерах позируют для ваших страничек",
                Price = 17
            },
            new Product {
                Id = Guid.NewGuid(),
                Title = "Стикеры \"Котя-хвостя\"",
                Description = @"Пушистый хвостик у него,
                                Он не боится никого.
                                Мурлычет он под нос себе,
                                Спешит скорее к детворе.

                                Знакомьтесь - это Котя-хвостя. И он очень спешит на странички к вам.

                                15 стикеров мурлычат каждый день)",
                Price = 17
            },
            new Product {
                Id = Guid.NewGuid(),
                Title = "Стикеры \"Розовые мечты\"",
                Description = @"Розового много не бывает, так ведь? 23 стикера ждут своих страничек",
                Price = 15
            },
            new Product {
                Id = Guid.NewGuid(),
                Title = "Стикеры \"Ночные сказки\"",
                Description = @"23 стикера с акварельными зарисовками погружают в мир ночных сказок и уже спешат на ваши листочки",
                Price = 15
            }
            };

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(_products);
        }

        public async Task<Product> Get(Guid id)
        {
            return await Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
        }
    }
}
