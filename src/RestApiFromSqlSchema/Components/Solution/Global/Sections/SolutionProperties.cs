﻿using Armsoft.RestApiFromSqlSchema.Components.Solution.Global.Enumerations;

namespace Armsoft.RestApiFromSqlSchema.Components.Solution.Global.Sections
{
    public class SolutionProperties
    {
        internal static string GlobalSectionId = "SolutionProperties";
        internal static GlobalSectionType GlobalSectionType = GlobalSectionType.preSolution;

        public bool HideSolutionNode { get; }

        public SolutionProperties(bool hideSolutionNode)
        {
            HideSolutionNode = hideSolutionNode;
        }

        public override string ToString()
        {
            var hideSolutionNode = HideSolutionNode ? "TRUE" : "FALSE";
            return $"{nameof(HideSolutionNode)} = {hideSolutionNode}";
        }
    }
}