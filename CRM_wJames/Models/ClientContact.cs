//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_wJames.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientContact
    {
        public int ClientContactID { get; set; }
        public int ClientID { get; set; }
        public int ContactID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
