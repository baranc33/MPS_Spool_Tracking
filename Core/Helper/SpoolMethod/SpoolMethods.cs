namespace Core.Helper.SpoolMethod
{
    public static class SpoolMethods
    { // ön imalat bekliyor 0
        // ön imalat başladı 1 
        // ön imalat bitti 2
        // kaynak  başladı 3
        // kaynak kök bitti 4
        // kaynak kapak başladı 5
        // kaynak bitti 6 
        // Kalite Kontrol Yapıldı 7 
        // sevk bekliyor 8
        // sevk edildi  9
        public static string WhereIsSpool(byte spoolStatus)
        {

            switch (spoolStatus)
            {
                case 0: return "İmalat Bekleniyor";
                case 1: return "İmalat Başladı";
                case 2: return "Kaynak Bekleniyor";//İmalat Bitti / 
                case 3: return "Kaynakta Başladı";
                case 4: return "K.K. Bekleniyor";
                case 5: return "Sevk Bekleniyor";
                case 6: return "Sevk Edildi";
                case 7: return "Tersanede";
                case 8: return "Montaj Yapıldı";
                default:
                    return "Bilinmiyor";
            }

        }
    }
}
