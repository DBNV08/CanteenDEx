//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CanteenDEx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int IDProduct { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> MaxDiscount { get; set; }
        public Nullable<int> Manufacturer { get; set; }
        public Nullable<int> Supplier { get; set; }
        public Nullable<int> TypeProduct { get; set; }
        public Nullable<int> Current { get; set; }
        public Nullable<int> Count { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }
    
        public virtual Manufacturers Manufacturers { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual TypeProduct TypeProduct1 { get; set; }
    }
}
