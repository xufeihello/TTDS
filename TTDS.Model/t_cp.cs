//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTDS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_cp
    {
        public string ID { get; set; }
        public string TireID { get; set; }
        public Nullable<int> ConditionID { get; set; }
        public Nullable<decimal> Load1 { get; set; }
        public Nullable<decimal> LS1 { get; set; }
        public Nullable<decimal> AS1 { get; set; }
        public Nullable<decimal> Load2 { get; set; }
        public Nullable<decimal> LS2 { get; set; }
        public Nullable<decimal> AS2 { get; set; }
        public Nullable<decimal> Load3 { get; set; }
        public Nullable<decimal> LS3 { get; set; }
        public Nullable<decimal> AS3 { get; set; }
        public Nullable<decimal> Load4 { get; set; }
        public Nullable<decimal> LS4 { get; set; }
        public Nullable<decimal> AS4 { get; set; }
        public Nullable<decimal> Load5 { get; set; }
        public Nullable<decimal> LS5 { get; set; }
        public Nullable<decimal> AS5 { get; set; }
    
        public virtual t_condition t_condition { get; set; }
        public virtual tire tire { get; set; }
    }
}
