﻿using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<About> Abouts { get; set; }
        public AboutInfo AboutInfo { get; set; }
        public IEnumerable<AboutOffer> AboutOffers { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public ExpertInfo ExpertInfos { get; set; }
        public Subscribe Subscribes { get; set; }
        public IEnumerable<Say> Says { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
        public BlogInfo BlogInfos { get; set; }
    }
}
