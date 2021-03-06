/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using Easy.CMS.Section.Models;
using Newtonsoft.Json.Linq;

namespace Easy.CMS.Section.ContentJsonConvert
{
    class SectionContentJsonConverter : JsonCreationConverter<SectionContent>
    {
        protected override SectionContent Create(Type objectType, JObject jObject)
        {
            var contentType = jObject["SectionContentType"].Value<int>();
            switch (contentType)
            {
                case (int)SectionContentBase.Types.CallToAction:
                    {
                        return new SectionContentCallToAction();
                    }
                case (int)SectionContentBase.Types.Image:
                    {
                        return new SectionContentImage();
                    }
                case (int)SectionContentBase.Types.Paragraph:
                    {
                        return new SectionContentParagraph();
                    }
                case (int)SectionContentBase.Types.Title:
                    {
                        return new SectionContentTitle();
                    }
                case (int)SectionContentBase.Types.Video:
                    {
                        return new SectionContentVideo();
                    }
                default: return new SectionContent();
            }
        }
    }
}
