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
    
    public partial class Самовывоз
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Самовывоз()
        {
            this.Вывоз_угля = new HashSet<Вывоз_угля>();
        }
    
        public int Id_Самовывоз { get; set; }
        public string Сотрудник { get; set; }
        public string Организация { get; set; }
        public string Дата { get; set; }
        public string Номер { get; set; }
        public string ВыдачаТалона { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Вывоз_угля> Вывоз_угля { get; set; }
    }
}
