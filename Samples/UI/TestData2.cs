using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class TestData2
    {
        public class Item
        {
            public Item(int idp, string namep, string descriptionp)
            {
                id = idp;
                name = namep;
                description = descriptionp;
            }
            public int id { get; set; }
            public string? name { get; set; }
            public string? description { get; set; }
        }

        static public List<Item> dataForTest = new List<Item>()
        {
            new Item(1,"Item 1", "Tenemos el place ... $ 0"),
            new Item(2,"Item 2", "Este es el nji $ 0"),
            new Item(3,"Item 3", "Lorems Lorems Loersmnas! $ 0"),
            new Item(4,"Item 4", "Stronmg strong striong! string! $ 0"),
        };

    }
}
