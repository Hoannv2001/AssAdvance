using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssAdvance
{
    public interface ISearchBook
    {
        List<BookItems> searchBookItems(string id);
    }
}