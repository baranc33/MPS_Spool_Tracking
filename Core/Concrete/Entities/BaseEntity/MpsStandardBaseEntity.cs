namespace Core.Concrete.Entities.BaseEntity
{
    public class MpsStandardBaseEntity : MpsTinyBaseEntity
    {

        /// <summary>
        /// The time when the entity was last modified.
        /// </summary>
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// The user who last modified the entity.
        /// </summary>
        public string ModifiedUserName { get; set; }

        /// <summary>
        /// The ID of the last backup record.
        /// </summary>
        public uint? LastBackupId { get; set; }

        /// <summary>
        /// The time when the entity was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        ///// <summary>
        ///// The username of the creator.
        ///// </summary>
        //public string CreateUserName { get; set; }

        //// Oisteğe bağlı olarak değişiklik mantığını kapsülle
        //public void UpdateModifiedInfo(string userName)
        //{
        //    ModifiedTime = DateTime.UtcNow;
        //    ModifiedUserName = userName;
        //}
    }

}
