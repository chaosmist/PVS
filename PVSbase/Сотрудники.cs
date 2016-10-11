//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PVSbase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Сотрудники
    {
        public Сотрудники()
        {
            this.Послужной_Список = new HashSet<Послужной_Список>();
            this.Принятое_Сырье = new HashSet<Принятое_Сырье>();
            this.Складские_Помещения = new HashSet<Складские_Помещения>();
        }
    
        public int IDСотрудника { get; set; }
        public string ФИО { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Дата_Рождения { get; set; }
        public string Фото { get; set; }
        public string Пол { get; set; }
        public string Адрес { get; set; }
        public Nullable<int> Телефон { get; set; }
        public string Паспортные_данные { get; set; }
        public string Образование { get; set; }
        public string Должность { get; set; }
    
        public virtual ICollection<Послужной_Список> Послужной_Список { get; set; }
        public virtual ICollection<Принятое_Сырье> Принятое_Сырье { get; set; }
        public virtual ICollection<Складские_Помещения> Складские_Помещения { get; set; }
    }
}
