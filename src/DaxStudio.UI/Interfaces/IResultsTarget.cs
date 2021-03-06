﻿
using DaxStudio.Interfaces;
using System.Threading.Tasks;

namespace DaxStudio.UI.Interfaces
{
    public interface IResultsTarget
    {
        string Name { get; }
        string Group { get; }
        //void OutputResults(IQueryRunner runner );
        Task OutputResultsAsync(IQueryRunner runner);
        bool IsDefault { get; }
        bool IsEnabled { get; }
        int DisplayOrder { get; }

        string Message { get; }
        OutputTargets Icon { get; }
    }
}
