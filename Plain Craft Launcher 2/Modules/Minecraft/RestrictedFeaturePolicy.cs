using PCL.Core.App.Localization;
using PCL.Core.UI.Hints;
using PCL.Core.App.Region;

namespace PCL;

/// <summary>
/// </summary>
internal static class RestrictedFeaturePolicy
{
    internal static RegionAssessment Assess() =>
        new RegionAssessment(RegionClassification.Other, "region-restriction-removed");

    internal static bool IsRestricted => false;

    internal static bool Check(string feature, bool showHint = true)
    {
        return true;
    }

    internal static void ThrowIfRestricted(string feature)
    {
    }
}
