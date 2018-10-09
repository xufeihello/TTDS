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
    
    public partial class tbrsectiondimension
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbrsectiondimension()
        {
            this.structure = new HashSet<structure>();
            this.structure1 = new HashSet<structure>();
        }
    
        public int SectionID { get; set; }
        public Nullable<decimal> W1B { get; set; }
        public Nullable<decimal> W2B { get; set; }
        public Nullable<decimal> W3B { get; set; }
        public Nullable<decimal> W4B { get; set; }
        public Nullable<decimal> W0B { get; set; }
        public Nullable<decimal> P0B { get; set; }
        public Nullable<decimal> TG1 { get; set; }
        public Nullable<decimal> TG2 { get; set; }
        public Nullable<decimal> TG3 { get; set; }
        public Nullable<decimal> TG4 { get; set; }
        public Nullable<decimal> TGBE { get; set; }
        public Nullable<decimal> TG0B { get; set; }
        public Nullable<decimal> TFTM { get; set; }
        public Nullable<decimal> TFTM_x { get; set; }
        public Nullable<decimal> TBEC { get; set; }
        public Nullable<decimal> G1B2B { get; set; }
        public Nullable<decimal> TTM_x { get; set; }
        public Nullable<decimal> TTM { get; set; }
        public Nullable<decimal> TTRM { get; set; }
        public Nullable<decimal> TTG { get; set; }
        public Nullable<decimal> TTG_x { get; set; }
        public Nullable<decimal> TTN { get; set; }
        public Nullable<decimal> TTNG_x { get; set; }
        public Nullable<decimal> TCG1 { get; set; }
        public Nullable<decimal> TCG2 { get; set; }
        public Nullable<decimal> TCG3 { get; set; }
        public Nullable<decimal> TCG4 { get; set; }
        public Nullable<decimal> TCGBE { get; set; }
        public Nullable<decimal> TCG0B { get; set; }
        public Nullable<decimal> LTR { get; set; }
        public Nullable<decimal> TSHC { get; set; }
        public Nullable<decimal> D2BSW { get; set; }
        public Nullable<decimal> LMSW { get; set; }
        public Nullable<decimal> LSHC { get; set; }
        public Nullable<decimal> TSTHSC { get; set; }
        public Nullable<decimal> TRCZ_x { get; set; }
        public Nullable<decimal> HSWF { get; set; }
        public Nullable<decimal> LSWF { get; set; }
        public Nullable<decimal> HRCI { get; set; }
        public Nullable<decimal> HSBF { get; set; }
        public Nullable<decimal> LSBF { get; set; }
        public Nullable<decimal> HHBF { get; set; }
        public Nullable<decimal> HWCF { get; set; }
        public Nullable<decimal> LWCF { get; set; }
        public Nullable<decimal> TWCFHSC { get; set; }
        public Nullable<decimal> TBFHWC { get; set; }
        public Nullable<decimal> LIL { get; set; }
        public Nullable<decimal> HSC { get; set; }
        public Nullable<decimal> HWCO { get; set; }
        public Nullable<decimal> HWCI { get; set; }
        public Nullable<decimal> LWC { get; set; }
        public Nullable<decimal> H1NO { get; set; }
        public Nullable<decimal> H2NO { get; set; }
        public Nullable<decimal> H3NO { get; set; }
        public Nullable<decimal> H4NI { get; set; }
        public Nullable<decimal> H5NI { get; set; }
        public Nullable<decimal> TAPL { get; set; }
        public Nullable<decimal> TTIL { get; set; }
        public Nullable<decimal> TSTZ_x { get; set; }
        public Nullable<decimal> TTZ_x1 { get; set; }
        public Nullable<decimal> TBFHSC { get; set; }
        public Nullable<decimal> TSBFZ_x { get; set; }
        public Nullable<decimal> TTBDZ_x { get; set; }
        public Nullable<decimal> TBRC { get; set; }
        public Nullable<decimal> LST { get; set; }
        public Nullable<decimal> HRC { get; set; }
        public Nullable<decimal> TTZ_x2 { get; set; }
        public Nullable<decimal> TTZ { get; set; }
        public Nullable<decimal> TRCBD { get; set; }
        public Nullable<decimal> TILHWC { get; set; }
        public Nullable<decimal> L1N { get; set; }
        public Nullable<decimal> H1NI { get; set; }
        public Nullable<decimal> H2N { get; set; }
        public Nullable<decimal> H2NI { get; set; }
        public Nullable<decimal> L3N { get; set; }
        public Nullable<decimal> L3NI { get; set; }
        public Nullable<decimal> LWNCA { get; set; }
        public Nullable<decimal> L4N { get; set; }
        public Nullable<decimal> L4NI { get; set; }
        public Nullable<decimal> L5NI { get; set; }
        public Nullable<decimal> Alpha { get; set; }
        public Nullable<decimal> Beta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<structure> structure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<structure> structure1 { get; set; }
    }
}
