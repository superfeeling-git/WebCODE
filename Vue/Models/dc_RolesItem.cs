//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dc_RolesItem
    {
        public int Roles_Class_ID { get; set; }
        public int RolesID { get; set; }
        public int ClassID { get; set; }
        public byte LanType { get; set; }
    
        public virtual dc_Roles dc_Roles { get; set; }
        public virtual dc_SysItemsClass dc_SysItemsClass { get; set; }
    }
}