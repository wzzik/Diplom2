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
    
    public partial class Отчет_по_складам
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Отчет_по_складам()
        {
            this.Декларация = new HashSet<Декларация>();
        }
    
        public int Id_ОтчетПоСкладам { get; set; }
        public int НомерСклада { get; set; }
        public string ИмяСклада { get; set; }
        public string ВместимостьСклада { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Декларация> Декларация { get; set; }
    }
}
