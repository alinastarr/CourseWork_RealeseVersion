//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Курсовик_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Structure
    {
        public int id_состава { get; set; }
        public int id_товара { get; set; }
        public int id_ингридиента { get; set; }
        public double Количество { get; set; }
    
        public virtual ingridients ingridients { get; set; }
        public virtual products products { get; set; }
    }
}
