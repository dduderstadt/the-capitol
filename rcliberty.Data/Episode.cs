//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rcliberty.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Episode
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string AudioUrl { get; set; }
        public Nullable<int> SeriesId { get; set; }
        public string Details { get; set; }
    
        public virtual Series Series { get; set; }
    }
}