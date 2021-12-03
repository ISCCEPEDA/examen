using System.Collections.Generic;

namespace Models
{
    public class ResponseListModel : ResponseServiceModel
    {
        public IEnumerable<object> listado { get; set; }
    }
}
