using System;
using System.Collections.Generic;

namespace PieShopEmpty.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie getPieById(int pieId);
    }
}
