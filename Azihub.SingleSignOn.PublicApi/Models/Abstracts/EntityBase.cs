using System;

namespace Azihub.SingleSignOn.PublicApi.Models.Abstracts
{
    /// <summary>
    /// This is an abstract base class that entities must inherit from.
    /// This class adds an ID and record creation and update time to inherited classes.
    /// </summary>
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            // Set creation date
            DateTimeCreation = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateTimeCreation { get; set; }
    }
}
