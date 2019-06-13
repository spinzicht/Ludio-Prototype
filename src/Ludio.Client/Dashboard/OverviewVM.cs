using Ludio.Dashboard.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LDT = Ludio.Data.Tasks;

namespace Ludio.Dashboard
{
    public class OverviewVM
    {
        ObservableCollection<LDT.Task> Cards = new ObservableCollection<LDT.Task>();
    }
}
