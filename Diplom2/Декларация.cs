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
    
    public partial class Декларация
    {
        public int Id_Декларация { get; set; }
        public Nullable<int> Реестрр { get; set; }
        public int Странаа { get; set; }
        public int Грузополучательь { get; set; }
        public int ВПДД { get; set; }
        public int ВТДД { get; set; }
        public int Складыы { get; set; }
        public string Контакт_номер { get; set; }
        public string Контакт_дата { get; set; }
    
        public virtual Грузополучатель Грузополучатель { get; set; }
        public virtual Отчет_по_складам Отчет_по_складам { get; set; }
        public virtual Реестр Реестр { get; set; }
        public virtual Страна Страна { get; set; }
    }
}
