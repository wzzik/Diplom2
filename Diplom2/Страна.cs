//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Страна
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Страна()
        {
            this.Декларация = new HashSet<Декларация>();
        }
    
        public int Id_Страны { get; set; }
        public string НазваниеСтраны { get; set; }
        public string НазваниеЖДстанции { get; set; }
        public string НаправлениеЖД { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Декларация> Декларация { get; set; }
    }
}
