//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CONTATO
    {
        public int ID { get; set; }
        public string NM_CONTATO { get; set; }
        public string DS_TELEFONE { get; set; }
        public string DS_EMAIL { get; set; }
        public System.DateTime DS_NASCIMENTO { get; set; }
        public int ID_SEXO { get; set; }
    
        public virtual TB_SEXO TB_SEXO { get; set; }
    }
}
