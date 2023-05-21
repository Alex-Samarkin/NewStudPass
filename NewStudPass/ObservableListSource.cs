// NewStudPass
// NewStudPass
// ObservableListSource.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 23:22 21 05 2023

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
// install EntityFramework6 from nuget
// using System.Data.Entity;

namespace NewStudPass
{
    /// <summary>
    /// standart list for db connection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : class
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}