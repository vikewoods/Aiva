//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aiva.Core.Storage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public string DisplayName { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Bio { get; set; }
        public string CreatedAt { get; set; }
        public string TimeSinceCreated { get; set; }
        public string UpdatedAt { get; set; }
        public string TimeSinceUpdated { get; set; }
        public string Logo { get; set; }
    
        public virtual ActiveUsers ActiveUsers { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual TimeWatched TimeWatched { get; set; }
    }
}
