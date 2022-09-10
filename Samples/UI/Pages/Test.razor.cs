using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages
{
    public partial class Test
    {
        private void OnChangeItem(TestData2.Item? e)
        {
            Console.WriteLine(e);
        }
    }
}
