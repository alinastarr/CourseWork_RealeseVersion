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
    
    public partial class products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public products()
        {
            this.Structure = new HashSet<Structure>();
        }
    
        public int id_товара { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }
        public string Путь_к_изображению { get; set; }
        public double Вес { get; set; }
        public string Единица_измерения { get; set; }
        public double Цена { get; set; }
        public Nullable<int> id_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Structure> Structure { get; set; }
        public virtual Type1 Type1 { get; set; }
    }
}
