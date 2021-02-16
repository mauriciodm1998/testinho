using System.Collections.Generic;

namespace ProjBalta.ContentContext 
{
    public class Career : Content
    {
        public Career(string title, string url)
            :base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public int TotalCourses => Items.Count;
        
        public IList<CareerItem> Items { get; set; }
        
    }

    
}