using En_Content_Layout_Domain_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Infrastructure_Layer
{
    public class ContentLayoutContext : DbContext
    {
        public ContentLayoutContext(DbContextOptions<ContentLayoutContext> options) : base (options) { }
        public DbSet<AdminPage> AdminPages { get; set; }
        public DbSet<LayoutHistory> LayoutHistory { get; set; }
        public DbSet<PageWidget> PageWidgets { get; set; }
        public DbSet<WidgetConfig> WidgetConfig { get; set; }
    }
}
