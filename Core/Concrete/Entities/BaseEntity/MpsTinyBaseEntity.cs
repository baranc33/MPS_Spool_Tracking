namespace Core.Concrete.Entities.BaseEntity
{

    /// <summary>
    /// Base entity for MPS Tiny objects.
    /// </summary>
    public class MpsTinyBaseEntity
    {
        /// <summary>
        /// Unique identifier for the entity.
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Indicates whether the entity is marked as deleted (soft delete).
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Indicates whether the entity is active and usable.
        /// </summary>
        public bool IsWork { get; set; }

        /// <summary>



        /// <summary>
        /// Varlığın kalıcı olarak silinip silinmediğini belirtir.
        /// </summary>
        public bool ReallyDeleted { get; set; }

        public MpsTinyBaseEntity()
        {
            IsDeleted = false;
            IsWork = true;
            ReallyDeleted = false;
        }

        /// <summary>
        /// Varlığı silinmiş olarak işaretleyin
        /// </summary>
        public void Delete()
        {
            IsDeleted = true;
            IsWork = false;
        }

        /// <summary>
        /// Varlığı kalıcı olarak kaldırın.
        /// </summary>
        public void PermanentlyDelete()
        {
            ReallyDeleted = true;
            IsDeleted = true;
            IsWork = false;
        }
    }
}
