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
    
    public partial class t_airimpermeability
    {
        public string ID { get; set; }
        public string TireID { get; set; }
        public Nullable<int> ConditionID { get; set; }
        public Nullable<decimal> AverageTemperature { get; set; }
        public Nullable<decimal> LowestTemperature { get; set; }
        public Nullable<decimal> HighestTemperature { get; set; }
        public Nullable<decimal> IniPressure { get; set; }
        public Nullable<decimal> UltPressure { get; set; }
        public Nullable<int> Days1 { get; set; }
        public Nullable<decimal> Permeablity1 { get; set; }
        public Nullable<int> Days2 { get; set; }
        public Nullable<decimal> Permeablity2 { get; set; }
    
        public virtual tire tire { get; set; }
        public virtual t_condition t_condition { get; set; }
    }
}
