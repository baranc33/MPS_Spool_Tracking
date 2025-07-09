using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class HomePage : MpsStandartBaseEntity, IMpsEntity
    {
        public HomePage()
        {
            this.ReallyDeleted = false;
        }
        public string CardTitle { get; set; }
        public string CardContent { get; set; }
        public string CardImage { get; set; }
        public string Sentence1 { get; set; }
        public string Sentence2 { get; set; }
        public string Sentence3 { get; set; }
        public string CardNote { get; set; }
        public string MiniWord1 { get; set; }
        public string MiniTitle1 { get; set; }
        public string MiniLink1 { get; set; }
        public string MiniWord2 { get; set; }
        public string MiniTitle2 { get; set; }
        public string MiniLink2 { get; set; }
        public string MiniWord3 { get; set; }
        public string MiniTitle3 { get; set; }
        public string MiniLink3 { get; set; }
        public string SlideImage1 { get; set; }
        public string SlideTittle1 { get; set; }
        public string SlideContent1 { get; set; }
        public string SlideLink1 { get; set; }
        public string SlideImage2 { get; set; }
        public string SlideTittle2 { get; set; }
        public string SlideContent2 { get; set; }
        public string SlideLink2 { get; set; }
        public string SlideImage3 { get; set; }
        public string SlideTittle3 { get; set; }
        public string SlideContent3 { get; set; }
        public string SlideLink3 { get; set; }

    }
}
