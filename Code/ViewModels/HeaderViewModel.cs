using Linde.Feature.BasicContent.Models;
using System;

namespace Linde.Feature.BasicContent.ViewModels
{
    public class HeaderViewModel : HeaderBuilder
    {
        public bool HasdataSource { get; set; }
        public DateTime Date { get; internal set; }
    }
}