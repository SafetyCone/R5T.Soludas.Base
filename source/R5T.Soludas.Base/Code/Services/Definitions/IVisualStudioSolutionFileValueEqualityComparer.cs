using System;

using R5T.Cambridge.Types;
using R5T.Vandalia;using R5T.T0064;


namespace R5T.Soludas
{[ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileValueEqualityComparer : IValueEqualityComparer<SolutionFile>,IServiceDefinition
    {
        
    }
}
