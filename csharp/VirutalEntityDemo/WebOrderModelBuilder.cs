using System;

using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

using VirutalEntityDemo.Models;

namespace VirutalEntityDemo
{
    public class WebOrderModelBuilder
    {
        public IEdmModel GetEdmModel(IServiceProvider serviceProvider)
        {
            var builder = new ODataConventionModelBuilder(serviceProvider);

            builder.EntitySet<WebOrder>(nameof(WebOrder))
                .EntityType
                .Filter()   // Allow $filter
                .Count()    // Allow $count
                .Expand()   // Allow $expand 
                .OrderBy()  // Allow $orderby 
                .Page()     // Allow $top and $skip
                .Select();  // Allow $select 

            return builder.GetEdmModel();
        }
    }
}
