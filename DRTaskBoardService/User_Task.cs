//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DRTaskBoardService
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Task
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int TaskID { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
