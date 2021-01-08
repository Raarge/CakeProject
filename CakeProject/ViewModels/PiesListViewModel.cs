using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeProject.Models;

namespace CakeProject.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
