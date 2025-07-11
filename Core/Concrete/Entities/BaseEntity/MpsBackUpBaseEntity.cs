namespace Core.Concrete.Entities.BaseEntity
{


    /// <summary>
    /// Denetim bilgilerine sahip bir yedek varlığı temsil eder.
    /// </summary>
    public sealed class MpsBackUpBaseEntity : MpsStandardBaseEntity
    {
        private const string DefaultUserId = "System";
        private const string DefaultMessage = "System";
        /// <summary>
        /// <see cref="MpsBackUpBaseEntity"/> sınıfının yeni bir örneğini başlatır.
        /// </summary>
        /// <param name="userId">Değişikliği yapan kullanıcı.</param>
        /// <param name="message">Değişikliğin açıklaması.</param>
        /// <param name="backUpCounter">Verilerde yapılan değişiklik sayısı.</param>
        public MpsBackUpBaseEntity(
                string userId = DefaultUserId,
                string message = DefaultMessage,
                int backUpCounter = 0)
        {
            // BackUp files cannot be deleted.
            ReallyDeleted = false;
            UserId = userId;
            Message = message;
            BackUpCounter = backUpCounter;
        }

        /// <summary>
        /// Değişikliği yapan kullanıcıyı alır veya ayarlar.
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Neyin ne zaman değiştirildiğinin açıklamasını alır veya ayarlar.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Verilerde yapılan değişikliklerin sayısını alır veya ayarlar.
        /// </summary>
        public int BackUpCounter { get; set; }
    }
}
