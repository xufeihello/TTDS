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
    
    public partial class t_peripheraldimensions
    {
        public string ID { get; set; }
        public string TireID { get; set; }
        public Nullable<int> ConditionID { get; set; }
        public Nullable<decimal> OuterPerimeter1 { get; set; }
        public Nullable<decimal> SW1 { get; set; }
        public Nullable<decimal> CrownArcLength1 { get; set; }
        public Nullable<decimal> CrownArcDiameter1 { get; set; }
        public Nullable<decimal> GrooveDepth1 { get; set; }
        public Nullable<decimal> WearDepth1 { get; set; }
        public Nullable<decimal> OuterPerimeter2 { get; set; }
        public Nullable<decimal> SW2 { get; set; }
        public Nullable<decimal> CrownArcLength2 { get; set; }
        public Nullable<decimal> CrownArcDiameter2 { get; set; }
        public Nullable<decimal> GrooveDepth2 { get; set; }
        public Nullable<decimal> WearDepth2 { get; set; }
        public Nullable<decimal> OuterPerimeter3 { get; set; }
        public Nullable<decimal> SW3 { get; set; }
        public Nullable<decimal> CrownArcLength3 { get; set; }
        public Nullable<decimal> CrownArcDiameter3 { get; set; }
        public Nullable<decimal> GrooveDepth3 { get; set; }
        public Nullable<decimal> WearDepth3 { get; set; }
    
        public virtual t_condition t_condition { get; set; }
        public virtual tire tire { get; set; }
    }
}
